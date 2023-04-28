using System;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test
{
    public partial class DeleteUser : Form
    {
        private OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        private string pkgName = "system.pkg_abm_gabriel.";
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmMail.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("No debe dejar campos vacios");
                return;
            }
            if (!valMail(txtMail.Text))
            {
                MessageBox.Show("Asegurese de escribir correctamente los correos!");
                return;
            }
            if (!valMail(txtConfirmMail.Text))
            {
                MessageBox.Show("Asegurese de escribir correctamente los correos!");
                return;
            }

            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar su cuenta?", "Confirmacion", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                delete();
            }
        }

        //INICIO FUNCIONES
        private Boolean valMail(string mail)
        {
            var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(mail, pattern))
            {
                return true;
            }
            return false;
        }

        private void passwordCheck(string confirmMail, string mail)
        {
            for (int i = 1; i <= confirmMail.Length; i++)
            {
                if (!confirmMail.Substring(0, i).Equals(mail.Substring(0, i)))
                {
                    lblConfirmMail.Show();
                    lblConfirmMail.Text = "Los mails no coinciden";
                    lblConfirmMail.BackColor = Color.Red;
                }
                else
                {
                    lblConfirmMail.Show();
                    lblConfirmMail.Text = "Los mails coinciden";
                    lblConfirmMail.BackColor = Color.Green;
                }
            }
            if (string.IsNullOrEmpty(confirmMail))
            {
                lblConfirmMail.Hide();
            }
            else
            {
                lblConfirmMail.Show();
            }
        }

        private void txtConfirmMail_TextChanged(object sender, EventArgs e)
        {
            string mail = txtMail.Text;

            if (mail.Length != 0)
            {
                txtConfirmMail.MaxLength = mail.Length;
                string confirmPass = txtConfirmMail.Text;

                passwordCheck(confirmPass, mail);
            }
        }

        private void delete()
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_get_empleado_by_mail", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_mail", OracleType.VarChar).Value = txtMail.Text;
                cmd.Parameters.Add("po_empleado", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    cmd = new OracleCommand(pkgName + "sp_delete_empleado", oracle);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("pi_mail_empleado", OracleType.VarChar).Value = txtMail.Text;
                    cmd.Parameters.Add("po_error_message", OracleType.VarChar, 5000).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La cuenta ha sido eliminada!");
                    txtMail.Clear();
                    txtConfirmMail.Clear();
                    lblConfirmMail.Hide();
                }
                else
                {
                    MessageBox.Show($"El mail que intenta borrar no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oracle.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            oracle.Close();
        }
    }
}
