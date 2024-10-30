namespace CV_Presentacion.Forms.Frm_Taller
{
    partial class frm_MenuMecanica
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
            this.btnBuscarMecanica = new System.Windows.Forms.Button();
            this.btnCierreMecanica = new System.Windows.Forms.Button();
            this.btnAltaMecanica = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario2
            // 
            this.pnlFormulario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario2.Location = new System.Drawing.Point(0, 42);
            this.pnlFormulario2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFormulario2.Name = "pnlFormulario2";
            this.pnlFormulario2.Size = new System.Drawing.Size(1200, 650);
            this.pnlFormulario2.TabIndex = 3;
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnBuscarMecanica);
            this.pnlPanel1.Controls.Add(this.btnCierreMecanica);
            this.pnlPanel1.Controls.Add(this.btnAltaMecanica);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(1200, 42);
            this.pnlPanel1.TabIndex = 2;
            // 
            // btnBuscarMecanica
            // 
            this.btnBuscarMecanica.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarMecanica.Location = new System.Drawing.Point(224, 0);
            this.btnBuscarMecanica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarMecanica.Name = "btnBuscarMecanica";
            this.btnBuscarMecanica.Size = new System.Drawing.Size(112, 42);
            this.btnBuscarMecanica.TabIndex = 2;
            this.btnBuscarMecanica.Text = "Buscar";
            this.btnBuscarMecanica.UseVisualStyleBackColor = true;
            this.btnBuscarMecanica.Click += new System.EventHandler(this.btnBuscarMecanica_Click);
            // 
            // btnCierreMecanica
            // 
            this.btnCierreMecanica.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCierreMecanica.Location = new System.Drawing.Point(112, 0);
            this.btnCierreMecanica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCierreMecanica.Name = "btnCierreMecanica";
            this.btnCierreMecanica.Size = new System.Drawing.Size(112, 42);
            this.btnCierreMecanica.TabIndex = 1;
            this.btnCierreMecanica.Text = "Cierre";
            this.btnCierreMecanica.UseVisualStyleBackColor = true;
            this.btnCierreMecanica.Click += new System.EventHandler(this.btnModificarMecanica_Click);
            // 
            // btnAltaMecanica
            // 
            this.btnAltaMecanica.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaMecanica.Location = new System.Drawing.Point(0, 0);
            this.btnAltaMecanica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaMecanica.Name = "btnAltaMecanica";
            this.btnAltaMecanica.Size = new System.Drawing.Size(112, 42);
            this.btnAltaMecanica.TabIndex = 0;
            this.btnAltaMecanica.Text = "Alta";
            this.btnAltaMecanica.UseVisualStyleBackColor = true;
            this.btnAltaMecanica.Click += new System.EventHandler(this.btnAltaMecanica_Click);
            // 
            // frm_MenuMecanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_MenuMecanica";
            this.Text = "frm_MenuMecanica";
            this.Load += new System.EventHandler(this.frm_MenuMecanica_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button btnBuscarMecanica;
        private System.Windows.Forms.Button btnCierreMecanica;
        private System.Windows.Forms.Button btnAltaMecanica;
    }
}