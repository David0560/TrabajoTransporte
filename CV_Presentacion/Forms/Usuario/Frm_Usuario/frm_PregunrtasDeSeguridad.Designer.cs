namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_PregunrtasDeSeguridad
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
            this.grbPregunta = new System.Windows.Forms.GroupBox();
            this.btnEliminarPregunta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardarPregunta = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblTituloPregunta = new System.Windows.Forms.Label();
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.grbPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPregunta
            // 
            this.grbPregunta.Controls.Add(this.btnEliminarPregunta);
            this.grbPregunta.Controls.Add(this.label13);
            this.grbPregunta.Controls.Add(this.btnGuardarPregunta);
            this.grbPregunta.Controls.Add(this.textBox7);
            this.grbPregunta.Location = new System.Drawing.Point(23, 79);
            this.grbPregunta.Name = "grbPregunta";
            this.grbPregunta.Size = new System.Drawing.Size(518, 90);
            this.grbPregunta.TabIndex = 8;
            this.grbPregunta.TabStop = false;
            this.grbPregunta.Text = "Agregar";
            // 
            // btnEliminarPregunta
            // 
            this.btnEliminarPregunta.Location = new System.Drawing.Point(345, 55);
            this.btnEliminarPregunta.Name = "btnEliminarPregunta";
            this.btnEliminarPregunta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPregunta.TabIndex = 4;
            this.btnEliminarPregunta.Text = "&Eliminar";
            this.btnEliminarPregunta.UseVisualStyleBackColor = true;
            this.btnEliminarPregunta.Click += new System.EventHandler(this.btnEliminarPregunta_Click_1);
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
            this.btnGuardarPregunta.Location = new System.Drawing.Point(426, 55);
            this.btnGuardarPregunta.Name = "btnGuardarPregunta";
            this.btnGuardarPregunta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPregunta.TabIndex = 1;
            this.btnGuardarPregunta.Text = "&Guardar";
            this.btnGuardarPregunta.UseVisualStyleBackColor = true;
            this.btnGuardarPregunta.Click += new System.EventHandler(this.btnGuardarPregunta_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(115, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(386, 20);
            this.textBox7.TabIndex = 3;
            // 
            // lblTituloPregunta
            // 
            this.lblTituloPregunta.AutoSize = true;
            this.lblTituloPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPregunta.Location = new System.Drawing.Point(124, 40);
            this.lblTituloPregunta.Name = "lblTituloPregunta";
            this.lblTituloPregunta.Size = new System.Drawing.Size(319, 24);
            this.lblTituloPregunta.TabIndex = 7;
            this.lblTituloPregunta.Text = "Cargar nueva pregunta de seguridad";
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Location = new System.Drawing.Point(23, 183);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.Size = new System.Drawing.Size(525, 254);
            this.dgvPreguntas.TabIndex = 6;
            // 
            // frm_PregunrtasDeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.grbPregunta);
            this.Controls.Add(this.lblTituloPregunta);
            this.Controls.Add(this.dgvPreguntas);
            this.Name = "frm_PregunrtasDeSeguridad";
            this.Text = "Form5";
            this.grbPregunta.ResumeLayout(false);
            this.grbPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPregunta;
        private System.Windows.Forms.Button btnEliminarPregunta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardarPregunta;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblTituloPregunta;
        private System.Windows.Forms.DataGridView dgvPreguntas;
    }
}