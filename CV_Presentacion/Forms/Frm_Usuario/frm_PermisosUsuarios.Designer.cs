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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSeleccionarUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.mkdFechaVence = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarPermisos = new System.Windows.Forms.Button();
            this.cboSeleccionarPermiso = new System.Windows.Forms.ComboBox();
            this.btnCargarPermisos = new System.Windows.Forms.Button();
            this.lblFechaVence = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblFilas = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Para eliminar o modificar debe seleccionar la fila a la cual desea aplicar dicha " +
    "acción.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Buscar Usuario:";
            // 
            // cboSeleccionarUsuario
            // 
            this.cboSeleccionarUsuario.FormattingEnabled = true;
            this.cboSeleccionarUsuario.Location = new System.Drawing.Point(131, 29);
            this.cboSeleccionarUsuario.Name = "cboSeleccionarUsuario";
            this.cboSeleccionarUsuario.Size = new System.Drawing.Size(201, 21);
            this.cboSeleccionarUsuario.TabIndex = 31;
            this.cboSeleccionarUsuario.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarUsuario_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.mkdFechaVence);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEliminarPermisos);
            this.groupBox3.Controls.Add(this.cboSeleccionarPermiso);
            this.groupBox3.Controls.Add(this.btnCargarPermisos);
            this.groupBox3.Controls.Add(this.lblFechaVence);
            this.groupBox3.Location = new System.Drawing.Point(23, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 88);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(356, 59);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // mkdFechaVence
            // 
            this.mkdFechaVence.Location = new System.Drawing.Point(425, 22);
            this.mkdFechaVence.Mask = "00/00/0000";
            this.mkdFechaVence.Name = "mkdFechaVence";
            this.mkdFechaVence.Size = new System.Drawing.Size(70, 20);
            this.mkdFechaVence.TabIndex = 24;
            this.mkdFechaVence.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecionar:";
            // 
            // btnEliminarPermisos
            // 
            this.btnEliminarPermisos.Location = new System.Drawing.Point(437, 59);
            this.btnEliminarPermisos.Name = "btnEliminarPermisos";
            this.btnEliminarPermisos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPermisos.TabIndex = 8;
            this.btnEliminarPermisos.Text = "Eliminar";
            this.btnEliminarPermisos.UseVisualStyleBackColor = true;
            // 
            // cboSeleccionarPermiso
            // 
            this.cboSeleccionarPermiso.FormattingEnabled = true;
            this.cboSeleccionarPermiso.Location = new System.Drawing.Point(108, 22);
            this.cboSeleccionarPermiso.Name = "cboSeleccionarPermiso";
            this.cboSeleccionarPermiso.Size = new System.Drawing.Size(201, 21);
            this.cboSeleccionarPermiso.TabIndex = 17;
            this.cboSeleccionarPermiso.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarPermiso_SelectedIndexChanged);
            // 
            // btnCargarPermisos
            // 
            this.btnCargarPermisos.Location = new System.Drawing.Point(275, 59);
            this.btnCargarPermisos.Name = "btnCargarPermisos";
            this.btnCargarPermisos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarPermisos.TabIndex = 18;
            this.btnCargarPermisos.Text = "Cargar";
            this.btnCargarPermisos.UseVisualStyleBackColor = true;
            // 
            // lblFechaVence
            // 
            this.lblFechaVence.AutoSize = true;
            this.lblFechaVence.Location = new System.Drawing.Point(348, 26);
            this.lblFechaVence.Name = "lblFechaVence";
            this.lblFechaVence.Size = new System.Drawing.Size(71, 13);
            this.lblFechaVence.TabIndex = 23;
            this.lblFechaVence.Text = "Vencimiento: ";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(23, 185);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(522, 258);
            this.dgvDatos.TabIndex = 28;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(390, 29);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(84, 13);
            this.lblFilas.TabIndex = 29;
            this.lblFilas.Text = "cantidad de filas";
            // 
            // frm_PermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboSeleccionarUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblFilas);
            this.Name = "frm_PermisosUsuarios";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_PermisosUsuarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSeleccionarUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MaskedTextBox mkdFechaVence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarPermisos;
        private System.Windows.Forms.ComboBox cboSeleccionarPermiso;
        private System.Windows.Forms.Button btnCargarPermisos;
        private System.Windows.Forms.Label lblFechaVence;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblFilas;
    }
}