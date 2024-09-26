namespace CV_Presentacion.Forms.Documentacion
{
    partial class frm_ActualizarVtv
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
            this.dgvVerificacionVtv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mskVence = new System.Windows.Forms.MaskedTextBox();
            this.mskOtorgado = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificacionVtv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerificacionVtv
            // 
            this.dgvVerificacionVtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerificacionVtv.Location = new System.Drawing.Point(25, 12);
            this.dgvVerificacionVtv.Name = "dgvVerificacionVtv";
            this.dgvVerificacionVtv.Size = new System.Drawing.Size(497, 213);
            this.dgvVerificacionVtv.TabIndex = 5;
            this.dgvVerificacionVtv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerificacionVtv_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblFechaV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblModelo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblDominio);
            this.groupBox2.Controls.Add(this.lblUnidad);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(25, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.mskVence);
            this.groupBox1.Controls.Add(this.mskOtorgado);
            this.groupBox1.Location = new System.Drawing.Point(281, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 134);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Otorgado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Vencimiento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(99, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mskVence
            // 
            this.mskVence.Location = new System.Drawing.Point(106, 62);
            this.mskVence.Margin = new System.Windows.Forms.Padding(2);
            this.mskVence.Mask = "00/00/0000";
            this.mskVence.Name = "mskVence";
            this.mskVence.Size = new System.Drawing.Size(68, 20);
            this.mskVence.TabIndex = 44;
            this.mskVence.ValidatingType = typeof(System.DateTime);
            // 
            // mskOtorgado
            // 
            this.mskOtorgado.Location = new System.Drawing.Point(106, 30);
            this.mskOtorgado.Margin = new System.Windows.Forms.Padding(2);
            this.mskOtorgado.Mask = "00/00/0000";
            this.mskOtorgado.Name = "mskOtorgado";
            this.mskOtorgado.Size = new System.Drawing.Size(68, 20);
            this.mskOtorgado.TabIndex = 43;
            this.mskOtorgado.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaV
            // 
            this.lblFechaV.AutoSize = true;
            this.lblFechaV.Location = new System.Drawing.Point(106, 106);
            this.lblFechaV.Name = "lblFechaV";
            this.lblFechaV.Size = new System.Drawing.Size(0, 13);
            this.lblFechaV.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vencimiento:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(77, 81);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 13);
            this.lblModelo.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Modelo:";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(77, 53);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(0, 13);
            this.lblDominio.TabIndex = 45;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(77, 28);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Unidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dominio:";
            // 
            // frm_ActualizarVtv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 429);
            this.Controls.Add(this.dgvVerificacionVtv);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_ActualizarVtv";
            this.Text = "frm_Actualizarregistro";
            this.Load += new System.EventHandler(this.frm_ActualizarVtv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificacionVtv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVerificacionVtv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.MaskedTextBox mskVence;
        private System.Windows.Forms.MaskedTextBox mskOtorgado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFechaV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}