namespace CV_Presentacion.Forms.Frm_Taller
{
    partial class frm_MenuCargarInsumos
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
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.btnModicifarInsumo = new System.Windows.Forms.Button();
            this.btnAltaInsumo = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario2
            // 
            this.pnlFormulario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario2.Location = new System.Drawing.Point(0, 27);
            this.pnlFormulario2.Name = "pnlFormulario2";
            this.pnlFormulario2.Size = new System.Drawing.Size(800, 423);
            this.pnlFormulario2.TabIndex = 3;
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnBuscarInsumo);
            this.pnlPanel1.Controls.Add(this.btnModicifarInsumo);
            this.pnlPanel1.Controls.Add(this.btnAltaInsumo);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(800, 27);
            this.pnlPanel1.TabIndex = 2;
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarInsumo.Location = new System.Drawing.Point(150, 0);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarInsumo.TabIndex = 2;
            this.btnBuscarInsumo.Text = "Buscar";
            this.btnBuscarInsumo.UseVisualStyleBackColor = true;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // btnModicifarInsumo
            // 
            this.btnModicifarInsumo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModicifarInsumo.Location = new System.Drawing.Point(75, 0);
            this.btnModicifarInsumo.Name = "btnModicifarInsumo";
            this.btnModicifarInsumo.Size = new System.Drawing.Size(75, 27);
            this.btnModicifarInsumo.TabIndex = 1;
            this.btnModicifarInsumo.Text = "Modificar";
            this.btnModicifarInsumo.UseVisualStyleBackColor = true;
            this.btnModicifarInsumo.Click += new System.EventHandler(this.btnModicifarInsumo_Click);
            // 
            // btnAltaInsumo
            // 
            this.btnAltaInsumo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaInsumo.Location = new System.Drawing.Point(0, 0);
            this.btnAltaInsumo.Name = "btnAltaInsumo";
            this.btnAltaInsumo.Size = new System.Drawing.Size(75, 27);
            this.btnAltaInsumo.TabIndex = 0;
            this.btnAltaInsumo.Text = "Alta";
            this.btnAltaInsumo.UseVisualStyleBackColor = true;
            this.btnAltaInsumo.Click += new System.EventHandler(this.btnAltaInsumo_Click);
            // 
            // frm_MenuCargarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Name = "frm_MenuCargarInsumos";
            this.Text = "frm_MenuCargarInsumos";
            this.Load += new System.EventHandler(this.frm_MenuCargarInsumos_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.Button btnModicifarInsumo;
        private System.Windows.Forms.Button btnAltaInsumo;
    }
}