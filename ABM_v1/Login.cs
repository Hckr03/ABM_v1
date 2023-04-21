using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Login : Form
    {
        private OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        private string pkgName = "system.pkg_abm_gabriel.";
        public Login()
        {
            InitializeComponent();
            txtMail.Focus();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_getby_user_password", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
                cmd.Parameters.Add("pi_password", OracleType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("po_user", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter oradap = new OracleDataAdapter(cmd);
                DataTable dtable = new DataTable();
                oradap.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Detalles de login invalidos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtMail.Clear();
                    txtMail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                oracle.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
