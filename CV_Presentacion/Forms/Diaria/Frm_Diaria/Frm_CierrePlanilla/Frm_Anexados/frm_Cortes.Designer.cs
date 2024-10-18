namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    partial class frm_Cortes
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
            this.mskHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.txbMotivo = new System.Windows.Forms.TextBox();
            this.txbRetoma = new System.Windows.Forms.TextBox();
            this.txbLugar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCorte = new System.Windows.Forms.DataGridView();
            this.btnElimiar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskHoraSalida);
            this.groupBox2.Controls.Add(this.mskHora);
            this.groupBox2.Controls.Add(this.txbMotivo);
            this.groupBox2.Controls.Add(this.txbRetoma);
            this.groupBox2.Controls.Add(this.txbLugar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cortes";
            // 
            // mskHoraSalida
            // 
            this.mskHoraSalida.Location = new System.Drawing.Point(91, 158);
            this.mskHoraSalida.Mask = "00:00";
            this.mskHoraSalida.Name = "mskHoraSalida";
            this.mskHoraSalida.Size = new System.Drawing.Size(40, 20);
            this.mskHoraSalida.TabIndex = 6;
            this.mskHoraSalida.ValidatingType = typeof(System.DateTime);
            // 
            // mskHora
            // 
            this.mskHora.Location = new System.Drawing.Point(71, 30);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(37, 20);
            this.mskHora.TabIndex = 2;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // txbMotivo
            // 
            this.txbMotivo.Location = new System.Drawing.Point(71, 93);
            this.txbMotivo.Name = "txbMotivo";
            this.txbMotivo.Size = new System.Drawing.Size(213, 20);
            this.txbMotivo.TabIndex = 4;
            // 
            // txbRetoma
            // 
            this.txbRetoma.Location = new System.Drawing.Point(71, 125);
            this.txbRetoma.Name = "txbRetoma";
            this.txbRetoma.Size = new System.Drawing.Size(213, 20);
            this.txbRetoma.TabIndex = 5;
            // 
            // txbLugar
            // 
            this.txbLugar.Location = new System.Drawing.Point(71, 61);
            this.txbLugar.Name = "txbLugar";
            this.txbLugar.Size = new System.Drawing.Size(213, 20);
            this.txbLugar.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Retomo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hora Salida:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(95, 220);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 24);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(247, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 24);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvCorte
            // 
            this.dgvCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorte.Location = new System.Drawing.Point(19, 250);
            this.dgvCorte.Name = "dgvCorte";
            this.dgvCorte.Size = new System.Drawing.Size(304, 136);
            this.dgvCorte.TabIndex = 11;
            // 
            // btnElimiar
            // 
            this.btnElimiar.Location = new System.Drawing.Point(171, 220);
            this.btnElimiar.Name = "btnElimiar";
            this.btnElimiar.Size = new System.Drawing.Size(75, 24);
            this.btnElimiar.TabIndex = 9;
            this.btnElimiar.Text = "Elimiar";
            this.btnElimiar.UseVisualStyleBackColor = true;
            this.btnElimiar.Click += new System.EventHandler(this.btnElimiar_Click);
            // 
            // frm_Cortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 401);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCorte);
            this.Controls.Add(this.btnElimiar);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Cortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cortes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbMotivo;
        private System.Windows.Forms.TextBox txbRetoma;
        private System.Windows.Forms.TextBox txbLugar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCorte;
        private System.Windows.Forms.Button btnElimiar;
        private System.Windows.Forms.MaskedTextBox mskHoraSalida;
        private System.Windows.Forms.MaskedTextBox mskHora;
    }
}