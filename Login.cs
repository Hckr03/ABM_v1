using System;
using System.Data;
using System.Data.OracleClient;
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
                OracleCommand cmd = new OracleCommand(pkgName + "sp_get_mail_pass", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
                cmd.Parameters.Add("pi_pass", OracleType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("po_empleado", OracleType.Cursor).Direction = ParameterDirection.Output;

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
                    txtMail.Clear();
                    txtPassword.Clear();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteUser delete = new DeleteUser();
            delete.Show();
            this.Hide();
        }
    }
}
