namespace CV_Presentacion
{
    partial class frm_Usuario
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabConfigurarPass = new System.Windows.Forms.TabPage();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.ckbPregunta = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.txtCantIntentos = new System.Windows.Forms.TextBox();
            this.txtMaxCaracter = new System.Windows.Forms.TextBox();
            this.txtMinCaracter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkPreguntaSeguridad = new System.Windows.Forms.CheckBox();
            this.chkBolqueoAuto = new System.Windows.Forms.CheckBox();
            this.chkDatosPersonales = new System.Windows.Forms.CheckBox();
            this.lblMinCaracteres = new System.Windows.Forms.Label();
            this.chkPassAnterior = new System.Windows.Forms.CheckBox();
            this.chkDosPasos = new System.Windows.Forms.CheckBox();
            this.chkCaracterEspecial = new System.Windows.Forms.CheckBox();
            this.chkNumLetras = new System.Windows.Forms.CheckBox();
            this.chkMayusMinus = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPreguntas = new System.Windows.Forms.TabPage();
            this.grbPregunta = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardarPregunta = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblTituloPregunta = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabGruposUsuarios = new System.Windows.Forms.TabPage();
            this.btnCargarPermiso = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnCargarNuevoRol = new System.Windows.Forms.Button();
            this.tabBloqueos = new System.Windows.Forms.TabPage();
            this.btnGuardarBloqueos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabAdministrarPermisos = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSeleccionarUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarPermisos = new System.Windows.Forms.Button();
            this.cboSeleccionarPermiso = new System.Windows.Forms.ComboBox();
            this.txtFechaVencePermiso = new System.Windows.Forms.TextBox();
            this.btnCargarPermisos = new System.Windows.Forms.Button();
            this.lblFechaVence = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblFilas = new System.Windows.Forms.Label();
            this.tabAltaUsuario = new System.Windows.Forms.TabControl();
            this.tabCrearUsuario = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVerValor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.tabConfigurarPass.SuspendLayout();
            this.tabPreguntas.SuspendLayout();
            this.grbPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabGruposUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabBloqueos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAdministrarPermisos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabAltaUsuario.SuspendLayout();
            this.tabCrearUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabConfigurarPass
            // 
            this.tabConfigurarPass.Controls.Add(this.btnGuardarConfiguracion);
            this.tabConfigurarPass.Controls.Add(this.ckbPregunta);
            this.tabConfigurarPass.Controls.Add(this.label12);
            this.tabConfigurarPass.Controls.Add(this.txtCantidadDias);
            this.tabConfigurarPass.Controls.Add(this.txtCantIntentos);
            this.tabConfigurarPass.Controls.Add(this.txtMaxCaracter);
            this.tabConfigurarPass.Controls.Add(this.txtMinCaracter);
            this.tabConfigurarPass.Controls.Add(this.label11);
            this.tabConfigurarPass.Controls.Add(this.label10);
            this.tabConfigurarPass.Controls.Add(this.chkPreguntaSeguridad);
            this.tabConfigurarPass.Controls.Add(this.chkBolqueoAuto);
            this.tabConfigurarPass.Controls.Add(this.chkDatosPersonales);
            this.tabConfigurarPass.Controls.Add(this.lblMinCaracteres);
            this.tabConfigurarPass.Controls.Add(this.chkPassAnterior);
            this.tabConfigurarPass.Controls.Add(this.chkDosPasos);
            this.tabConfigurarPass.Controls.Add(this.chkCaracterEspecial);
            this.tabConfigurarPass.Controls.Add(this.chkNumLetras);
            this.tabConfigurarPass.Controls.Add(this.chkMayusMinus);
            this.tabConfigurarPass.Controls.Add(this.label9);
            this.tabConfigurarPass.Location = new System.Drawing.Point(4, 22);
            this.tabConfigurarPass.Name = "tabConfigurarPass";
            this.tabConfigurarPass.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigurarPass.Size = new System.Drawing.Size(563, 450);
            this.tabConfigurarPass.TabIndex = 11;
            this.tabConfigurarPass.Text = "Configurar password";
            this.tabConfigurarPass.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(463, 405);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConfiguracion.TabIndex = 18;
            this.btnGuardarConfiguracion.Text = "&Guardar";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // ckbPregunta
            // 
            this.ckbPregunta.AutoSize = true;
            this.ckbPregunta.Location = new System.Drawing.Point(35, 337);
            this.ckbPregunta.Name = "ckbPregunta";
            this.ckbPregunta.Size = new System.Drawing.Size(145, 17);
            this.ckbPregunta.TabIndex = 17;
            this.ckbPregunta.Text = "Cargar nuevas preguntas";
            this.ckbPregunta.UseVisualStyleBackColor = true;
            this.ckbPregunta.CheckedChanged += new System.EventHandler(this.ckbPregunta_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "dias para el bloqueo";
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(227, 362);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(35, 20);
            this.txtCantidadDias.TabIndex = 15;
            // 
            // txtCantIntentos
            // 
            this.txtCantIntentos.Location = new System.Drawing.Point(36, 139);
            this.txtCantIntentos.Name = "txtCantIntentos";
            this.txtCantIntentos.Size = new System.Drawing.Size(36, 20);
            this.txtCantIntentos.TabIndex = 14;
            // 
            // txtMaxCaracter
            // 
            this.txtMaxCaracter.Location = new System.Drawing.Point(36, 109);
            this.txtMaxCaracter.Name = "txtMaxCaracter";
            this.txtMaxCaracter.Size = new System.Drawing.Size(36, 20);
            this.txtMaxCaracter.TabIndex = 12;
            // 
            // txtMinCaracter
            // 
            this.txtMinCaracter.Location = new System.Drawing.Point(36, 81);
            this.txtMinCaracter.Name = "txtMinCaracter";
            this.txtMinCaracter.Size = new System.Drawing.Size(36, 20);
            this.txtMinCaracter.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cantidad de intentos erróneos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Valor máximo de caracteres";
            // 
            // chkPreguntaSeguridad
            // 
            this.chkPreguntaSeguridad.AutoSize = true;
            this.chkPreguntaSeguridad.Location = new System.Drawing.Point(36, 314);
            this.chkPreguntaSeguridad.Name = "chkPreguntaSeguridad";
            this.chkPreguntaSeguridad.Size = new System.Drawing.Size(178, 17);
            this.chkPreguntaSeguridad.TabIndex = 10;
            this.chkPreguntaSeguridad.Text = "Realizar preguntas de seguridad";
            this.chkPreguntaSeguridad.UseVisualStyleBackColor = true;
            // 
            // chkBolqueoAuto
            // 
            this.chkBolqueoAuto.AutoSize = true;
            this.chkBolqueoAuto.Location = new System.Drawing.Point(35, 365);
            this.chkBolqueoAuto.Name = "chkBolqueoAuto";
            this.chkBolqueoAuto.Size = new System.Drawing.Size(172, 17);
            this.chkBolqueoAuto.TabIndex = 9;
            this.chkBolqueoAuto.Text = "Bloqueo de usuario automático";
            this.chkBolqueoAuto.UseVisualStyleBackColor = true;
            // 
            // chkDatosPersonales
            // 
            this.chkDatosPersonales.AutoSize = true;
            this.chkDatosPersonales.Location = new System.Drawing.Point(36, 291);
            this.chkDatosPersonales.Name = "chkDatosPersonales";
            this.chkDatosPersonales.Size = new System.Drawing.Size(207, 17);
            this.chkDatosPersonales.TabIndex = 8;
            this.chkDatosPersonales.Text = "No incluir datos personales del usuario";
            this.chkDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // lblMinCaracteres
            // 
            this.lblMinCaracteres.AutoSize = true;
            this.lblMinCaracteres.Location = new System.Drawing.Point(78, 88);
            this.lblMinCaracteres.Name = "lblMinCaracteres";
            this.lblMinCaracteres.Size = new System.Drawing.Size(136, 13);
            this.lblMinCaracteres.TabIndex = 6;
            this.lblMinCaracteres.Text = "Valor mínimo de caracteres";
            // 
            // chkPassAnterior
            // 
            this.chkPassAnterior.AutoSize = true;
            this.chkPassAnterior.Location = new System.Drawing.Point(36, 268);
            this.chkPassAnterior.Name = "chkPassAnterior";
            this.chkPassAnterior.Size = new System.Drawing.Size(154, 17);
            this.chkPassAnterior.TabIndex = 5;
            this.chkPassAnterior.Text = "Repetir contraseña anterior";
            this.chkPassAnterior.UseVisualStyleBackColor = true;
            // 
            // chkDosPasos
            // 
            this.chkDosPasos.AutoSize = true;
            this.chkDosPasos.Location = new System.Drawing.Point(36, 245);
            this.chkDosPasos.Name = "chkDosPasos";
            this.chkDosPasos.Size = new System.Drawing.Size(206, 17);
            this.chkDosPasos.TabIndex = 4;
            this.chkDosPasos.Text = "Realizará autenticacion en dos pasos.";
            this.chkDosPasos.UseVisualStyleBackColor = true;
            // 
            // chkCaracterEspecial
            // 
            this.chkCaracterEspecial.AutoSize = true;
            this.chkCaracterEspecial.Location = new System.Drawing.Point(36, 222);
            this.chkCaracterEspecial.Name = "chkCaracterEspecial";
            this.chkCaracterEspecial.Size = new System.Drawing.Size(289, 17);
            this.chkCaracterEspecial.TabIndex = 3;
            this.chkCaracterEspecial.Text = "Requiere la precencia de al menos un caracter especial";
            this.chkCaracterEspecial.UseVisualStyleBackColor = true;
            // 
            // chkNumLetras
            // 
            this.chkNumLetras.AutoSize = true;
            this.chkNumLetras.Location = new System.Drawing.Point(36, 199);
            this.chkNumLetras.Name = "chkNumLetras";
            this.chkNumLetras.Size = new System.Drawing.Size(241, 17);
            this.chkNumLetras.TabIndex = 2;
            this.chkNumLetras.Text = "Requiere convinaciones con numeros y letras";
            this.chkNumLetras.UseVisualStyleBackColor = true;
            // 
            // chkMayusMinus
            // 
            this.chkMayusMinus.AutoSize = true;
            this.chkMayusMinus.Location = new System.Drawing.Point(36, 176);
            this.chkMayusMinus.Name = "chkMayusMinus";
            this.chkMayusMinus.Size = new System.Drawing.Size(266, 17);
            this.chkMayusMinus.TabIndex = 1;
            this.chkMayusMinus.Text = "Requiere convinacion de mayusculas y minusculas";
            this.chkMayusMinus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(498, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Control de requisitos para la creacion de password";
            // 
            // tabPreguntas
            // 
            this.tabPreguntas.Controls.Add(this.grbPregunta);
            this.tabPreguntas.Controls.Add(this.lblTituloPregunta);
            this.tabPreguntas.Controls.Add(this.dataGridView2);
            this.tabPreguntas.Location = new System.Drawing.Point(4, 22);
            this.tabPreguntas.Name = "tabPreguntas";
            this.tabPreguntas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreguntas.Size = new System.Drawing.Size(563, 450);
            this.tabPreguntas.TabIndex = 10;
            this.tabPreguntas.Text = "Pregunta";
            this.tabPreguntas.UseVisualStyleBackColor = true;
            // 
            // grbPregunta
            // 
            this.grbPregunta.Controls.Add(this.label13);
            this.grbPregunta.Controls.Add(this.btnGuardarPregunta);
            this.grbPregunta.Controls.Add(this.textBox7);
            this.grbPregunta.Location = new System.Drawing.Point(19, 58);
            this.grbPregunta.Name = "grbPregunta";
            this.grbPregunta.Size = new System.Drawing.Size(518, 59);
            this.grbPregunta.TabIndex = 5;
            this.grbPregunta.TabStop = false;
            this.grbPregunta.Text = "Agregar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nueva pregunta:";
            // 
            // btnGuardarPregunta
            // 
            this.btnGuardarPregunta.Location = new System.Drawing.Point(431, 21);
            this.btnGuardarPregunta.Name = "btnGuardarPregunta";
            this.btnGuardarPregunta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPregunta.TabIndex = 1;
            this.btnGuardarPregunta.Text = "&Guardar";
            this.btnGuardarPregunta.UseVisualStyleBackColor = true;
            this.btnGuardarPregunta.Click += new System.EventHandler(this.btnGuardarPregunta_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(115, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(295, 20);
            this.textBox7.TabIndex = 3;
            // 
            // lblTituloPregunta
            // 
            this.lblTituloPregunta.AutoSize = true;
            this.lblTituloPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPregunta.Location = new System.Drawing.Point(120, 19);
            this.lblTituloPregunta.Name = "lblTituloPregunta";
            this.lblTituloPregunta.Size = new System.Drawing.Size(319, 24);
            this.lblTituloPregunta.TabIndex = 4;
            this.lblTituloPregunta.Text = "Cargar nueva pregunta de seguridad";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(525, 283);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabGruposUsuarios
            // 
            this.tabGruposUsuarios.Controls.Add(this.btnCargarPermiso);
            this.tabGruposUsuarios.Controls.Add(this.label15);
            this.tabGruposUsuarios.Controls.Add(this.label14);
            this.tabGruposUsuarios.Controls.Add(this.comboBox4);
            this.tabGruposUsuarios.Controls.Add(this.lblTipoUser);
            this.tabGruposUsuarios.Controls.Add(this.comboBox3);
            this.tabGruposUsuarios.Controls.Add(this.dataGridView3);
            this.tabGruposUsuarios.Controls.Add(this.btnCargarNuevoRol);
            this.tabGruposUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabGruposUsuarios.Name = "tabGruposUsuarios";
            this.tabGruposUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabGruposUsuarios.Size = new System.Drawing.Size(563, 450);
            this.tabGruposUsuarios.TabIndex = 7;
            this.tabGruposUsuarios.Text = "Usuarios y permisos";
            this.tabGruposUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCargarPermiso
            // 
            this.btnCargarPermiso.Location = new System.Drawing.Point(358, 122);
            this.btnCargarPermiso.Name = "btnCargarPermiso";
            this.btnCargarPermiso.Size = new System.Drawing.Size(71, 23);
            this.btnCargarPermiso.TabIndex = 7;
            this.btnCargarPermiso.Text = "&Cargar";
            this.btnCargarPermiso.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(92, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(388, 24);
            this.label15.TabIndex = 6;
            this.label15.Text = "Cargar nuevo permiso para grupo de usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Nuevo permiso:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(128, 119);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(139, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Location = new System.Drawing.Point(36, 86);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(83, 13);
            this.lblTipoUser.TabIndex = 3;
            this.lblTipoUser.Text = "Tipo de usuario:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(128, 83);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 161);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(508, 268);
            this.dataGridView3.TabIndex = 1;
            // 
            // btnCargarNuevoRol
            // 
            this.btnCargarNuevoRol.Location = new System.Drawing.Point(446, 122);
            this.btnCargarNuevoRol.Name = "btnCargarNuevoRol";
            this.btnCargarNuevoRol.Size = new System.Drawing.Size(71, 23);
            this.btnCargarNuevoRol.TabIndex = 0;
            this.btnCargarNuevoRol.Text = "&Guardar";
            this.btnCargarNuevoRol.UseVisualStyleBackColor = true;
            // 
            // tabBloqueos
            // 
            this.tabBloqueos.Controls.Add(this.btnGuardarBloqueos);
            this.tabBloqueos.Controls.Add(this.label8);
            this.tabBloqueos.Controls.Add(this.dataGridView1);
            this.tabBloqueos.Location = new System.Drawing.Point(4, 22);
            this.tabBloqueos.Name = "tabBloqueos";
            this.tabBloqueos.Padding = new System.Windows.Forms.Padding(3);
            this.tabBloqueos.Size = new System.Drawing.Size(563, 450);
            this.tabBloqueos.TabIndex = 2;
            this.tabBloqueos.Text = "Bloqueos";
            this.tabBloqueos.UseVisualStyleBackColor = true;
            // 
            // btnGuardarBloqueos
            // 
            this.btnGuardarBloqueos.Location = new System.Drawing.Point(465, 405);
            this.btnGuardarBloqueos.Name = "btnGuardarBloqueos";
            this.btnGuardarBloqueos.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarBloqueos.TabIndex = 2;
            this.btnGuardarBloqueos.Text = "&Guardar";
            this.btnGuardarBloqueos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bloqueos de usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabAdministrarPermisos
            // 
            this.tabAdministrarPermisos.Controls.Add(this.label7);
            this.tabAdministrarPermisos.Controls.Add(this.cboSeleccionarUsuario);
            this.tabAdministrarPermisos.Controls.Add(this.groupBox3);
            this.tabAdministrarPermisos.Controls.Add(this.dgvDatos);
            this.tabAdministrarPermisos.Controls.Add(this.lblFilas);
            this.tabAdministrarPermisos.Location = new System.Drawing.Point(4, 22);
            this.tabAdministrarPermisos.Name = "tabAdministrarPermisos";
            this.tabAdministrarPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdministrarPermisos.Size = new System.Drawing.Size(563, 450);
            this.tabAdministrarPermisos.TabIndex = 1;
            this.tabAdministrarPermisos.Text = "Administrar Permisos";
            this.tabAdministrarPermisos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Buscar Usuario:";
            // 
            // cboSeleccionarUsuario
            // 
            this.cboSeleccionarUsuario.FormattingEnabled = true;
            this.cboSeleccionarUsuario.Location = new System.Drawing.Point(127, 28);
            this.cboSeleccionarUsuario.Name = "cboSeleccionarUsuario";
            this.cboSeleccionarUsuario.Size = new System.Drawing.Size(220, 21);
            this.cboSeleccionarUsuario.TabIndex = 25;
            this.cboSeleccionarUsuario.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarUsuario_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEliminarPermisos);
            this.groupBox3.Controls.Add(this.cboSeleccionarPermiso);
            this.groupBox3.Controls.Add(this.txtFechaVencePermiso);
            this.groupBox3.Controls.Add(this.btnCargarPermisos);
            this.groupBox3.Controls.Add(this.lblFechaVence);
            this.groupBox3.Location = new System.Drawing.Point(19, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 88);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos";
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
            this.btnEliminarPermisos.Location = new System.Drawing.Point(429, 51);
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
            this.cboSeleccionarPermiso.Size = new System.Drawing.Size(220, 21);
            this.cboSeleccionarPermiso.TabIndex = 17;
            // 
            // txtFechaVencePermiso
            // 
            this.txtFechaVencePermiso.Location = new System.Drawing.Point(108, 53);
            this.txtFechaVencePermiso.Name = "txtFechaVencePermiso";
            this.txtFechaVencePermiso.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencePermiso.TabIndex = 24;
            // 
            // btnCargarPermisos
            // 
            this.btnCargarPermisos.Location = new System.Drawing.Point(429, 19);
            this.btnCargarPermisos.Name = "btnCargarPermisos";
            this.btnCargarPermisos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarPermisos.TabIndex = 18;
            this.btnCargarPermisos.Text = "Cargar";
            this.btnCargarPermisos.UseVisualStyleBackColor = true;
            // 
            // lblFechaVence
            // 
            this.lblFechaVence.AutoSize = true;
            this.lblFechaVence.Location = new System.Drawing.Point(20, 57);
            this.lblFechaVence.Name = "lblFechaVence";
            this.lblFechaVence.Size = new System.Drawing.Size(71, 13);
            this.lblFechaVence.TabIndex = 23;
            this.lblFechaVence.Text = "Vencimiento: ";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(19, 162);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(522, 274);
            this.dgvDatos.TabIndex = 1;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(386, 28);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(84, 13);
            this.lblFilas.TabIndex = 1;
            this.lblFilas.Text = "cantidad de filas";
            // 
            // tabAltaUsuario
            // 
            this.tabAltaUsuario.Controls.Add(this.tabCrearUsuario);
            this.tabAltaUsuario.Controls.Add(this.tabAdministrarPermisos);
            this.tabAltaUsuario.Controls.Add(this.tabBloqueos);
            this.tabAltaUsuario.Controls.Add(this.tabGruposUsuarios);
            this.tabAltaUsuario.Controls.Add(this.tabPreguntas);
            this.tabAltaUsuario.Controls.Add(this.tabConfigurarPass);
            this.tabAltaUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAltaUsuario.Location = new System.Drawing.Point(0, 0);
            this.tabAltaUsuario.Name = "tabAltaUsuario";
            this.tabAltaUsuario.SelectedIndex = 0;
            this.tabAltaUsuario.Size = new System.Drawing.Size(571, 476);
            this.tabAltaUsuario.TabIndex = 2;
            this.tabAltaUsuario.SelectedIndexChanged += new System.EventHandler(this.tabAltaUsuario_SelectedIndexChanged);
            // 
            // tabCrearUsuario
            // 
            this.tabCrearUsuario.Controls.Add(this.label6);
            this.tabCrearUsuario.Controls.Add(this.lblVerValor);
            this.tabCrearUsuario.Controls.Add(this.lblDate);
            this.tabCrearUsuario.Controls.Add(this.txtNombreUsuario);
            this.tabCrearUsuario.Controls.Add(this.lblNombreUsuario);
            this.tabCrearUsuario.Controls.Add(this.groupBox1);
            this.tabCrearUsuario.Controls.Add(this.button3);
            this.tabCrearUsuario.Controls.Add(this.lblTipoUsuario);
            this.tabCrearUsuario.Controls.Add(this.label1);
            this.tabCrearUsuario.Controls.Add(this.dgvPermisoUsuario);
            this.tabCrearUsuario.Controls.Add(this.cboFamilias);
            this.tabCrearUsuario.Controls.Add(this.cboEmpleados);
            this.tabCrearUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabCrearUsuario.Name = "tabCrearUsuario";
            this.tabCrearUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearUsuario.Size = new System.Drawing.Size(563, 450);
            this.tabCrearUsuario.TabIndex = 0;
            this.tabCrearUsuario.Text = "Nuevo Usuario";
            this.tabCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lista de permisos predefinidos por el tipo de usuario.";
            // 
            // lblVerValor
            // 
            this.lblVerValor.AutoSize = true;
            this.lblVerValor.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.lblVerValor.Location = new System.Drawing.Point(265, 418);
            this.lblVerValor.Name = "lblVerValor";
            this.lblVerValor.Size = new System.Drawing.Size(35, 13);
            this.lblVerValor.TabIndex = 23;
            this.lblVerValor.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 418);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 13);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Dia: ";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(159, 70);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtNombreUsuario.TabIndex = 20;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(43, 72);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 19;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkdVenceUsuario);
            this.groupBox1.Controls.Add(this.mkdVencePass);
            this.groupBox1.Controls.Add(this.chkRecordar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(336, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 124);
            this.groupBox1.TabIndex = 14;
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
            this.button3.Location = new System.Drawing.Point(468, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(44, 105);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 6;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empleado:";
            // 
            // dgvPermisoUsuario
            // 
            this.dgvPermisoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisoUsuario.Location = new System.Drawing.Point(18, 186);
            this.dgvPermisoUsuario.Name = "dgvPermisoUsuario";
            this.dgvPermisoUsuario.Size = new System.Drawing.Size(525, 218);
            this.dgvPermisoUsuario.TabIndex = 4;
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(159, 99);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(150, 21);
            this.cboFamilias.TabIndex = 1;
            this.cboFamilias.SelectedIndexChanged += new System.EventHandler(this.cboFamilias_SelectedIndexChanged);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(159, 36);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(150, 21);
            this.cboEmpleados.TabIndex = 0;
            this.cboEmpleados.SelectedIndexChanged += new System.EventHandler(this.cboEmpleados_SelectedIndexChanged);
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.tabAltaUsuario);
            this.Name = "frm_Usuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frm_Usuario_Load_1);
            this.tabConfigurarPass.ResumeLayout(false);
            this.tabConfigurarPass.PerformLayout();
            this.tabPreguntas.ResumeLayout(false);
            this.tabPreguntas.PerformLayout();
            this.grbPregunta.ResumeLayout(false);
            this.grbPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabGruposUsuarios.ResumeLayout(false);
            this.tabGruposUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabBloqueos.ResumeLayout(false);
            this.tabBloqueos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAdministrarPermisos.ResumeLayout(false);
            this.tabAdministrarPermisos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tabAltaUsuario.ResumeLayout(false);
            this.tabCrearUsuario.ResumeLayout(false);
            this.tabCrearUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabConfigurarPass;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.CheckBox ckbPregunta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.TextBox txtCantIntentos;
        private System.Windows.Forms.TextBox txtMaxCaracter;
        private System.Windows.Forms.TextBox txtMinCaracter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkPreguntaSeguridad;
        private System.Windows.Forms.CheckBox chkBolqueoAuto;
        private System.Windows.Forms.CheckBox chkDatosPersonales;
        private System.Windows.Forms.Label lblMinCaracteres;
        private System.Windows.Forms.CheckBox chkPassAnterior;
        private System.Windows.Forms.CheckBox chkDosPasos;
        private System.Windows.Forms.CheckBox chkCaracterEspecial;
        private System.Windows.Forms.CheckBox chkNumLetras;
        private System.Windows.Forms.CheckBox chkMayusMinus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPreguntas;
        private System.Windows.Forms.GroupBox grbPregunta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardarPregunta;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblTituloPregunta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabGruposUsuarios;
        private System.Windows.Forms.Button btnCargarPermiso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnCargarNuevoRol;
        private System.Windows.Forms.TabPage tabBloqueos;
        private System.Windows.Forms.Button btnGuardarBloqueos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabAdministrarPermisos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSeleccionarUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarPermisos;
        private System.Windows.Forms.ComboBox cboSeleccionarPermiso;
        private System.Windows.Forms.TextBox txtFechaVencePermiso;
        private System.Windows.Forms.Button btnCargarPermisos;
        private System.Windows.Forms.Label lblFechaVence;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.TabControl tabAltaUsuario;
        private System.Windows.Forms.TabPage tabCrearUsuario;
        private System.Windows.Forms.Label lblVerValor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRecordar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPermisoUsuario;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkdVenceUsuario;
        private System.Windows.Forms.MaskedTextBox mkdVencePass;
    }
}