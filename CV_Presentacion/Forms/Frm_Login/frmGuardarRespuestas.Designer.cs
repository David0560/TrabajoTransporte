namespace CV_Presentacion
{
    partial class frmGuardarRespuestas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.lblPregunta3 = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(160, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(316, 218);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta3.TabIndex = 15;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(316, 162);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta2.TabIndex = 14;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(316, 107);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta1.TabIndex = 13;
            // 
            // lblPregunta3
            // 
            this.lblPregunta3.AutoSize = true;
            this.lblPregunta3.Location = new System.Drawing.Point(68, 220);
            this.lblPregunta3.Name = "lblPregunta3";
            this.lblPregunta3.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta3.TabIndex = 12;
            this.lblPregunta3.Text = "label4";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Location = new System.Drawing.Point(67, 168);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta2.TabIndex = 11;
            this.lblPregunta2.Text = "label3";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(68, 107);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta1.TabIndex = 10;
            this.lblPregunta1.Text = "label2";
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguridad.Location = new System.Drawing.Point(131, 29);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(214, 24);
            this.lblSeguridad.TabIndex = 9;
            this.lblSeguridad.Text = "Preguntas de Seguridad";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(68, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(192, 70);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(42, 13);
            this.lblNombreUsuario.TabIndex = 19;
            this.lblNombreUsuario.Text = "nombre";
            // 
            // frmGuardarRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 340);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.lblPregunta3);
            this.Controls.Add(this.lblPregunta2);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.lblSeguridad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGuardarRespuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrGuardarRespuestas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.Label lblPregunta3;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
    }
}