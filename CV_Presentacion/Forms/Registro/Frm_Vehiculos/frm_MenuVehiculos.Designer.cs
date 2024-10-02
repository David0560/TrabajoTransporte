namespace CV_Presentacion.Forms.Registro.Frm_Vehiculos
{
    partial class frm_MenuVehiculos
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
            this.pnlFormulario2 = new System.Windows.Forms.Panel();
            this.pnlPanel1 = new System.Windows.Forms.Panel();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.btnAltaVehiculo = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario2
            // 
            this.pnlFormulario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario2.Location = new System.Drawing.Point(0, 27);
            this.pnlFormulario2.Name = "pnlFormulario2";
            this.pnlFormulario2.Size = new System.Drawing.Size(636, 437);
            this.pnlFormulario2.TabIndex = 3;
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnBuscarVehiculo);
            this.pnlPanel1.Controls.Add(this.btnModificarVehiculo);
            this.pnlPanel1.Controls.Add(this.btnAltaVehiculo);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(636, 27);
            this.pnlPanel1.TabIndex = 2;
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(150, 0);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarVehiculo.TabIndex = 2;
            this.btnBuscarVehiculo.Text = "Buscar";
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificarVehiculo.Location = new System.Drawing.Point(75, 0);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(75, 27);
            this.btnModificarVehiculo.TabIndex = 1;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // btnAltaVehiculo
            // 
            this.btnAltaVehiculo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaVehiculo.Location = new System.Drawing.Point(0, 0);
            this.btnAltaVehiculo.Name = "btnAltaVehiculo";
            this.btnAltaVehiculo.Size = new System.Drawing.Size(75, 27);
            this.btnAltaVehiculo.TabIndex = 0;
            this.btnAltaVehiculo.Text = "Alta";
            this.btnAltaVehiculo.UseVisualStyleBackColor = true;
            this.btnAltaVehiculo.Click += new System.EventHandler(this.btnAltaVehiculo_Click);
            // 
            // frm_MenuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Name = "frm_MenuVehiculos";
            this.Text = "frm_MenuVehiculos";
            this.Load += new System.EventHandler(this.frm_MenuVehiculos_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.Button btnAltaVehiculo;
    }
}