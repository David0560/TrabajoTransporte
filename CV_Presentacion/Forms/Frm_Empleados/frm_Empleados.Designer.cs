namespace CV_Presentacion.Forms
{
    partial class frm_Empleados
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFIngreso = new System.Windows.Forms.Label();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboTarea = new System.Windows.Forms.ComboBox();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.grpboxDireccion = new System.Windows.Forms.GroupBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblCodPost = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCodPost = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.mskFIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mskFNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoDoc = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpboxDireccion.SuspendLayout();
            this.lblTipoDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(638, 535);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 42);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(75, 18);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(156, 26);
            this.txtLegajo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(326, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(326, 68);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(228, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(8, 22);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(224, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(224, 75);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(756, 535);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 42);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Documento";
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.AutoSize = true;
            this.lblFIngreso.Location = new System.Drawing.Point(242, 22);
            this.lblFIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(112, 20);
            this.lblFIngreso.TabIndex = 11;
            this.lblFIngreso.Text = "Fecha Ingreso";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.Location = new System.Drawing.Point(224, 118);
            this.lblFNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(137, 20);
            this.lblFNacimiento.TabIndex = 10;
            this.lblFNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(519, 23);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(50, 20);
            this.lblTarea.TabIndex = 15;
            this.lblTarea.Text = "Tarea";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(224, 212);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(15, 48);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(48, 20);
            this.lblCalle.TabIndex = 13;
            this.lblCalle.Text = "Calle:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(466, 214);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(524, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // cboTarea
            // 
            this.cboTarea.FormattingEnabled = true;
            this.cboTarea.Location = new System.Drawing.Point(639, 20);
            this.cboTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTarea.Name = "cboTarea";
            this.cboTarea.Size = new System.Drawing.Size(184, 28);
            this.cboTarea.TabIndex = 31;
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(384, 155);
            this.cboDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(169, 28);
            this.cboDocumento.TabIndex = 32;
            this.cboDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(576, 162);
            this.lblNumeroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(69, 20);
            this.lblNumeroDoc.TabIndex = 33;
            this.lblNumeroDoc.Text = "Numero:";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(656, 155);
            this.txtNumeroDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(157, 26);
            this.txtNumeroDoc.TabIndex = 34;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(294, 208);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(136, 28);
            this.cboSexo.TabIndex = 35;
            // 
            // grpboxDireccion
            // 
            this.grpboxDireccion.Controls.Add(this.cboCiudad);
            this.grpboxDireccion.Controls.Add(this.lblCodPost);
            this.grpboxDireccion.Controls.Add(this.cboLocalidad);
            this.grpboxDireccion.Controls.Add(this.lblCiudad);
            this.grpboxDireccion.Controls.Add(this.txtCodPost);
            this.grpboxDireccion.Controls.Add(this.lblLocalidad);
            this.grpboxDireccion.Controls.Add(this.txtNumero);
            this.grpboxDireccion.Controls.Add(this.lblNumero);
            this.grpboxDireccion.Controls.Add(this.txtCalle);
            this.grpboxDireccion.Controls.Add(this.lblCalle);
            this.grpboxDireccion.Location = new System.Drawing.Point(20, 365);
            this.grpboxDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxDireccion.Name = "grpboxDireccion";
            this.grpboxDireccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxDireccion.Size = new System.Drawing.Size(844, 160);
            this.grpboxDireccion.TabIndex = 36;
            this.grpboxDireccion.TabStop = false;
            this.grpboxDireccion.Text = "Domicilio";
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(456, 42);
            this.cboCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(214, 28);
            this.cboCiudad.TabIndex = 45;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // lblCodPost
            // 
            this.lblCodPost.AutoSize = true;
            this.lblCodPost.Location = new System.Drawing.Point(678, 91);
            this.lblCodPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodPost.Name = "lblCodPost";
            this.lblCodPost.Size = new System.Drawing.Size(30, 20);
            this.lblCodPost.TabIndex = 44;
            this.lblCodPost.Text = "CP";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(456, 85);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(214, 28);
            this.cboLocalidad.TabIndex = 37;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(389, 45);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 42;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCodPost
            // 
            this.txtCodPost.Location = new System.Drawing.Point(716, 85);
            this.txtCodPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodPost.Name = "txtCodPost";
            this.txtCodPost.Size = new System.Drawing.Size(76, 26);
            this.txtCodPost.TabIndex = 41;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(371, 88);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 40;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 86);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(168, 26);
            this.txtNumero.TabIndex = 39;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 92);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Numero:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(111, 42);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(220, 26);
            this.txtCalle.TabIndex = 37;
            // 
            // mskFIngreso
            // 
            this.mskFIngreso.Location = new System.Drawing.Point(362, 18);
            this.mskFIngreso.Mask = "00/00/0000";
            this.mskFIngreso.Name = "mskFIngreso";
            this.mskFIngreso.ReadOnly = true;
            this.mskFIngreso.Size = new System.Drawing.Size(100, 26);
            this.mskFIngreso.TabIndex = 37;
            this.mskFIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // mskFNacimiento
            // 
            this.mskFNacimiento.Location = new System.Drawing.Point(368, 112);
            this.mskFNacimiento.Mask = "00/00/0000";
            this.mskFNacimiento.Name = "mskFNacimiento";
            this.mskFNacimiento.Size = new System.Drawing.Size(100, 26);
            this.mskFNacimiento.TabIndex = 38;
            this.mskFNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Controls.Add(this.pictureBox1);
            this.lblTipoDoc.Controls.Add(this.lblNombre);
            this.lblTipoDoc.Controls.Add(this.mskFNacimiento);
            this.lblTipoDoc.Controls.Add(this.txtNombre);
            this.lblTipoDoc.Controls.Add(this.txtApellido);
            this.lblTipoDoc.Controls.Add(this.lblApellido);
            this.lblTipoDoc.Controls.Add(this.cboSexo);
            this.lblTipoDoc.Controls.Add(this.label5);
            this.lblTipoDoc.Controls.Add(this.txtNumeroDoc);
            this.lblTipoDoc.Controls.Add(this.lblFNacimiento);
            this.lblTipoDoc.Controls.Add(this.lblNumeroDoc);
            this.lblTipoDoc.Controls.Add(this.lblEmail);
            this.lblTipoDoc.Controls.Add(this.cboDocumento);
            this.lblTipoDoc.Controls.Add(this.lblSexo);
            this.lblTipoDoc.Controls.Add(this.txtEmail);
            this.lblTipoDoc.Location = new System.Drawing.Point(20, 89);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(844, 268);
            this.lblTipoDoc.TabIndex = 39;
            this.lblTipoDoc.TabStop = false;
            this.lblTipoDoc.Text = "Datos Empleado";
            this.lblTipoDoc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CV_Presentacion.Properties.Resources.Add1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLegajo);
            this.groupBox2.Controls.Add(this.lblLegajo);
            this.groupBox2.Controls.Add(this.mskFIngreso);
            this.groupBox2.Controls.Add(this.lblFIngreso);
            this.groupBox2.Controls.Add(this.lblTarea);
            this.groupBox2.Controls.Add(this.cboTarea);
            this.groupBox2.Location = new System.Drawing.Point(20, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 66);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.grpboxDireccion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Empleados";
            this.Text = "Alta Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.grpboxDireccion.ResumeLayout(false);
            this.grpboxDireccion.PerformLayout();
            this.lblTipoDoc.ResumeLayout(false);
            this.lblTipoDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFIngreso;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboTarea;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.GroupBox grpboxDireccion;
        private System.Windows.Forms.Label lblCodPost;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCodPost;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox mskFIngreso;
        private System.Windows.Forms.MaskedTextBox mskFNacimiento;
        private System.Windows.Forms.GroupBox lblTipoDoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCiudad;
    }
}