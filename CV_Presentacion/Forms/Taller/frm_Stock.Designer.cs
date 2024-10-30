namespace CV_Presentacion.Forms.Frm_Taller
{
    partial class frm_Stock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tbxCombustibleSalida = new System.Windows.Forms.TextBox();
            this.txbKmSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbCheck = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbCheck.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(72, 27);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(201, 20);
            this.dtpFechas.TabIndex = 51;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 52;
            this.lblFecha.Text = "Fecha:";
            // 
            // tbxCombustibleSalida
            // 
            this.tbxCombustibleSalida.Location = new System.Drawing.Point(72, 90);
            this.tbxCombustibleSalida.Name = "tbxCombustibleSalida";
            this.tbxCombustibleSalida.Size = new System.Drawing.Size(151, 20);
            this.tbxCombustibleSalida.TabIndex = 74;
            // 
            // txbKmSalida
            // 
            this.txbKmSalida.Location = new System.Drawing.Point(72, 64);
            this.txbKmSalida.Name = "txbKmSalida";
            this.txbKmSalida.Size = new System.Drawing.Size(151, 20);
            this.txbKmSalida.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Articulo:";
            // 
            // grbCheck
            // 
            this.grbCheck.Controls.Add(this.groupBox1);
            this.grbCheck.Controls.Add(this.dtpFechas);
            this.grbCheck.Controls.Add(this.tbxCombustibleSalida);
            this.grbCheck.Controls.Add(this.lblFecha);
            this.grbCheck.Controls.Add(this.txbKmSalida);
            this.grbCheck.Controls.Add(this.label7);
            this.grbCheck.Controls.Add(this.label5);
            this.grbCheck.Location = new System.Drawing.Point(12, 25);
            this.grbCheck.Name = "grbCheck";
            this.grbCheck.Size = new System.Drawing.Size(472, 130);
            this.grbCheck.TabIndex = 97;
            this.grbCheck.TabStop = false;
            this.grbCheck.Text = "Seleccionar:";
            this.grbCheck.Enter += new System.EventHandler(this.grbCheck_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Igual 0";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Menor a 10";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(300, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 89);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filtrar";
            // 
            // frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.grbCheck);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Stock";
            this.Text = "frm_mecanica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbCheck.ResumeLayout(false);
            this.grbCheck.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox tbxCombustibleSalida;
        private System.Windows.Forms.TextBox txbKmSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbCheck;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}