namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    partial class frm_MenuCierrePlanilla
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
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
            this.pnlPanel1.Controls.Add(this.button3);
            this.pnlPanel1.Controls.Add(this.btnModificar);
            this.pnlPanel1.Controls.Add(this.btnAlta);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(800, 27);
            this.pnlPanel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(150, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.Location = new System.Drawing.Point(75, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 27);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlta.Location = new System.Drawing.Point(0, 0);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 27);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // frm_MenuCierrePlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Name = "frm_MenuCierrePlanilla";
            this.Text = "frm_MenuCierrePlanilla";
            this.Load += new System.EventHandler(this.frm_MenuCierrePlanilla_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
    }
}