namespace Test
{
    partial class DeleteUser
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
            this.lblConfirmMail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfirmMail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpMail = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.lblConfirmMail);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gpMail);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 368);
            this.panel1.TabIndex = 0;
            // 
            // lblConfirmMail
            // 
            this.lblConfirmMail.AutoSize = true;
            this.lblConfirmMail.Location = new System.Drawing.Point(138, 182);
            this.lblConfirmMail.Name = "lblConfirmMail";
            this.lblConfirmMail.Size = new System.Drawing.Size(0, 16);
            this.lblConfirmMail.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(138, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(304, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfirmMail);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(138, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm Mail";
            // 
            // txtConfirmMail
            // 
            this.txtConfirmMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtConfirmMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmMail.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtConfirmMail.ForeColor = System.Drawing.Color.White;
            this.txtConfirmMail.Location = new System.Drawing.Point(6, 24);
            this.txtConfirmMail.MaxLength = 100;
            this.txtConfirmMail.Name = "txtConfirmMail";
            this.txtConfirmMail.Size = new System.Drawing.Size(292, 25);
            this.txtConfirmMail.TabIndex = 3;
            this.txtConfirmMail.TextChanged += new System.EventHandler(this.txtConfirmMail_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 1);
            this.panel2.TabIndex = 6;
            // 
            // gpMail
            // 
            this.gpMail.Controls.Add(this.txtMail);
            this.gpMail.Controls.Add(this.panel3);
            this.gpMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpMail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMail.ForeColor = System.Drawing.Color.White;
            this.gpMail.Location = new System.Drawing.Point(138, 38);
            this.gpMail.Margin = new System.Windows.Forms.Padding(0);
            this.gpMail.Name = "gpMail";
            this.gpMail.Size = new System.Drawing.Size(304, 67);
            this.gpMail.TabIndex = 10;
            this.gpMail.TabStop = false;
            this.gpMail.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(6, 24);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(292, 25);
            this.txtMail.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(6, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 1);
            this.panel3.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Test.Properties.Resources.BackButton;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 58);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 321);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(597, 368);
            this.MinimumSize = new System.Drawing.Size(597, 368);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpMail.ResumeLayout(false);
            this.gpMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirmMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblConfirmMail;
    }
}