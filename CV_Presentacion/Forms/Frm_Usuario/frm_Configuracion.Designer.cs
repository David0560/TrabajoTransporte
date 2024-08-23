namespace CV_Presentacion.Frm_Usuario
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(341, 528);
            this.btnGuardarConfiguracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarConfiguracion.TabIndex = 37;
            this.btnGuardarConfiguracion.Text = "&Guardar";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // ckbPregunta
            // 
            this.ckbPregunta.AutoSize = true;
            this.ckbPregunta.Location = new System.Drawing.Point(55, 407);
            this.ckbPregunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPregunta.Name = "ckbPregunta";
            this.ckbPregunta.Size = new System.Drawing.Size(180, 20);
            this.ckbPregunta.TabIndex = 36;
            this.ckbPregunta.Text = "Cargar nuevas preguntas";
            this.ckbPregunta.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 443);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "dias para el bloqueo";
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(311, 438);
            this.txtCantidadDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(45, 22);
            this.txtCantidadDias.TabIndex = 34;
            // 
            // txtCantIntentos
            // 
            this.txtCantIntentos.Location = new System.Drawing.Point(56, 164);
            this.txtCantIntentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantIntentos.Name = "txtCantIntentos";
            this.txtCantIntentos.Size = new System.Drawing.Size(47, 22);
            this.txtCantIntentos.TabIndex = 33;
            // 
            // txtMaxCaracter
            // 
            this.txtMaxCaracter.Location = new System.Drawing.Point(56, 127);
            this.txtMaxCaracter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxCaracter.Name = "txtMaxCaracter";
            this.txtMaxCaracter.Size = new System.Drawing.Size(47, 22);
            this.txtMaxCaracter.TabIndex = 31;
            // 
            // txtMinCaracter
            // 
            this.txtMinCaracter.Location = new System.Drawing.Point(56, 92);
            this.txtMinCaracter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinCaracter.Name = "txtMinCaracter";
            this.txtMinCaracter.Size = new System.Drawing.Size(47, 22);
            this.txtMinCaracter.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Cantidad de intentos erróneos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Valor máximo de caracteres";
            // 
            // chkPreguntaSeguridad
            // 
            this.chkPreguntaSeguridad.AutoSize = true;
            this.chkPreguntaSeguridad.Location = new System.Drawing.Point(56, 379);
            this.chkPreguntaSeguridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPreguntaSeguridad.Name = "chkPreguntaSeguridad";
            this.chkPreguntaSeguridad.Size = new System.Drawing.Size(225, 20);
            this.chkPreguntaSeguridad.TabIndex = 29;
            this.chkPreguntaSeguridad.Text = "Realizar preguntas de seguridad";
            this.chkPreguntaSeguridad.UseVisualStyleBackColor = true;
            // 
            // chkBolqueoAuto
            // 
            this.chkBolqueoAuto.AutoSize = true;
            this.chkBolqueoAuto.Location = new System.Drawing.Point(55, 442);
            this.chkBolqueoAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBolqueoAuto.Name = "chkBolqueoAuto";
            this.chkBolqueoAuto.Size = new System.Drawing.Size(215, 20);
            this.chkBolqueoAuto.TabIndex = 28;
            this.chkBolqueoAuto.Text = "Bloqueo de usuario automático";
            this.chkBolqueoAuto.UseVisualStyleBackColor = true;
            // 
            // chkDatosPersonales
            // 
            this.chkDatosPersonales.AutoSize = true;
            this.chkDatosPersonales.Location = new System.Drawing.Point(56, 351);
            this.chkDatosPersonales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDatosPersonales.Name = "chkDatosPersonales";
            this.chkDatosPersonales.Size = new System.Drawing.Size(261, 20);
            this.chkDatosPersonales.TabIndex = 27;
            this.chkDatosPersonales.Text = "No incluir datos personales del usuario";
            this.chkDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // lblMinCaracteres
            // 
            this.lblMinCaracteres.AutoSize = true;
            this.lblMinCaracteres.Location = new System.Drawing.Point(112, 101);
            this.lblMinCaracteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinCaracteres.Name = "lblMinCaracteres";
            this.lblMinCaracteres.Size = new System.Drawing.Size(171, 16);
            this.lblMinCaracteres.TabIndex = 25;
            this.lblMinCaracteres.Text = "Valor mínimo de caracteres";
            // 
            // chkPassAnterior
            // 
            this.chkPassAnterior.AutoSize = true;
            this.chkPassAnterior.Location = new System.Drawing.Point(56, 322);
            this.chkPassAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPassAnterior.Name = "chkPassAnterior";
            this.chkPassAnterior.Size = new System.Drawing.Size(191, 20);
            this.chkPassAnterior.TabIndex = 24;
            this.chkPassAnterior.Text = "Repetir contraseña anterior";
            this.chkPassAnterior.UseVisualStyleBackColor = true;
            // 
            // chkDosPasos
            // 
            this.chkDosPasos.AutoSize = true;
            this.chkDosPasos.Location = new System.Drawing.Point(56, 294);
            this.chkDosPasos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDosPasos.Name = "chkDosPasos";
            this.chkDosPasos.Size = new System.Drawing.Size(257, 20);
            this.chkDosPasos.TabIndex = 23;
            this.chkDosPasos.Text = "Realizará autenticacion en dos pasos.";
            this.chkDosPasos.UseVisualStyleBackColor = true;
            // 
            // chkCaracterEspecial
            // 
            this.chkCaracterEspecial.AutoSize = true;
            this.chkCaracterEspecial.Location = new System.Drawing.Point(56, 266);
            this.chkCaracterEspecial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCaracterEspecial.Name = "chkCaracterEspecial";
            this.chkCaracterEspecial.Size = new System.Drawing.Size(363, 20);
            this.chkCaracterEspecial.TabIndex = 22;
            this.chkCaracterEspecial.Text = "Requiere la precencia de al menos un caracter especial";
            this.chkCaracterEspecial.UseVisualStyleBackColor = true;
            // 
            // chkNumLetras
            // 
            this.chkNumLetras.AutoSize = true;
            this.chkNumLetras.Location = new System.Drawing.Point(56, 238);
            this.chkNumLetras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNumLetras.Name = "chkNumLetras";
            this.chkNumLetras.Size = new System.Drawing.Size(301, 20);
            this.chkNumLetras.TabIndex = 21;
            this.chkNumLetras.Text = "Requiere convinaciones con numeros y letras";
            this.chkNumLetras.UseVisualStyleBackColor = true;
            // 
            // chkMayusMinus
            // 
            this.chkMayusMinus.AutoSize = true;
            this.chkMayusMinus.Location = new System.Drawing.Point(56, 209);
            this.chkMayusMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMayusMinus.Name = "chkMayusMinus";
            this.chkMayusMinus.Size = new System.Drawing.Size(334, 20);
            this.chkMayusMinus.TabIndex = 20;
            this.chkMayusMinus.Text = "Requiere convinacion de mayusculas y minusculas";
            this.chkMayusMinus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(623, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "Control de requisitos para la creacion de password";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 586);
            this.Controls.Add(this.btnGuardarConfiguracion);
            this.Controls.Add(this.ckbPregunta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.txtCantIntentos);
            this.Controls.Add(this.txtMaxCaracter);
            this.Controls.Add(this.txtMinCaracter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkPreguntaSeguridad);
            this.Controls.Add(this.chkBolqueoAuto);
            this.Controls.Add(this.chkDatosPersonales);
            this.Controls.Add(this.lblMinCaracteres);
            this.Controls.Add(this.chkPassAnterior);
            this.Controls.Add(this.chkDosPasos);
            this.Controls.Add(this.chkCaracterEspecial);
            this.Controls.Add(this.chkNumLetras);
            this.Controls.Add(this.chkMayusMinus);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}