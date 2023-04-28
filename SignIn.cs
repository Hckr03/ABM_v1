using System;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text.RegularExpressions;
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
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (valEmptyOrNull())
            {
                MessageBox.Show("No debe dejar campos vacios");
                return;
            }
            if (!valEmail())
            {
                initializeToolTip("No corresponde a un dominio correcto!", txtMail);
                return;
            }
            if (emailExists())
            {
                initializeToolTip($"El mail: {txtMail.Text} ya existe!", txtMail);
                return;
            }

            try
            {
                saveEmpleado();
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

                passwordCheck(confirmPass, password);
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

        private void passwordCheck(string confirmPass, string password)
        {
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
            }
        }

        private Boolean valEmptyOrNull()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                return true;
            }
            return false;
        }

        private void clearSignIn()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMail.Clear();
            txtPassword.Clear();
        }

        private void initializeToolTip(string texto, TextBox txt)
        {
            tTAyuda.Show(texto, txt, 0, -25, 5000);
        }

        private Boolean emailExists()
        {
            oracle.Open();
            OracleCommand cmd = new OracleCommand(pkgName + "sp_get_empleado_by_mail", oracle);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
            cmd.Parameters.Add("po_empleado", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            OracleDataAdapter oradap = new OracleDataAdapter(cmd);
            DataTable dtable = new DataTable();
            oradap.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                oracle.Close();
                return true;
            }
            oracle.Close();
            return false;
        }

        private void saveEmpleado()
        {
            oracle.Open();
            OracleCommand cmd = new OracleCommand(pkgName + "sp_save_empleado", oracle);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pi_nombre", OracleType.VarChar).Value = txtFirstName.Text;
            cmd.Parameters.Add("pi_apellido", OracleType.VarChar).Value = txtLastName.Text;
            cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
            cmd.Parameters.Add("pi_contrasenha", OracleType.VarChar).Value = txtPassword.Text;
            cmd.Parameters.Add("po_error_message", OracleType.VarChar, 1000).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se guardo con exito!");
            clearSignIn();
        }

        public Boolean valEmail()
        {
            var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(txtMail.Text, pattern))
            {
                return true;
            }
            return false;
        }
        //END FUNCTIONS
    }
}
