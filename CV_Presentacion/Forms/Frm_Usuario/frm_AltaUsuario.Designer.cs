namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_AltaUsuario
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkdVenceUsuario = new System.Windows.Forms.MaskedTextBox();
            this.mkdVencePass = new System.Windows.Forms.MaskedTextBox();
            this.chkRecordar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPermisoUsuario = new System.Windows.Forms.DataGridView();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Lista de permisos predefinidos por el tipo de usuario.";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(153, 72);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtNombreUsuario.TabIndex = 33;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 74);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 32;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkdVenceUsuario);
            this.groupBox1.Controls.Add(this.mkdVencePass);
            this.groupBox1.Controls.Add(this.chkRecordar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(330, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 124);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas de Vencimientos";
            // 
            // mkdVenceUsuario
            // 
            this.mkdVenceUsuario.Location = new System.Drawing.Point(79, 54);
            this.mkdVenceUsuario.Mask = "00/00/0000";
            this.mkdVenceUsuario.Name = "mkdVenceUsuario";
            this.mkdVenceUsuario.Size = new System.Drawing.Size(70, 20);
            this.mkdVenceUsuario.TabIndex = 26;
            this.mkdVenceUsuario.ValidatingType = typeof(System.DateTime);
            // 
            // mkdVencePass
            // 
            this.mkdVencePass.Location = new System.Drawing.Point(79, 28);
            this.mkdVencePass.Mask = "00/00/0000";
            this.mkdVencePass.Name = "mkdVencePass";
            this.mkdVencePass.Size = new System.Drawing.Size(70, 20);
            this.mkdVencePass.TabIndex = 25;
            this.mkdVencePass.ValidatingType = typeof(System.DateTime);
            // 
            // chkRecordar
            // 
            this.chkRecordar.AutoSize = true;
            this.chkRecordar.Location = new System.Drawing.Point(20, 94);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Size = new System.Drawing.Size(178, 17);
            this.chkRecordar.TabIndex = 14;
            this.chkRecordar.Text = "Recordar vencimiento al usuario";
            this.chkRecordar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(38, 107);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 29;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Empleado:";
            // 
            // dgvPermisoUsuario
            // 
            this.dgvPermisoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisoUsuario.Location = new System.Drawing.Point(12, 188);
            this.dgvPermisoUsuario.Name = "dgvPermisoUsuario";
            this.dgvPermisoUsuario.Size = new System.Drawing.Size(525, 218);
            this.dgvPermisoUsuario.TabIndex = 27;
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(153, 101);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(150, 21);
            this.cboFamilias.TabIndex = 26;
            this.cboFamilias.SelectedIndexChanged += new System.EventHandler(this.cboFamilias_SelectedIndexChanged);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(153, 38);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(150, 21);
            this.cboEmpleados.TabIndex = 25;
            // 
            // frm_AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPermisoUsuario);
            this.Controls.Add(this.cboFamilias);
            this.Controls.Add(this.cboEmpleados);
            this.Name = "frm_AltaUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_AltaUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkdVenceUsuario;
        private System.Windows.Forms.MaskedTextBox mkdVencePass;
        private System.Windows.Forms.CheckBox chkRecordar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPermisoUsuario;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.ComboBox cboEmpleados;
    }
}