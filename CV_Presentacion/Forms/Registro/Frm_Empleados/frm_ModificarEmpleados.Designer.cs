namespace CV_Presentacion.Frm_Empleados
{
    partial class frm_ModificarEmpleados
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtApellid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipoDNI = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpboxDireccion = new System.Windows.Forms.GroupBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroDomicilio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.rbNomAp = new System.Windows.Forms.RadioButton();
            this.lsbEmpleado = new System.Windows.Forms.ListBox();
            this.mskFIngreso = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpboxDireccion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(138, 29);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(389, 22);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CV_Presentacion.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(451, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(517, 105);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 33);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(417, 105);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 33);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTarea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbFecha);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.txtApellid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumeroDNI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbTipoDNI);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(16, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(631, 235);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(351, 207);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(61, 16);
            this.Telefono.TabIndex = 48;
            this.Telefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(425, 204);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 22);
            this.txtTelefono.TabIndex = 49;
            this.txtTelefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tarea:";
            // 
            // cboTarea
            // 
            this.cboTarea.FormattingEnabled = true;
            this.cboTarea.Location = new System.Drawing.Point(420, 167);
            this.cboTarea.Name = "cboTarea";
            this.cboTarea.Size = new System.Drawing.Size(92, 24);
            this.cboTarea.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(169, 89);
            this.mtbFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(89, 22);
            this.mtbFecha.TabIndex = 38;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 22);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSexo.Location = new System.Drawing.Point(108, 174);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 35;
            // 
            // txtApellid
            // 
            this.txtApellid.Location = new System.Drawing.Point(132, 54);
            this.txtApellid.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellid.Name = "txtApellid";
            this.txtApellid.Size = new System.Drawing.Size(203, 22);
            this.txtApellid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Documento";
            // 
            // txtNumeroDNI
            // 
            this.txtNumeroDNI.Location = new System.Drawing.Point(420, 134);
            this.txtNumeroDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDNI.Name = "txtNumeroDNI";
            this.txtNumeroDNI.Size = new System.Drawing.Size(140, 22);
            this.txtNumeroDNI.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Email";
            // 
            // cbTipoDNI
            // 
            this.cbTipoDNI.FormattingEnabled = true;
            this.cbTipoDNI.Location = new System.Drawing.Point(184, 134);
            this.cbTipoDNI.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoDNI.Name = "cbTipoDNI";
            this.cbTipoDNI.Size = new System.Drawing.Size(151, 24);
            this.cbTipoDNI.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 206);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // grpboxDireccion
            // 
            this.grpboxDireccion.Controls.Add(this.cbCiudad);
            this.grpboxDireccion.Controls.Add(this.label16);
            this.grpboxDireccion.Controls.Add(this.cbLocalidad);
            this.grpboxDireccion.Controls.Add(this.btnModificar);
            this.grpboxDireccion.Controls.Add(this.btnGuardar);
            this.grpboxDireccion.Controls.Add(this.btnEliminar);
            this.grpboxDireccion.Controls.Add(this.label14);
            this.grpboxDireccion.Controls.Add(this.txtCP);
            this.grpboxDireccion.Controls.Add(this.label15);
            this.grpboxDireccion.Controls.Add(this.txtNumeroDomicilio);
            this.grpboxDireccion.Controls.Add(this.label13);
            this.grpboxDireccion.Controls.Add(this.txtDireccion);
            this.grpboxDireccion.Controls.Add(this.label10);
            this.grpboxDireccion.Location = new System.Drawing.Point(16, 396);
            this.grpboxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxDireccion.Name = "grpboxDireccion";
            this.grpboxDireccion.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxDireccion.Size = new System.Drawing.Size(631, 160);
            this.grpboxDireccion.TabIndex = 50;
            this.grpboxDireccion.TabStop = false;
            this.grpboxDireccion.Text = "Domicilio";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(392, 26);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(191, 24);
            this.cbCiudad.TabIndex = 53;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 110);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 44;
            this.label16.Text = "CP";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(392, 66);
            this.cbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(191, 24);
            this.cbLocalidad.TabIndex = 37;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(316, 105);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 33);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 70);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Localidad";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(101, 105);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(68, 22);
            this.txtCP.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Ciudad";
            // 
            // txtNumeroDomicilio
            // 
            this.txtNumeroDomicilio.Location = new System.Drawing.Point(97, 69);
            this.txtNumeroDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDomicilio.Name = "txtNumeroDomicilio";
            this.txtNumeroDomicilio.Size = new System.Drawing.Size(149, 22);
            this.txtNumeroDomicilio.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Numero:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 33);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 22);
            this.txtDireccion.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dirección:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskFIngreso);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.rbDni);
            this.groupBox2.Controls.Add(this.rbNomAp);
            this.groupBox2.Controls.Add(this.lsbEmpleado);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(631, 98);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(477, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 56;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Location = new System.Drawing.Point(53, 54);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(51, 20);
            this.rbDni.TabIndex = 55;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "DNI";
            this.rbDni.UseVisualStyleBackColor = true;
            this.rbDni.CheckedChanged += new System.EventHandler(this.rbDni_CheckedChanged);
            // 
            // rbNomAp
            // 
            this.rbNomAp.AutoSize = true;
            this.rbNomAp.Location = new System.Drawing.Point(53, 31);
            this.rbNomAp.Name = "rbNomAp";
            this.rbNomAp.Size = new System.Drawing.Size(78, 20);
            this.rbNomAp.TabIndex = 54;
            this.rbNomAp.TabStop = true;
            this.rbNomAp.Text = "Apellido";
            this.rbNomAp.UseVisualStyleBackColor = true;
            this.rbNomAp.CheckedChanged += new System.EventHandler(this.rbNomAp_CheckedChanged);
            // 
            // lsbEmpleado
            // 
            this.lsbEmpleado.FormattingEnabled = true;
            this.lsbEmpleado.ItemHeight = 16;
            this.lsbEmpleado.Location = new System.Drawing.Point(138, 53);
            this.lsbEmpleado.Name = "lsbEmpleado";
            this.lsbEmpleado.Size = new System.Drawing.Size(389, 36);
            this.lsbEmpleado.TabIndex = 53;
            this.lsbEmpleado.SelectedIndexChanged += new System.EventHandler(this.lsbEmpleado_SelectedIndexChanged);
            // 
            // mskFIngreso
            // 
            this.mskFIngreso.Location = new System.Drawing.Point(542, 9);
            this.mskFIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskFIngreso.Mask = "00/00/0000";
            this.mskFIngreso.Name = "mskFIngreso";
            this.mskFIngreso.ReadOnly = true;
            this.mskFIngreso.Size = new System.Drawing.Size(89, 22);
            this.mskFIngreso.TabIndex = 50;
            this.mskFIngreso.ValidatingType = typeof(System.DateTime);
            this.mskFIngreso.Visible = false;
            this.mskFIngreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFIngreso_MaskInputRejected);
            // 
            // frm_ModificarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxDireccion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ModificarEmpleados";
            this.Text = "Modificar Empleados";
            this.Load += new System.EventHandler(this.frm_ModificarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxDireccion.ResumeLayout(false);
            this.grpboxDireccion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipoDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpboxDireccion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumeroDomicilio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox lsbEmpleado;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.RadioButton rbNomAp;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTarea;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox mskFIngreso;
    }
}