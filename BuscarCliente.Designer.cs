namespace Test
{
    partial class BuscarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResultBuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.cbListBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.dgvResultBuscar);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.cbListBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 359);
            this.panel1.TabIndex = 0;
            // 
            // dgvResultBuscar
            // 
            this.dgvResultBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultBuscar.Location = new System.Drawing.Point(56, 121);
            this.dgvResultBuscar.Name = "dgvResultBuscar";
            this.dgvResultBuscar.RowHeadersWidth = 51;
            this.dgvResultBuscar.RowTemplate.Height = 24;
            this.dgvResultBuscar.Size = new System.Drawing.Size(457, 205);
            this.dgvResultBuscar.TabIndex = 4;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(151, 67);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(274, 28);
            this.txtBuscador.TabIndex = 2;
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbListBuscar
            // 
            this.cbListBuscar.FormattingEnabled = true;
            this.cbListBuscar.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos",
            "Nro. Documento"});
            this.cbListBuscar.Location = new System.Drawing.Point(151, 33);
            this.cbListBuscar.Name = "cbListBuscar";
            this.cbListBuscar.Size = new System.Drawing.Size(154, 29);
            this.cbListBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Test.Properties.Resources.add_circle_outline_40x40;
            this.button1.Location = new System.Drawing.Point(519, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 52);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 359);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbListBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgvResultBuscar;
    }
}