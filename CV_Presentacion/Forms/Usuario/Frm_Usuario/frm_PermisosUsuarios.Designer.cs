namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_PermisosUsuarios
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
            this.cboSeleccionarUsuario = new System.Windows.Forms.ComboBox();
            this.grbPermisoV = new System.Windows.Forms.GroupBox();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.mkdFechaVence = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarPermisos = new System.Windows.Forms.Button();
            this.lblFechaVence = new System.Windows.Forms.Label();
            this.btnEliminarPermisos = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarRolAUsuario = new System.Windows.Forms.Button();
            this.grbPermisoV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSeleccionarUsuario
            // 
            this.cboSeleccionarUsuario.FormattingEnabled = true;
            this.cboSeleccionarUsuario.Location = new System.Drawing.Point(21, 54);
            this.cboSeleccionarUsuario.Name = "cboSeleccionarUsuario";
            this.cboSeleccionarUsuario.Size = new System.Drawing.Size(195, 21);
            this.cboSeleccionarUsuario.TabIndex = 31;
            this.cboSeleccionarUsuario.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarUsuario_SelectedIndexChanged);
            // 
            // grbPermisoV
            // 
            this.grbPermisoV.Controls.Add(this.lblPermiso);
            this.grbPermisoV.Controls.Add(this.btnModificar);
            this.grbPermisoV.Controls.Add(this.mkdFechaVence);
            this.grbPermisoV.Controls.Add(this.label2);
            this.grbPermisoV.Controls.Add(this.btnCargarPermisos);
            this.grbPermisoV.Controls.Add(this.lblFechaVence);
            this.grbPermisoV.Location = new System.Drawing.Point(263, 26);
            this.grbPermisoV.Name = "grbPermisoV";
            this.grbPermisoV.Size = new System.Drawing.Size(362, 88);
            this.grbPermisoV.TabIndex = 30;
            this.grbPermisoV.TabStop = false;
            this.grbPermisoV.Text = "Permisos";
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Location = new System.Drawing.Point(80, 28);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(0, 13);
            this.lblPermiso.TabIndex = 26;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(275, 57);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // mkdFechaVence
            // 
            this.mkdFechaVence.Location = new System.Drawing.Point(87, 59);
            this.mkdFechaVence.Mask = "00/00/0000";
            this.mkdFechaVence.Name = "mkdFechaVence";
            this.mkdFechaVence.Size = new System.Drawing.Size(70, 20);
            this.mkdFechaVence.TabIndex = 24;
            this.mkdFechaVence.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecionar:";
            // 
            // btnCargarPermisos
            // 
            this.btnCargarPermisos.Location = new System.Drawing.Point(195, 57);
            this.btnCargarPermisos.Name = "btnCargarPermisos";
            this.btnCargarPermisos.Size = new System.Drawing.Size(74, 23);
            this.btnCargarPermisos.TabIndex = 18;
            this.btnCargarPermisos.Text = "Cargar";
            this.btnCargarPermisos.UseVisualStyleBackColor = true;
            this.btnCargarPermisos.Click += new System.EventHandler(this.btnCargarPermisos_Click);
            // 
            // lblFechaVence
            // 
            this.lblFechaVence.AutoSize = true;
            this.lblFechaVence.Location = new System.Drawing.Point(14, 62);
            this.lblFechaVence.Name = "lblFechaVence";
            this.lblFechaVence.Size = new System.Drawing.Size(71, 13);
            this.lblFechaVence.TabIndex = 23;
            this.lblFechaVence.Text = "Vencimiento: ";
            // 
            // btnEliminarPermisos
            // 
            this.btnEliminarPermisos.Location = new System.Drawing.Point(263, 279);
            this.btnEliminarPermisos.Name = "btnEliminarPermisos";
            this.btnEliminarPermisos.Size = new System.Drawing.Size(25, 35);
            this.btnEliminarPermisos.TabIndex = 8;
            this.btnEliminarPermisos.Text = "<";
            this.btnEliminarPermisos.UseVisualStyleBackColor = true;
            this.btnEliminarPermisos.Click += new System.EventHandler(this.btnEliminarPermisos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(298, 134);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(329, 309);
            this.dgvDatos.TabIndex = 28;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(8, 134);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(247, 309);
            this.dgvRoles.TabIndex = 37;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSeleccionarUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 88);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Usuario";
            // 
            // btnCargarRolAUsuario
            // 
            this.btnCargarRolAUsuario.Location = new System.Drawing.Point(263, 238);
            this.btnCargarRolAUsuario.Name = "btnCargarRolAUsuario";
            this.btnCargarRolAUsuario.Size = new System.Drawing.Size(25, 35);
            this.btnCargarRolAUsuario.TabIndex = 39;
            this.btnCargarRolAUsuario.Text = ">";
            this.btnCargarRolAUsuario.UseVisualStyleBackColor = true;
            this.btnCargarRolAUsuario.Click += new System.EventHandler(this.btnCargarRolAUsuario_Click);
            // 
            // frm_PermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 476);
            this.Controls.Add(this.btnCargarRolAUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnEliminarPermisos);
            this.Controls.Add(this.grbPermisoV);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frm_PermisosUsuarios";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_PermisosUsuarios_Load);
            this.grbPermisoV.ResumeLayout(false);
            this.grbPermisoV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboSeleccionarUsuario;
        private System.Windows.Forms.GroupBox grbPermisoV;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MaskedTextBox mkdFechaVence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarPermisos;
        private System.Windows.Forms.Button btnCargarPermisos;
        private System.Windows.Forms.Label lblFechaVence;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.Button btnCargarRolAUsuario;
    }
}