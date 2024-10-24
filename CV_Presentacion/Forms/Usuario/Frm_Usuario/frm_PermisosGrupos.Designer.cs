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
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.cboTUsuarios = new System.Windows.Forms.ComboBox();
            this.dgvPermisosFamilia = new System.Windows.Forms.DataGridView();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarPermiso
            // 
            this.btnCargarPermiso.Location = new System.Drawing.Point(270, 301);
            this.btnCargarPermiso.Name = "btnCargarPermiso";
            this.btnCargarPermiso.Size = new System.Drawing.Size(25, 44);
            this.btnCargarPermiso.TabIndex = 15;
            this.btnCargarPermiso.Text = ">";
            this.btnCargarPermiso.UseVisualStyleBackColor = true;
            this.btnCargarPermiso.Click += new System.EventHandler(this.btnCargarPermiso_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(96, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(388, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cargar nuevo permiso para grupo de usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Asignar:";
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Location = new System.Drawing.Point(23, 67);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(83, 13);
            this.lblTipoUser.TabIndex = 11;
            this.lblTipoUser.Text = "Tipo de usuario:";
            // 
            // cboTUsuarios
            // 
            this.cboTUsuarios.FormattingEnabled = true;
            this.cboTUsuarios.Location = new System.Drawing.Point(115, 64);
            this.cboTUsuarios.Name = "cboTUsuarios";
            this.cboTUsuarios.Size = new System.Drawing.Size(139, 21);
            this.cboTUsuarios.TabIndex = 10;
            this.cboTUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboTUsuarios_SelectedIndexChanged);
            // 
            // dgvPermisosFamilia
            // 
            this.dgvPermisosFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosFamilia.Location = new System.Drawing.Point(301, 147);
            this.dgvPermisosFamilia.Name = "dgvPermisosFamilia";
            this.dgvPermisosFamilia.Size = new System.Drawing.Size(254, 319);
            this.dgvPermisosFamilia.TabIndex = 9;
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(270, 251);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(25, 44);
            this.btnEliminarPermiso.TabIndex = 8;
            this.btnEliminarPermiso.Text = "<";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(10, 147);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(254, 319);
            this.dgvRoles.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contiene:";
            // 
            // frm_PermisosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnCargarPermiso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.cboTUsuarios);
            this.Controls.Add(this.dgvPermisosFamilia);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Name = "frm_PermisosGrupos";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frm_PermisosGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPermiso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.ComboBox cboTUsuarios;
        private System.Windows.Forms.DataGridView dgvPermisosFamilia;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label label1;
    }
}