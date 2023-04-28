namespace Test
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.gpArticulo = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddArticulo = new System.Windows.Forms.Button();
            this.btnDelArticulo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpArticulo.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNumFactura.Location = new System.Drawing.Point(123, 45);
            this.lblNumFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(122, 24);
            this.lblNumFactura.TabIndex = 3;
            this.lblNumFactura.Text = "Nro. Factura :";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.panel4);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblDocNum);
            this.gbCliente.Controls.Add(this.lblRazonSocial);
            this.gbCliente.Controls.Add(this.panel3);
            this.gbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.Color.White;
            this.gbCliente.Location = new System.Drawing.Point(46, 87);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(852, 98);
            this.gbCliente.TabIndex = 5;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtDocNum);
            this.panel4.Location = new System.Drawing.Point(207, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 25);
            this.panel4.TabIndex = 14;
            // 
            // txtDocNum
            // 
            this.txtDocNum.BackColor = System.Drawing.Color.White;
            this.txtDocNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocNum.Location = new System.Drawing.Point(8, 4);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocNum.Size = new System.Drawing.Size(503, 25);
            this.txtDocNum.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::Test.Properties.Resources.manage_search;
            this.btnBuscarCliente.Location = new System.Drawing.Point(757, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 60);
            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblDocNum
            // 
            this.lblDocNum.AutoSize = true;
            this.lblDocNum.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDocNum.Location = new System.Drawing.Point(42, 61);
            this.lblDocNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(158, 24);
            this.lblDocNum.TabIndex = 5;
            this.lblDocNum.Text = "Documento Nro. :";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRazonSocial.Location = new System.Drawing.Point(77, 26);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(123, 24);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Razon social :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtRazonSocial);
            this.panel3.Location = new System.Drawing.Point(207, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 25);
            this.panel3.TabIndex = 13;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Location = new System.Drawing.Point(8, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazonSocial.Size = new System.Drawing.Size(503, 25);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // gpArticulo
            // 
            this.gpArticulo.Controls.Add(this.panel6);
            this.gpArticulo.Controls.Add(this.txtCantidad);
            this.gpArticulo.Controls.Add(this.label4);
            this.gpArticulo.Controls.Add(this.txtStock);
            this.gpArticulo.Controls.Add(this.label3);
            this.gpArticulo.Controls.Add(this.txtPrecio);
            this.gpArticulo.Controls.Add(this.label1);
            this.gpArticulo.Controls.Add(this.button1);
            this.gpArticulo.Controls.Add(this.label2);
            this.gpArticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpArticulo.ForeColor = System.Drawing.Color.White;
            this.gpArticulo.Location = new System.Drawing.Point(46, 208);
            this.gpArticulo.Name = "gpArticulo";
            this.gpArticulo.Size = new System.Drawing.Size(852, 98);
            this.gpArticulo.TabIndex = 8;
            this.gpArticulo.TabStop = false;
            this.gpArticulo.Text = "Articulo";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtProducto);
            this.panel6.Location = new System.Drawing.Point(22, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 25);
            this.panel6.TabIndex = 14;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Location = new System.Drawing.Point(8, 3);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProducto.Size = new System.Drawing.Size(269, 25);
            this.txtProducto.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Location = new System.Drawing.Point(696, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 25);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(698, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Location = new System.Drawing.Point(544, 58);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(139, 25);
            this.txtStock.TabIndex = 11;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(544, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Location = new System.Drawing.Point(392, 58);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(139, 25);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(392, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Test.Properties.Resources.manage_search;
            this.button1.Location = new System.Drawing.Point(312, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(46, 329);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(744, 251);
            this.dgvDetalles.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddArticulo);
            this.panel2.Controls.Add(this.btnDelArticulo);
            this.panel2.Location = new System.Drawing.Point(803, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 251);
            this.panel2.TabIndex = 10;
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArticulo.FlatAppearance.BorderSize = 0;
            this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticulo.Image = global::Test.Properties.Resources.del_shopping_cart;
            this.btnAddArticulo.Location = new System.Drawing.Point(18, 14);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(60, 60);
            this.btnAddArticulo.TabIndex = 8;
            this.btnAddArticulo.UseVisualStyleBackColor = true;
            // 
            // btnDelArticulo
            // 
            this.btnDelArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelArticulo.FlatAppearance.BorderSize = 0;
            this.btnDelArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelArticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelArticulo.Image = global::Test.Properties.Resources.add_shopping_cart;
            this.btnDelArticulo.Location = new System.Drawing.Point(18, 85);
            this.btnDelArticulo.Name = "btnDelArticulo";
            this.btnDelArticulo.Size = new System.Drawing.Size(60, 60);
            this.btnDelArticulo.TabIndex = 8;
            this.btnDelArticulo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtTotalPagar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvDetalles);
            this.panel1.Controls.Add(this.gpArticulo);
            this.panel1.Controls.Add(this.gbCliente);
            this.panel1.Controls.Add(this.lblNumFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 677);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(253, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 25);
            this.panel5.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(8, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(154, 21);
            this.textBox2.TabIndex = 4;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.Color.White;
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Location = new System.Drawing.Point(587, 601);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(203, 21);
            this.txtTotalPagar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(452, 599);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total a pagar :";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(943, 677);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Factura";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpArticulo.ResumeLayout(false);
            this.gpArticulo.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox gpArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddArticulo;
        private System.Windows.Forms.Button btnDelArticulo;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtProducto;
    }
}