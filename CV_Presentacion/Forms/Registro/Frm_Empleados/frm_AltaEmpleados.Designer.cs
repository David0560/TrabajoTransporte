namespace CV_Presentacion.Forms
{
    partial class frm_AltaEmpleados
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
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskFIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mskFNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoDoc = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRegistro = new System.Windows.Forms.CheckBox();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbGrupoTrabajo = new System.Windows.Forms.GroupBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.grpboxDireccion.SuspendLayout();
            this.lblTipoDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.gpbGrupoTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(452, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(150, 13);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(105, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(102, 17);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(531, 413);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(72, 27);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Documento:";
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.AutoSize = true;
            this.lblFIngreso.Location = new System.Drawing.Point(102, 42);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(45, 13);
            this.lblFIngreso.TabIndex = 11;
            this.lblFIngreso.Text = "Ingreso:";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.Location = new System.Drawing.Point(15, 83);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFNacimiento.TabIndex = 10;
            this.lblFNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(102, 67);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(38, 13);
            this.lblTarea.TabIndex = 15;
            this.lblTarea.Text = "Tarea:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 162);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(17, 85);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 13;
            this.lblCalle.Text = "Calle:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // cboTarea
            // 
            this.cboTarea.FormattingEnabled = true;
            this.cboTarea.Location = new System.Drawing.Point(150, 63);
            this.cboTarea.Name = "cboTarea";
            this.cboTarea.Size = new System.Drawing.Size(124, 21);
            this.cboTarea.TabIndex = 31;
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(122, 107);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(114, 21);
            this.cboDocumento.TabIndex = 32;
            this.cboDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(15, 137);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroDoc.TabIndex = 33;
            this.lblNumeroDoc.Text = "Numero:";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(74, 133);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(106, 20);
            this.txtNumeroDoc.TabIndex = 34;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(74, 159);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(92, 21);
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
            this.grpboxDireccion.Controls.Add(this.lblCalle);
            this.grpboxDireccion.Controls.Add(this.txtCalle);
            this.grpboxDireccion.Controls.Add(this.lblNumero);
            this.grpboxDireccion.Location = new System.Drawing.Point(13, 307);
            this.grpboxDireccion.Name = "grpboxDireccion";
            this.grpboxDireccion.Size = new System.Drawing.Size(252, 146);
            this.grpboxDireccion.TabIndex = 36;
            this.grpboxDireccion.TabStop = false;
            this.grpboxDireccion.Text = "Domicilio";
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(73, 25);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(163, 21);
            this.cboCiudad.TabIndex = 45;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // lblCodPost
            // 
            this.lblCodPost.AutoSize = true;
            this.lblCodPost.Location = new System.Drawing.Point(155, 114);
            this.lblCodPost.Name = "lblCodPost";
            this.lblCodPost.Size = new System.Drawing.Size(24, 13);
            this.lblCodPost.TabIndex = 44;
            this.lblCodPost.Text = "CP:";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(73, 54);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(163, 21);
            this.cboLocalidad.TabIndex = 37;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 29);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 42;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtCodPost
            // 
            this.txtCodPost.Location = new System.Drawing.Point(182, 110);
            this.txtCodPost.Name = "txtCodPost";
            this.txtCodPost.Size = new System.Drawing.Size(53, 20);
            this.txtCodPost.TabIndex = 41;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(17, 58);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 40;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(73, 110);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 39;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(73, 81);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(163, 20);
            this.txtCalle.TabIndex = 37;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 114);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Numero:";
            // 
            // mskFIngreso
            // 
            this.mskFIngreso.Location = new System.Drawing.Point(150, 38);
            this.mskFIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskFIngreso.Mask = "00/00/0000";
            this.mskFIngreso.Name = "mskFIngreso";
            this.mskFIngreso.ReadOnly = true;
            this.mskFIngreso.Size = new System.Drawing.Size(68, 20);
            this.mskFIngreso.TabIndex = 37;
            this.mskFIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // mskFNacimiento
            // 
            this.mskFNacimiento.Location = new System.Drawing.Point(111, 79);
            this.mskFNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskFNacimiento.Mask = "00/00/0000";
            this.mskFNacimiento.Name = "mskFNacimiento";
            this.mskFNacimiento.Size = new System.Drawing.Size(68, 20);
            this.mskFNacimiento.TabIndex = 38;
            this.mskFNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Controls.Add(this.lblNombre);
            this.lblTipoDoc.Controls.Add(this.lblNumeroDoc);
            this.lblTipoDoc.Controls.Add(this.mskFNacimiento);
            this.lblTipoDoc.Controls.Add(this.txtNumeroDoc);
            this.lblTipoDoc.Controls.Add(this.txtNombre);
            this.lblTipoDoc.Controls.Add(this.txtApellido);
            this.lblTipoDoc.Controls.Add(this.lblApellido);
            this.lblTipoDoc.Controls.Add(this.cboSexo);
            this.lblTipoDoc.Controls.Add(this.lblSexo);
            this.lblTipoDoc.Controls.Add(this.label5);
            this.lblTipoDoc.Controls.Add(this.lblFNacimiento);
            this.lblTipoDoc.Controls.Add(this.cboDocumento);
            this.lblTipoDoc.Location = new System.Drawing.Point(13, 115);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblTipoDoc.Size = new System.Drawing.Size(252, 187);
            this.lblTipoDoc.TabIndex = 39;
            this.lblTipoDoc.TabStop = false;
            this.lblTipoDoc.Text = "Datos Empleado";
            this.lblTipoDoc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CV_Presentacion.Properties.Resources.Add1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLegajo);
            this.groupBox2.Controls.Add(this.lblLegajo);
            this.groupBox2.Controls.Add(this.mskFIngreso);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblFIngreso);
            this.groupBox2.Controls.Add(this.lblTarea);
            this.groupBox2.Controls.Add(this.cboTarea);
            this.groupBox2.Location = new System.Drawing.Point(13, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(593, 100);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(274, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 91);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Teléfono:";
            // 
            // chkRegistro
            // 
            this.chkRegistro.AutoSize = true;
            this.chkRegistro.Location = new System.Drawing.Point(282, 212);
            this.chkRegistro.Name = "chkRegistro";
            this.chkRegistro.Size = new System.Drawing.Size(125, 17);
            this.chkRegistro.TabIndex = 42;
            this.chkRegistro.Text = "Registro de Conducir";
            this.chkRegistro.UseVisualStyleBackColor = true;
            this.chkRegistro.CheckedChanged += new System.EventHandler(this.chkRegistro_CheckedChanged);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.maskedTextBox2);
            this.gpbDatos.Controls.Add(this.maskedTextBox1);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Location = new System.Drawing.Point(278, 238);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(172, 103);
            this.gpbDatos.TabIndex = 43;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(84, 51);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox2.TabIndex = 40;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(76, 21);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox1.TabIndex = 39;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vencimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Otorgado:";
            // 
            // gpbGrupoTrabajo
            // 
            this.gpbGrupoTrabajo.Controls.Add(this.cboTurno);
            this.gpbGrupoTrabajo.Controls.Add(this.cboGrupo);
            this.gpbGrupoTrabajo.Controls.Add(this.lblTurno);
            this.gpbGrupoTrabajo.Controls.Add(this.lblGrupo);
            this.gpbGrupoTrabajo.Location = new System.Drawing.Point(458, 238);
            this.gpbGrupoTrabajo.Name = "gpbGrupoTrabajo";
            this.gpbGrupoTrabajo.Size = new System.Drawing.Size(145, 103);
            this.gpbGrupoTrabajo.TabIndex = 44;
            this.gpbGrupoTrabajo.TabStop = false;
            this.gpbGrupoTrabajo.Text = "Grupo de Trabajo";
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(61, 26);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(74, 21);
            this.cboTurno.TabIndex = 49;
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(61, 53);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(74, 21);
            this.cboGrupo.TabIndex = 46;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(16, 30);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 48;
            this.lblTurno.Text = "Turno:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(16, 57);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 47;
            this.lblGrupo.Text = "Grupo:";
            // 
            // frm_AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.gpbGrupoTrabajo);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.chkRegistro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.grpboxDireccion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frm_AltaEmpleados";
            this.Text = "Alta Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.grpboxDireccion.ResumeLayout(false);
            this.grpboxDireccion.PerformLayout();
            this.lblTipoDoc.ResumeLayout(false);
            this.lblTipoDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbGrupoTrabajo.ResumeLayout(false);
            this.gpbGrupoTrabajo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRegistro;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox gpbGrupoTrabajo;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblGrupo;
    }
}