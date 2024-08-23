namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_PermisosGrupos
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
            this.btnCargarPermiso = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnCargarNuevoRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarPermiso
            // 
            this.btnCargarPermiso.Location = new System.Drawing.Point(362, 131);
            this.btnCargarPermiso.Name = "btnCargarPermiso";
            this.btnCargarPermiso.Size = new System.Drawing.Size(71, 23);
            this.btnCargarPermiso.TabIndex = 15;
            this.btnCargarPermiso.Text = "&Cargar";
            this.btnCargarPermiso.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(96, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(388, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cargar nuevo permiso para grupo de usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nuevo permiso:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(132, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(139, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Location = new System.Drawing.Point(40, 95);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(83, 13);
            this.lblTipoUser.TabIndex = 11;
            this.lblTipoUser.Text = "Tipo de usuario:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(132, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(31, 170);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(508, 268);
            this.dataGridView3.TabIndex = 9;
            // 
            // btnCargarNuevoRol
            // 
            this.btnCargarNuevoRol.Location = new System.Drawing.Point(450, 131);
            this.btnCargarNuevoRol.Name = "btnCargarNuevoRol";
            this.btnCargarNuevoRol.Size = new System.Drawing.Size(71, 23);
            this.btnCargarNuevoRol.TabIndex = 8;
            this.btnCargarNuevoRol.Text = "&Guardar";
            this.btnCargarNuevoRol.UseVisualStyleBackColor = true;
            // 
            // PermisosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.btnCargarPermiso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnCargarNuevoRol);
            this.Name = "PermisosGrupos";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPermiso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnCargarNuevoRol;
    }
}