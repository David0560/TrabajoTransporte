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
            this.grbPregunta.Location = new System.Drawing.Point(34, 122);
            this.grbPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPregunta.Name = "grbPregunta";
            this.grbPregunta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPregunta.Size = new System.Drawing.Size(777, 138);
            this.grbPregunta.TabIndex = 8;
            this.grbPregunta.TabStop = false;
            this.grbPregunta.Text = "Agregar";
            // 
            // btnEliminarPregunta
            // 
            this.btnEliminarPregunta.Location = new System.Drawing.Point(518, 85);
            this.btnEliminarPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPregunta.Name = "btnEliminarPregunta";
            this.btnEliminarPregunta.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarPregunta.TabIndex = 4;
            this.btnEliminarPregunta.Text = "&Eliminar";
            this.btnEliminarPregunta.UseVisualStyleBackColor = true;
            this.btnEliminarPregunta.Click += new System.EventHandler(this.btnEliminarPregunta_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nueva pregunta:";
            // 
            // btnGuardarPregunta
            // 
            this.btnGuardarPregunta.Location = new System.Drawing.Point(639, 85);
            this.btnGuardarPregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPregunta.Name = "btnGuardarPregunta";
            this.btnGuardarPregunta.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarPregunta.TabIndex = 1;
            this.btnGuardarPregunta.Text = "&Guardar";
            this.btnGuardarPregunta.UseVisualStyleBackColor = true;
            this.btnGuardarPregunta.Click += new System.EventHandler(this.btnGuardarPregunta_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(172, 35);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(577, 26);
            this.textBox7.TabIndex = 3;
            // 
            // lblTituloPregunta
            // 
            this.lblTituloPregunta.AutoSize = true;
            this.lblTituloPregunta.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPregunta.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloPregunta.Location = new System.Drawing.Point(186, 62);
            this.lblTituloPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloPregunta.Name = "lblTituloPregunta";
            this.lblTituloPregunta.Size = new System.Drawing.Size(434, 32);
            this.lblTituloPregunta.TabIndex = 7;
            this.lblTituloPregunta.Text = "Cargar nueva pregunta de seguridad";
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Location = new System.Drawing.Point(34, 282);
            this.dgvPreguntas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.RowHeadersWidth = 62;
            this.dgvPreguntas.Size = new System.Drawing.Size(788, 391);
            this.dgvPreguntas.TabIndex = 6;
            // 
            // frm_PregunrtasDeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 732);
            this.Controls.Add(this.grbPregunta);
            this.Controls.Add(this.lblTituloPregunta);
            this.Controls.Add(this.dgvPreguntas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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