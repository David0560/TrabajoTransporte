namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    partial class frm_PlanillaSalida
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
            this.btnimprimir = new System.Windows.Forms.Button();
            this.dgvSalidar = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbChofer = new System.Windows.Forms.ComboBox();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.grbActualizar = new System.Windows.Forms.GroupBox();
            this.lblNomUnidad = new System.Windows.Forms.Label();
            this.lblNomChofer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskHoraLabo = new System.Windows.Forms.MaskedTextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblRamal = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.tbxCombustibleSalida = new System.Windows.Forms.TextBox();
            this.txbKmSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbModificar = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidar)).BeginInit();
            this.grbActualizar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(324, 416);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(84, 23);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // dgvSalidar
            // 
            this.dgvSalidar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidar.Location = new System.Drawing.Point(12, 53);
            this.dgvSalidar.Name = "dgvSalidar";
            this.dgvSalidar.Size = new System.Drawing.Size(208, 386);
            this.dgvSalidar.TabIndex = 2;
            this.dgvSalidar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalidar_CellDoubleClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(67, 15);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(201, 20);
            this.dtpFechas.TabIndex = 1;
            this.dtpFechas.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Unidad:";
            // 
            // CmbChofer
            // 
            this.CmbChofer.FormattingEnabled = true;
            this.CmbChofer.ItemHeight = 13;
            this.CmbChofer.Location = new System.Drawing.Point(246, 23);
            this.CmbChofer.Name = "CmbChofer";
            this.CmbChofer.Size = new System.Drawing.Size(117, 21);
            this.CmbChofer.TabIndex = 7;
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.ItemHeight = 13;
            this.CmbUnidad.Location = new System.Drawing.Point(247, 51);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(117, 21);
            this.CmbUnidad.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Empleado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Por:";
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.Location = new System.Drawing.Point(16, 86);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(68, 23);
            this.btnActualizarRegistros.TabIndex = 9;
            this.btnActualizarRegistros.Text = "Actualizar";
            this.btnActualizarRegistros.UseVisualStyleBackColor = true;
            this.btnActualizarRegistros.Click += new System.EventHandler(this.btnActualizarRegistros_Click);
            // 
            // grbActualizar
            // 
            this.grbActualizar.Controls.Add(this.lblNomUnidad);
            this.grbActualizar.Controls.Add(this.lblNomChofer);
            this.grbActualizar.Controls.Add(this.btnActualizarRegistros);
            this.grbActualizar.Controls.Add(this.label11);
            this.grbActualizar.Controls.Add(this.label13);
            this.grbActualizar.Controls.Add(this.label14);
            this.grbActualizar.Controls.Add(this.CmbUnidad);
            this.grbActualizar.Controls.Add(this.CmbChofer);
            this.grbActualizar.Controls.Add(this.label12);
            this.grbActualizar.Location = new System.Drawing.Point(235, 284);
            this.grbActualizar.Name = "grbActualizar";
            this.grbActualizar.Size = new System.Drawing.Size(380, 120);
            this.grbActualizar.TabIndex = 89;
            this.grbActualizar.TabStop = false;
            // 
            // lblNomUnidad
            // 
            this.lblNomUnidad.AutoSize = true;
            this.lblNomUnidad.Location = new System.Drawing.Point(81, 51);
            this.lblNomUnidad.Name = "lblNomUnidad";
            this.lblNomUnidad.Size = new System.Drawing.Size(81, 13);
            this.lblNomUnidad.TabIndex = 67;
            this.lblNomUnidad.Text = "Nombre Unidad";
            // 
            // lblNomChofer
            // 
            this.lblNomChofer.AutoSize = true;
            this.lblNomChofer.Location = new System.Drawing.Point(81, 27);
            this.lblNomChofer.Name = "lblNomChofer";
            this.lblNomChofer.Size = new System.Drawing.Size(78, 13);
            this.lblNomChofer.TabIndex = 66;
            this.lblNomChofer.Text = "Nombre Chofer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskHoraLabo);
            this.groupBox2.Controls.Add(this.lblUnidad);
            this.groupBox2.Controls.Add(this.lblRamal);
            this.groupBox2.Controls.Add(this.lblSalida);
            this.groupBox2.Controls.Add(this.lblChofer);
            this.groupBox2.Controls.Add(this.tbxCombustibleSalida);
            this.groupBox2.Controls.Add(this.txbKmSalida);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(235, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 209);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Planilla";
            // 
            // mskHoraLabo
            // 
            this.mskHoraLabo.Location = new System.Drawing.Point(105, 101);
            this.mskHoraLabo.Mask = "00:00";
            this.mskHoraLabo.Name = "mskHoraLabo";
            this.mskHoraLabo.Size = new System.Drawing.Size(34, 20);
            this.mskHoraLabo.TabIndex = 3;
            this.mskHoraLabo.ValidatingType = typeof(System.DateTime);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(307, 34);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 79;
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(199, 34);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(0, 13);
            this.lblRamal.TabIndex = 78;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(92, 34);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(0, 13);
            this.lblSalida.TabIndex = 77;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(84, 69);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(0, 13);
            this.lblChofer.TabIndex = 76;
            // 
            // tbxCombustibleSalida
            // 
            this.tbxCombustibleSalida.Location = new System.Drawing.Point(154, 171);
            this.tbxCombustibleSalida.Name = "tbxCombustibleSalida";
            this.tbxCombustibleSalida.Size = new System.Drawing.Size(100, 20);
            this.tbxCombustibleSalida.TabIndex = 5;
            // 
            // txbKmSalida
            // 
            this.txbKmSalida.Location = new System.Drawing.Point(127, 135);
            this.txbKmSalida.Name = "txbKmSalida";
            this.txbKmSalida.Size = new System.Drawing.Size(100, 20);
            this.txbKmSalida.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Cantidad de Combustible:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Kilometros al Salir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Hora Salida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Hora Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Unidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ramal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Empleado:";
            // 
            // ckbModificar
            // 
            this.ckbModificar.AutoSize = true;
            this.ckbModificar.Location = new System.Drawing.Point(242, 268);
            this.ckbModificar.Name = "ckbModificar";
            this.ckbModificar.Size = new System.Drawing.Size(110, 17);
            this.ckbModificar.TabIndex = 6;
            this.ckbModificar.Text = "Modificar Variable";
            this.ckbModificar.UseVisualStyleBackColor = true;
            this.ckbModificar.CheckedChanged += new System.EventHandler(this.ckbModificar_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(234, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frm_PlanillaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ckbModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpFechas);
            this.Controls.Add(this.grbActualizar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.dgvSalidar);
            this.Controls.Add(this.lblFecha);
            this.Name = "frm_PlanillaSalida";
            this.Text = "frm_PlanillaSalida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidar)).EndInit();
            this.grbActualizar.ResumeLayout(false);
            this.grbActualizar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DataGridView dgvSalidar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbChofer;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActualizarRegistros;
        private System.Windows.Forms.GroupBox grbActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNomUnidad;
        private System.Windows.Forms.Label lblNomChofer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCombustibleSalida;
        private System.Windows.Forms.TextBox txbKmSalida;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.MaskedTextBox mskHoraLabo;
    }
}