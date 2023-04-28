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
    public partial class BuscarCliente : Form
    {
        OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        string pkgName = "system.pkg_abm_gabriel.";
        List<string> clientes = new List<string>();
        DataTable dtFiltered = new DataTable();
        public BuscarCliente()
        {
            InitializeComponent();
            cbListBuscar.SelectedIndex = 0;
            getAllClients();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtBuscador.Text.Trim();
            PerformSearchAndUpdateGridView(searchQuery);
        }

        private void getAllClients()
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_get_all_clientes", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("po_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
                
                OracleDataAdapter adaptador = new OracleDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dtFiltered.Columns.Add("Nombre", typeof(string));
                dtFiltered.Columns.Add("Apellido", typeof(string));
                dtFiltered.Columns.Add("CI", typeof(string));
                dtFiltered.Columns.Add("Email", typeof(string));

                foreach(DataRow row in tabla.Rows) 
                {
                    DataRow newRow = dtFiltered.NewRow();
                    newRow["Nombre"] = row["Nombre"];
                    newRow["Apellido"] = row["Apellido"];
                    newRow["CI"] = row["Documento"];
                    newRow["Email"] = row["Email"];
                    dtFiltered.Rows.Add(newRow);
                }

                dgvResultBuscar.DataSource = dtFiltered;

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                oracle.Close();
            }
        }
        private void PerformSearchAndUpdateGridView(string searchQuery)
        {
            // Query data source based on search query
            var searchResults = dtFiltered.AsEnumerable().Where(row =>
                row.Field<string>("Nombre").Contains(searchQuery) ||
                row.Field<string>("Apellido").Contains(searchQuery) ||
                row.Field<string>("CI").Contains(searchQuery) ||
                row.Field<string>("Email").Contains(searchQuery)
            // Add more columns as necessary
            );

            // Clear existing rows from DataGridView
            dgvResultBuscar.DataSource = null;
            dgvResultBuscar.Rows.Clear();

            // Add search results to DataGridView
            foreach (var row in searchResults)
            {
                dgvResultBuscar.Rows.Add(row["Nombre"], row["Apellido"], row["CI"], row["Email"]);
                // Add more columns as necessary
            }
        }
    }
}
