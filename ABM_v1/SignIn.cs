using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class SignIn : Form
    {
        private OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        private string pkgName = "system.pkg_abm_gabriel.";
        public SignIn()
        {
            InitializeComponent();
            btnSignUp.Enabled = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {                
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_create_user", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_firstName", OracleType.VarChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("pi_lastname", OracleType.VarChar).Value = txtLastName.Text;
                cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
                cmd.Parameters.Add("pi_nickname", OracleType.VarChar).Value = txtNickname.Text;
                cmd.Parameters.Add("pi_dob", OracleType.VarChar).Value = dateDob.Text;
                cmd.Parameters.Add("pi_password", OracleType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("po_error_message", OracleType.VarChar, 1000).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var outValue = cmd.Parameters["po_error_message"].Value;
                MessageBox.Show(outValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al intentar registrarse!");
            }
            oracle.Close();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length != 0)
            {
                txtConfirmPass.MaxLength = password.Length;
                string confirmPass = txtConfirmPass.Text;

                for (int i = 1; i <= confirmPass.Length; i++)
                {
                    if (!confirmPass.Substring(0, i).Equals(password.Substring(0, i)))
                    {
                        lblConfirmPass.Show();
                        lblConfirmPass.Text = "Los passwords no coinciden";
                        lblConfirmPass.BackColor = Color.Red;
                    }
                    else
                    {
                        lblConfirmPass.Show();
                        lblConfirmPass.Text = "Los passwords coinciden";
                        lblConfirmPass.BackColor = Color.Green;
                    }
                }
                if (string.IsNullOrEmpty(confirmPass))
                {
                    lblConfirmPass.Hide();
                }
                else
                {
                    lblConfirmPass.Show();
                }

                if (confirmPass.Length.Equals(password.Length) && confirmPass.Equals(password))
                {
                    txtConfirmPass.Enabled = false;
                    enableBtnSignUp();
                }
            }
        }
        private void enableBtnSignUp()
        {
            string firtsName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nickName = txtNickname.Text;
            string mail = txtMail.Text;
            string date = dateDob.Text;
            string pass = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;

            if(string.IsNullOrEmpty(firtsName) || string.IsNullOrEmpty(lastName)
                || string.IsNullOrEmpty(nickName) || string.IsNullOrEmpty(mail)
                || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(pass)
                || string.IsNullOrEmpty(confirmPass) && !txtConfirmPass.Enabled)
            {
                btnSignUp.Enabled = false;
            }
            else
            { 
                btnSignUp.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblConfirmPass.Hide();
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Clear();
            }
        }
    }
}
