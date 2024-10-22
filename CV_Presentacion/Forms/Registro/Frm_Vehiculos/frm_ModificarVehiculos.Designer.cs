namespace CV_Presentacion.Frm_Unidades
{
    partial class frm_ModificarVehiculos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVTV = new System.Windows.Forms.Label();
            this.mskFechaOtorgada = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMarcaChasis = new System.Windows.Forms.TextBox();
            this.txtNroChasis = new System.Windows.Forms.TextBox();
            this.lblMarcaMotor = new System.Windows.Forms.Label();
            this.lblMarcaChasis = new System.Windows.Forms.Label();
            this.cboCombustible = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.mskIngreso = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownPlaza = new System.Windows.Forms.NumericUpDown();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCantidadPlaza = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblKms = new System.Windows.Forms.Label();
            this.txtMarcaMotor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNroMotor = new System.Windows.Forms.TextBox();
            this.lblNroMotor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.lblDominio = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lsbPatente = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaza)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskFechaVencimiento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblVTV);
            this.groupBox2.Controls.Add(this.mskFechaOtorgada);
            this.groupBox2.Location = new System.Drawing.Point(33, 486);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(527, 71);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VTV";
            // 
            // mskFechaVencimiento
            // 
            this.mskFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaVencimiento.Location = new System.Drawing.Point(401, 34);
            this.mskFechaVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.mskFechaVencimiento.Mask = "00/00/0000";
            this.mskFechaVencimiento.Name = "mskFechaVencimiento";
            this.mskFechaVencimiento.Size = new System.Drawing.Size(105, 26);
            this.mskFechaVencimiento.TabIndex = 38;
            this.mskFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Otorgada:";
            // 
            // lblVTV
            // 
            this.lblVTV.AutoSize = true;
            this.lblVTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVTV.Location = new System.Drawing.Point(292, 37);
            this.lblVTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVTV.Name = "lblVTV";
            this.lblVTV.Size = new System.Drawing.Size(81, 17);
            this.lblVTV.TabIndex = 22;
            this.lblVTV.Text = "Vecimiento:";
            // 
            // mskFechaOtorgada
            // 
            this.mskFechaOtorgada.Enabled = false;
            this.mskFechaOtorgada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaOtorgada.Location = new System.Drawing.Point(153, 32);
            this.mskFechaOtorgada.Margin = new System.Windows.Forms.Padding(4);
            this.mskFechaOtorgada.Mask = "00/00/0000";
            this.mskFechaOtorgada.Name = "mskFechaOtorgada";
            this.mskFechaOtorgada.Size = new System.Drawing.Size(105, 26);
            this.mskFechaOtorgada.TabIndex = 29;
            this.mskFechaOtorgada.ValidatingType = typeof(System.DateTime);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(705, 519);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 33);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtMarcaChasis);
            this.groupBox1.Controls.Add(this.txtNroChasis);
            this.groupBox1.Controls.Add(this.lblMarcaMotor);
            this.groupBox1.Controls.Add(this.lblMarcaChasis);
            this.groupBox1.Controls.Add(this.cboCombustible);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.mskIngreso);
            this.groupBox1.Controls.Add(this.numericUpDownPlaza);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.lblIngreso);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCantidadPlaza);
            this.groupBox1.Controls.Add(this.lblCombustible);
            this.groupBox1.Controls.Add(this.lblKms);
            this.groupBox1.Controls.Add(this.txtMarcaMotor);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.txtNroMotor);
            this.groupBox1.Controls.Add(this.lblNroMotor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKms);
            this.groupBox1.Controls.Add(this.lblDominio);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtDominio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(33, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(783, 367);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CV_Presentacion.Properties.Resources.addbuss__3_;
            this.pictureBox1.Location = new System.Drawing.Point(35, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtMarcaChasis
            // 
            this.txtMarcaChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaChasis.Location = new System.Drawing.Point(155, 215);
            this.txtMarcaChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaChasis.Name = "txtMarcaChasis";
            this.txtMarcaChasis.Size = new System.Drawing.Size(220, 26);
            this.txtMarcaChasis.TabIndex = 35;
            // 
            // txtNroChasis
            // 
            this.txtNroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroChasis.Location = new System.Drawing.Point(155, 250);
            this.txtNroChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroChasis.Name = "txtNroChasis";
            this.txtNroChasis.Size = new System.Drawing.Size(211, 26);
            this.txtNroChasis.TabIndex = 34;
            // 
            // lblMarcaMotor
            // 
            this.lblMarcaMotor.AutoSize = true;
            this.lblMarcaMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMarcaMotor.Location = new System.Drawing.Point(44, 150);
            this.lblMarcaMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaMotor.Name = "lblMarcaMotor";
            this.lblMarcaMotor.Size = new System.Drawing.Size(91, 17);
            this.lblMarcaMotor.TabIndex = 32;
            this.lblMarcaMotor.Text = "Marca Motor:";
            // 
            // lblMarcaChasis
            // 
            this.lblMarcaChasis.AutoSize = true;
            this.lblMarcaChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMarcaChasis.Location = new System.Drawing.Point(44, 222);
            this.lblMarcaChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaChasis.Name = "lblMarcaChasis";
            this.lblMarcaChasis.Size = new System.Drawing.Size(97, 17);
            this.lblMarcaChasis.TabIndex = 33;
            this.lblMarcaChasis.Text = "Marca Chasis:";
            // 
            // cboCombustible
            // 
            this.cboCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCombustible.FormattingEnabled = true;
            this.cboCombustible.Items.AddRange(new object[] {
            "Diesel",
            "Diesel Premium ",
            "Biodiesel"});
            this.cboCombustible.Location = new System.Drawing.Point(548, 220);
            this.cboCombustible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCombustible.Name = "cboCombustible";
            this.cboCombustible.Size = new System.Drawing.Size(189, 28);
            this.cboCombustible.TabIndex = 31;
            this.cboCombustible.SelectedIndexChanged += new System.EventHandler(this.cboCombustible_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(548, 186);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(171, 26);
            this.txtEstado.TabIndex = 30;
            // 
            // mskIngreso
            // 
            this.mskIngreso.Enabled = false;
            this.mskIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIngreso.Location = new System.Drawing.Point(275, 22);
            this.mskIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.mskIngreso.Mask = "00/00/0000";
            this.mskIngreso.Name = "mskIngreso";
            this.mskIngreso.ReadOnly = true;
            this.mskIngreso.Size = new System.Drawing.Size(105, 26);
            this.mskIngreso.TabIndex = 28;
            this.mskIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // numericUpDownPlaza
            // 
            this.numericUpDownPlaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPlaza.Location = new System.Drawing.Point(192, 326);
            this.numericUpDownPlaza.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPlaza.Name = "numericUpDownPlaza";
            this.numericUpDownPlaza.Size = new System.Drawing.Size(53, 26);
            this.numericUpDownPlaza.TabIndex = 27;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(548, 256);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(189, 26);
            this.txtTipo.TabIndex = 19;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMarca.Location = new System.Drawing.Point(195, 65);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblModelo.Location = new System.Drawing.Point(196, 101);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIngreso.Location = new System.Drawing.Point(193, 30);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(75, 17);
            this.lblIngreso.TabIndex = 4;
            this.lblIngreso.Text = "Fecha Alta";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEstado.Location = new System.Drawing.Point(451, 192);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCantidadPlaza
            // 
            this.lblCantidadPlaza.AutoSize = true;
            this.lblCantidadPlaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCantidadPlaza.Location = new System.Drawing.Point(44, 332);
            this.lblCantidadPlaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPlaza.Name = "lblCantidadPlaza";
            this.lblCantidadPlaza.Size = new System.Drawing.Size(129, 17);
            this.lblCantidadPlaza.TabIndex = 5;
            this.lblCantidadPlaza.Text = "Cantidad de plazas";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCombustible.Location = new System.Drawing.Point(451, 228);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(93, 17);
            this.lblCombustible.TabIndex = 6;
            this.lblCombustible.Text = "Combustible: ";
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblKms.Location = new System.Drawing.Point(451, 156);
            this.lblKms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(39, 17);
            this.lblKms.TabIndex = 7;
            this.lblKms.Text = "Kms:";
            // 
            // txtMarcaMotor
            // 
            this.txtMarcaMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaMotor.Location = new System.Drawing.Point(155, 146);
            this.txtMarcaMotor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaMotor.Name = "txtMarcaMotor";
            this.txtMarcaMotor.Size = new System.Drawing.Size(243, 26);
            this.txtMarcaMotor.TabIndex = 21;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTipo.Location = new System.Drawing.Point(451, 263);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNroMotor
            // 
            this.txtNroMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroMotor.Location = new System.Drawing.Point(155, 181);
            this.txtNroMotor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroMotor.Name = "txtNroMotor";
            this.txtNroMotor.Size = new System.Drawing.Size(243, 26);
            this.txtNroMotor.TabIndex = 20;
            // 
            // lblNroMotor
            // 
            this.lblNroMotor.AutoSize = true;
            this.lblNroMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNroMotor.Location = new System.Drawing.Point(44, 186);
            this.lblNroMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroMotor.Name = "lblNroMotor";
            this.lblNroMotor.Size = new System.Drawing.Size(75, 17);
            this.lblNroMotor.TabIndex = 9;
            this.lblNroMotor.Text = "Nro Motor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(44, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nro Chasis:";
            // 
            // txtKms
            // 
            this.txtKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKms.Location = new System.Drawing.Point(548, 151);
            this.txtKms.Margin = new System.Windows.Forms.Padding(4);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(171, 26);
            this.txtKms.TabIndex = 18;
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDominio.Location = new System.Drawing.Point(44, 294);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(61, 17);
            this.lblDominio.TabIndex = 11;
            this.lblDominio.Text = "Patente:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(275, 58);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(205, 26);
            this.txtMarca.TabIndex = 12;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(275, 92);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(251, 26);
            this.txtModelo.TabIndex = 13;
            // 
            // txtDominio
            // 
            this.txtDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDominio.Location = new System.Drawing.Point(155, 288);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(195, 26);
            this.txtDominio.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblid);
            this.groupBox3.Controls.Add(this.lsbPatente);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(33, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(783, 98);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(500, 71);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 54;
            this.lblid.Text = "label2";
            this.lblid.Visible = false;
            // 
            // lsbPatente
            // 
            this.lsbPatente.FormattingEnabled = true;
            this.lsbPatente.ItemHeight = 16;
            this.lsbPatente.Location = new System.Drawing.Point(87, 51);
            this.lsbPatente.Name = "lsbPatente";
            this.lsbPatente.Size = new System.Drawing.Size(389, 36);
            this.lsbPatente.TabIndex = 53;
            this.lsbPatente.SelectedIndexChanged += new System.EventHandler(this.lsbPatente_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(484, 21);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 33);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(87, 25);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(389, 22);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Patente:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 54;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_ModificarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ModificarVehiculos";
            this.Text = "Modificar Unidades";
            this.Load += new System.EventHandler(this.frm_ModificarVehiculos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaza)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVTV;
        private System.Windows.Forms.MaskedTextBox mskFechaOtorgada;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMarcaChasis;
        private System.Windows.Forms.TextBox txtNroChasis;
        private System.Windows.Forms.Label lblMarcaMotor;
        private System.Windows.Forms.Label lblMarcaChasis;
        private System.Windows.Forms.ComboBox cboCombustible;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox mskIngreso;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaza;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCantidadPlaza;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblKms;
        private System.Windows.Forms.TextBox txtMarcaMotor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNroMotor;
        private System.Windows.Forms.Label lblNroMotor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lsbPatente;
        private System.Windows.Forms.Label lblid;
    }
}