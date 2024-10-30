namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_Bloqueos
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
            this.btnNuevoPassword = new System.Windows.Forms.Button();
            this.btnGuardarBloqueos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLeyendaBloqueo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLeyendaPassword = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoPassword
            // 
            this.btnNuevoPassword.Location = new System.Drawing.Point(223, 49);
            this.btnNuevoPassword.Name = "btnNuevoPassword";
            this.btnNuevoPassword.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPassword.TabIndex = 7;
            this.btnNuevoPassword.Text = "Generar";
            this.btnNuevoPassword.UseVisualStyleBackColor = true;
            this.btnNuevoPassword.Click += new System.EventHandler(this.btnNuevoPassword_Click);
            // 
            // btnGuardarBloqueos
            // 
            this.btnGuardarBloqueos.Location = new System.Drawing.Point(223, 48);
            this.btnGuardarBloqueos.Name = "btnGuardarBloqueos";
            this.btnGuardarBloqueos.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarBloqueos.TabIndex = 6;
            this.btnGuardarBloqueos.Text = "&Actualizar";
            this.btnGuardarBloqueos.UseVisualStyleBackColor = true;
            this.btnGuardarBloqueos.Click += new System.EventHandler(this.btnGuardarBloqueos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bloqueos de usuarios";
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(24, 81);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(523, 188);
            this.dgvListaUsuarios.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLeyendaBloqueo);
            this.groupBox1.Controls.Add(this.btnGuardarBloqueos);
            this.groupBox1.Location = new System.Drawing.Point(24, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloqueo.";
            // 
            // lblLeyendaBloqueo
            // 
            this.lblLeyendaBloqueo.AutoSize = true;
            this.lblLeyendaBloqueo.Location = new System.Drawing.Point(20, 25);
            this.lblLeyendaBloqueo.Name = "lblLeyendaBloqueo";
            this.lblLeyendaBloqueo.Size = new System.Drawing.Size(0, 13);
            this.lblLeyendaBloqueo.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLeyendaPassword);
            this.groupBox2.Controls.Add(this.btnNuevoPassword);
            this.groupBox2.Location = new System.Drawing.Point(24, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // lblLeyendaPassword
            // 
            this.lblLeyendaPassword.AutoSize = true;
            this.lblLeyendaPassword.Location = new System.Drawing.Point(16, 27);
            this.lblLeyendaPassword.Name = "lblLeyendaPassword";
            this.lblLeyendaPassword.Size = new System.Drawing.Size(35, 13);
            this.lblLeyendaPassword.TabIndex = 8;
            this.lblLeyendaPassword.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(340, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario.";
            // 
            // frm_Bloqueos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Name = "frm_Bloqueos";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_Bloqueos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPassword;
        private System.Windows.Forms.Button btnGuardarBloqueos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLeyendaBloqueo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLeyendaPassword;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}