namespace CV_Presentacion.Forms.Registro.Frm_Empleados
{
    partial class frm_MenuEmpleados
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
            this.pnlFormulario02 = new System.Windows.Forms.Panel();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnAltaËmpleado = new System.Windows.Forms.Button();
            this.pnlBoton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario02
            // 
            this.pnlFormulario02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario02.Location = new System.Drawing.Point(0, 27);
            this.pnlFormulario02.Name = "pnlFormulario02";
            this.pnlFormulario02.Size = new System.Drawing.Size(584, 434);
            this.pnlFormulario02.TabIndex = 3;
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnBuscarEmpleado);
            this.pnlBoton.Controls.Add(this.btnModificarEmpleado);
            this.pnlBoton.Controls.Add(this.btnAltaËmpleado);
            this.pnlBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBoton.Location = new System.Drawing.Point(0, 0);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(584, 27);
            this.pnlBoton.TabIndex = 2;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(150, 0);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarEmpleado.TabIndex = 2;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(75, 0);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(75, 27);
            this.btnModificarEmpleado.TabIndex = 1;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnAltaËmpleado
            // 
            this.btnAltaËmpleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaËmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnAltaËmpleado.Name = "btnAltaËmpleado";
            this.btnAltaËmpleado.Size = new System.Drawing.Size(75, 27);
            this.btnAltaËmpleado.TabIndex = 0;
            this.btnAltaËmpleado.Text = "Alta";
            this.btnAltaËmpleado.UseVisualStyleBackColor = true;
            this.btnAltaËmpleado.Click += new System.EventHandler(this.btnAltaËmpleado_Click);
            // 
            // frm_MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pnlFormulario02);
            this.Controls.Add(this.pnlBoton);
            this.Name = "frm_MenuEmpleados";
            this.Text = "frm_MenuEmpleado";
            this.Load += new System.EventHandler(this.frm_MenuEmpleados_Load);
            this.pnlBoton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario02;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnAltaËmpleado;
    }
}