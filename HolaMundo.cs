using System;

using System.Data;
using System.Data.OracleClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Test
{
    public partial class HolaMundo : Form
    {
        private OracleConnection oracle = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234; USER ID = SYSTEM");
        private string pkgName = "system.pkg_abm_gabriel.";
        public HolaMundo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabledClientBtn();
            disabledProductBtn();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            oracle.Open();
            disabledClientBtn();
            disabledProductBtn();
            MessageBox.Show("Conectado");
            clearDataGrid();
            oracle.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            enabledClientBtn();
            disabledProductBtn();
            oracle.Open();
            OracleCommand cmd = new OracleCommand(pkgName + "sp_listar_clientes", oracle);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("po_retorno", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dvgClientes.DataSource = tabla;

            oracle.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try { 
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_insert_clientes", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_nombre", OracleType.VarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("pi_apellido", OracleType.VarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("pi_sexo", OracleType.Char).Value = txtSexo.Text;
                cmd.Parameters.Add("pi_documento", OracleType.VarChar).Value = txtDocumento.Text;
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se guardo con exito!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + " Hubo un error al intentar guardar el registro!");
            }
            oracle.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try{
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_update_clientes", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_nombre", OracleType.VarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("pi_apellido", OracleType.VarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("pi_sexo", OracleType.Char).Value = txtSexo.Text;
                cmd.Parameters.Add("pi_documento", OracleType.VarChar).Value = txtDocumento.Text;
                cmd.Parameters.Add("pi_id", OracleType.Number).Value = txtId.Text;
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se modifico con exito!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar modificar el registro!");
            }
            oracle.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_delete_clientes", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_id", OracleType.Number).Value = txtId.Text;
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se borro con exito!");
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar borrar el registro!");
            }
            oracle.Close();
        }

        private void cleanDisplay()
        {
            //clientes
            txtNombre.Text = ""; 
            txtApellido.Text = ""; 
            txtSexo.Text = ""; 
            txtDocumento.Text = "";
            txtId.Text = "";

            //productos
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtCategoria.Text = "";
            txtDescuento.Text = "";
            txtCantidades.Text = "";
            txtIdProducto.Text = "";
        }

        private void enabledClientBtn()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtSexo.Enabled = true;
            txtDocumento.Enabled = true;
            txtId.Enabled = true;
        }

        private void disabledClientBtn()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtSexo.Enabled = false;
            txtDocumento.Enabled = false;
            txtId.Enabled = false;
        }

        private void enabledProductBtn()
        {
            txtNombreProducto.Enabled = true;
            txtPrecioUnitario.Enabled = true;
            txtCategoria.Enabled = true;
            txtDescuento.Enabled = true;
            txtCantidades.Enabled = true;
            txtIdProducto.Enabled = true;
        }
        private void disabledProductBtn()
        {
            txtNombreProducto.Enabled = false;
            txtPrecioUnitario.Enabled = false;
            txtCategoria.Enabled = false;
            txtDescuento.Enabled = false;
            txtCantidades.Enabled = false;
            txtIdProducto.Enabled = false;
        }

        private void clearDataGrid()
        {
            dvgClientes.DataSource = null;
            dvgClientes.Refresh();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            enabledProductBtn();
            disabledClientBtn();
            oracle.Open();
            OracleCommand cmd = new OracleCommand(pkgName + "sp_listar_productos", oracle);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("po_productos", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dvgClientes.DataSource = tabla;

            oracle.Close();
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_insert_producto", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_nombre_producto", OracleType.VarChar).Value = txtNombreProducto.Text;
                cmd.Parameters.Add("pi_precio_unidad", OracleType.Number).Value = Convert.ToInt32(txtPrecioUnitario.Text);
                cmd.Parameters.Add("pi_categoria", OracleType.VarChar).Value = txtCategoria.Text;
                cmd.Parameters.Add("pi_descuento", OracleType.Number).Value = Convert.ToInt32(txtDescuento.Text);
                cmd.Parameters.Add("pi_cantidad_total", OracleType.Number).Value = Convert.ToInt32(txtCantidades.Text);
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se guardo con exito!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar guardar el registro!");
            }
            oracle.Close();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_update_productos", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_nombre_producto", OracleType.VarChar).Value = txtNombreProducto.Text;
                cmd.Parameters.Add("pi_precio_unidad", OracleType.Number).Value = Convert.ToInt32(txtPrecioUnitario.Text);
                cmd.Parameters.Add("pi_categoria", OracleType.VarChar).Value = txtCategoria.Text;
                cmd.Parameters.Add("pi_descuento", OracleType.Number).Value = Convert.ToInt32(txtDescuento.Text);
                cmd.Parameters.Add("pi_cantidad_total", OracleType.Number).Value = Convert.ToInt32(txtCantidades.Text);
                cmd.Parameters.Add("pi_id", OracleType.Number).Value = Convert.ToInt32(txtIdProducto.Text);
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se guardo con exito!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar guardar el registro!");
            }
            oracle.Close();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand cmd = new OracleCommand(pkgName + "sp_delete_byId", oracle);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_id", OracleType.Number).Value = txtIdProducto.Text;
                cmd.ExecuteNonQuery();
                cleanDisplay();
                MessageBox.Show("Se borro con exito!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar borrar el registro!");
            }
            oracle.Close();
        }
    }
}
