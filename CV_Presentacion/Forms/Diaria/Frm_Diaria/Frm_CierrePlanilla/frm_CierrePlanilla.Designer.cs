namespace CV_Presentacion.Forms.Frm_Registros
{
    partial class frm_CierrePlanilla
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mrkHora = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCombustible = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTestigo = new System.Windows.Forms.Label();
            this.btnTestigo = new System.Windows.Forms.Button();
            this.lblLesionado = new System.Windows.Forms.Label();
            this.btnLesionados = new System.Windows.Forms.Button();
            this.lblAccidente = new System.Windows.Forms.Label();
            this.btnAccidente = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnRecambio = new System.Windows.Forms.Button();
            this.lblCorte = new System.Windows.Forms.Label();
            this.btnCorte = new System.Windows.Forms.Button();
            this.lblControUnidad = new System.Windows.Forms.Label();
            this.btnControlUnidad = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbKm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCierre = new System.Windows.Forms.DataGridView();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblHoraS = new System.Windows.Forms.Label();
            this.lblHoraSal = new System.Windows.Forms.Label();
            this.lblRamal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierre)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ramal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Empleado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRamal);
            this.groupBox1.Controls.Add(this.lblHoraSal);
            this.groupBox1.Controls.Add(this.lblHoraS);
            this.groupBox1.Controls.Add(this.lblUnidad);
            this.groupBox1.Controls.Add(this.lblEmpleado);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(437, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 240);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 71;
            this.label20.Text = "Hora Salida Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Hora Servicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Hora Cierre:";
            // 
            // mrkHora
            // 
            this.mrkHora.Location = new System.Drawing.Point(305, 29);
            this.mrkHora.Mask = "00:00";
            this.mrkHora.Name = "mrkHora";
            this.mrkHora.Size = new System.Drawing.Size(33, 20);
            this.mrkHora.TabIndex = 5;
            this.mrkHora.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Combustible:";
            // 
            // txbCombustible
            // 
            this.txbCombustible.Location = new System.Drawing.Point(106, 59);
            this.txbCombustible.Name = "txbCombustible";
            this.txbCombustible.Size = new System.Drawing.Size(70, 20);
            this.txbCombustible.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(71, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTestigo);
            this.groupBox2.Controls.Add(this.btnTestigo);
            this.groupBox2.Controls.Add(this.lblLesionado);
            this.groupBox2.Controls.Add(this.btnLesionados);
            this.groupBox2.Controls.Add(this.lblAccidente);
            this.groupBox2.Controls.Add(this.btnAccidente);
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Controls.Add(this.btnRecambio);
            this.groupBox2.Controls.Add(this.lblCorte);
            this.groupBox2.Controls.Add(this.btnCorte);
            this.groupBox2.Controls.Add(this.lblControUnidad);
            this.groupBox2.Controls.Add(this.btnControlUnidad);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(223, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 240);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // lblTestigo
            // 
            this.lblTestigo.AutoSize = true;
            this.lblTestigo.Location = new System.Drawing.Point(150, 203);
            this.lblTestigo.Name = "lblTestigo";
            this.lblTestigo.Size = new System.Drawing.Size(13, 13);
            this.lblTestigo.TabIndex = 88;
            this.lblTestigo.Text = "0";
            // 
            // btnTestigo
            // 
            this.btnTestigo.Location = new System.Drawing.Point(169, 198);
            this.btnTestigo.Name = "btnTestigo";
            this.btnTestigo.Size = new System.Drawing.Size(27, 23);
            this.btnTestigo.TabIndex = 12;
            this.btnTestigo.Text = "+";
            this.btnTestigo.UseVisualStyleBackColor = true;
            this.btnTestigo.Click += new System.EventHandler(this.btnTestigo_Click);
            // 
            // lblLesionado
            // 
            this.lblLesionado.AutoSize = true;
            this.lblLesionado.Location = new System.Drawing.Point(150, 167);
            this.lblLesionado.Name = "lblLesionado";
            this.lblLesionado.Size = new System.Drawing.Size(13, 13);
            this.lblLesionado.TabIndex = 86;
            this.lblLesionado.Text = "0";
            // 
            // btnLesionados
            // 
            this.btnLesionados.Location = new System.Drawing.Point(169, 163);
            this.btnLesionados.Name = "btnLesionados";
            this.btnLesionados.Size = new System.Drawing.Size(27, 23);
            this.btnLesionados.TabIndex = 11;
            this.btnLesionados.Text = "+";
            this.btnLesionados.UseVisualStyleBackColor = true;
            this.btnLesionados.Click += new System.EventHandler(this.btnLesionados_Click);
            // 
            // lblAccidente
            // 
            this.lblAccidente.AutoSize = true;
            this.lblAccidente.Location = new System.Drawing.Point(150, 132);
            this.lblAccidente.Name = "lblAccidente";
            this.lblAccidente.Size = new System.Drawing.Size(13, 13);
            this.lblAccidente.TabIndex = 84;
            this.lblAccidente.Text = "0";
            // 
            // btnAccidente
            // 
            this.btnAccidente.Location = new System.Drawing.Point(169, 128);
            this.btnAccidente.Name = "btnAccidente";
            this.btnAccidente.Size = new System.Drawing.Size(27, 23);
            this.btnAccidente.TabIndex = 10;
            this.btnAccidente.Text = "+";
            this.btnAccidente.UseVisualStyleBackColor = true;
            this.btnAccidente.Click += new System.EventHandler(this.btnAccidente_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(150, 96);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(13, 13);
            this.lblCambio.TabIndex = 82;
            this.lblCambio.Text = "0";
            // 
            // btnRecambio
            // 
            this.btnRecambio.Location = new System.Drawing.Point(169, 93);
            this.btnRecambio.Name = "btnRecambio";
            this.btnRecambio.Size = new System.Drawing.Size(27, 23);
            this.btnRecambio.TabIndex = 9;
            this.btnRecambio.Text = "+";
            this.btnRecambio.UseVisualStyleBackColor = true;
            this.btnRecambio.Click += new System.EventHandler(this.btnRecambio_Click);
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(150, 63);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(13, 13);
            this.lblCorte.TabIndex = 80;
            this.lblCorte.Text = "0";
            // 
            // btnCorte
            // 
            this.btnCorte.Location = new System.Drawing.Point(169, 58);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(27, 23);
            this.btnCorte.TabIndex = 8;
            this.btnCorte.Text = "+";
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // lblControUnidad
            // 
            this.lblControUnidad.AutoSize = true;
            this.lblControUnidad.Location = new System.Drawing.Point(150, 28);
            this.lblControUnidad.Name = "lblControUnidad";
            this.lblControUnidad.Size = new System.Drawing.Size(13, 13);
            this.lblControUnidad.TabIndex = 78;
            this.lblControUnidad.Text = "0";
            // 
            // btnControlUnidad
            // 
            this.btnControlUnidad.Location = new System.Drawing.Point(169, 23);
            this.btnControlUnidad.Name = "btnControlUnidad";
            this.btnControlUnidad.Size = new System.Drawing.Size(27, 23);
            this.btnControlUnidad.TabIndex = 7;
            this.btnControlUnidad.Text = "+";
            this.btnControlUnidad.UseVisualStyleBackColor = true;
            this.btnControlUnidad.Click += new System.EventHandler(this.btnControlUnidad_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Recambio de unidad ________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Accidente ________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Testigos _________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Corte en la vía publica ______";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Lesionados _______________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Control de Unidad __________";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(227, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 22);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbKm
            // 
            this.txbKm.Location = new System.Drawing.Point(106, 30);
            this.txbKm.Name = "txbKm";
            this.txbKm.Size = new System.Drawing.Size(98, 20);
            this.txbKm.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Km Recorridos:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbKm);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbCombustible);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mrkHora);
            this.groupBox3.Location = new System.Drawing.Point(223, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorrido";
            // 
            // dgvCierre
            // 
            this.dgvCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierre.Location = new System.Drawing.Point(11, 54);
            this.dgvCierre.Name = "dgvCierre";
            this.dgvCierre.Size = new System.Drawing.Size(206, 384);
            this.dgvCierre.TabIndex = 96;
            this.dgvCierre.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCierre_CellContentDoubleClick);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(80, 33);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblEmpleado.TabIndex = 72;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(67, 75);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 73;
            // 
            // lblHoraS
            // 
            this.lblHoraS.AutoSize = true;
            this.lblHoraS.Location = new System.Drawing.Point(97, 118);
            this.lblHoraS.Name = "lblHoraS";
            this.lblHoraS.Size = new System.Drawing.Size(0, 13);
            this.lblHoraS.TabIndex = 74;
            // 
            // lblHoraSal
            // 
            this.lblHoraSal.AutoSize = true;
            this.lblHoraSal.Location = new System.Drawing.Point(132, 161);
            this.lblHoraSal.Name = "lblHoraSal";
            this.lblHoraSal.Size = new System.Drawing.Size(0, 13);
            this.lblHoraSal.TabIndex = 75;
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(63, 203);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(0, 13);
            this.lblRamal.TabIndex = 76;
            // 
            // frm_CierrePlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.dgvCierre);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frm_CierrePlanilla";
            this.Text = "frm_registros2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mrkHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCombustible;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnControlUnidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblControUnidad;
        private System.Windows.Forms.Label lblTestigo;
        private System.Windows.Forms.Button btnTestigo;
        private System.Windows.Forms.Label lblLesionado;
        private System.Windows.Forms.Button btnLesionados;
        private System.Windows.Forms.Label lblAccidente;
        private System.Windows.Forms.Button btnAccidente;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button btnRecambio;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvCierre;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.Label lblHoraSal;
        private System.Windows.Forms.Label lblHoraS;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblEmpleado;
    }
}