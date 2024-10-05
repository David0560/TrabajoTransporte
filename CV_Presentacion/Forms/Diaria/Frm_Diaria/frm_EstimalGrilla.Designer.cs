namespace CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla
{
    partial class frm_EstimalGrilla
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
            this.btnGuardarGrilla = new System.Windows.Forms.Button();
            this.btnCargarGrilla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRamales = new System.Windows.Forms.ComboBox();
            this.dgvGrillaDelDia = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.Location = new System.Drawing.Point(532, 23);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarGrilla.TabIndex = 89;
            this.btnGuardarGrilla.Text = "Guardar";
            this.btnGuardarGrilla.UseVisualStyleBackColor = true;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnCargarGrilla
            // 
            this.btnCargarGrilla.Location = new System.Drawing.Point(449, 23);
            this.btnCargarGrilla.Name = "btnCargarGrilla";
            this.btnCargarGrilla.Size = new System.Drawing.Size(75, 23);
            this.btnCargarGrilla.TabIndex = 86;
            this.btnCargarGrilla.Text = "Cargar";
            this.btnCargarGrilla.UseVisualStyleBackColor = true;
            this.btnCargarGrilla.Click += new System.EventHandler(this.btnCargarGrilla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ramal:";
            // 
            // cboRamales
            // 
            this.cboRamales.FormattingEnabled = true;
            this.cboRamales.Location = new System.Drawing.Point(328, 23);
            this.cboRamales.Name = "cboRamales";
            this.cboRamales.Size = new System.Drawing.Size(85, 21);
            this.cboRamales.TabIndex = 84;
            // 
            // dgvGrillaDelDia
            // 
            this.dgvGrillaDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaDelDia.Location = new System.Drawing.Point(18, 62);
            this.dgvGrillaDelDia.Name = "dgvGrillaDelDia";
            this.dgvGrillaDelDia.Size = new System.Drawing.Size(598, 390);
            this.dgvGrillaDelDia.TabIndex = 83;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 81;
            this.lblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // frm_EstimalGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGuardarGrilla);
            this.Controls.Add(this.btnCargarGrilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRamales);
            this.Controls.Add(this.dgvGrillaDelDia);
            this.Controls.Add(this.lblFecha);
            this.Name = "frm_EstimalGrilla";
            this.Text = "frm_EstimalGrilla";
            this.Load += new System.EventHandler(this.frm_EstimalGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDelDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarGrilla;
        private System.Windows.Forms.Button btnCargarGrilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRamales;
        private System.Windows.Forms.DataGridView dgvGrillaDelDia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}