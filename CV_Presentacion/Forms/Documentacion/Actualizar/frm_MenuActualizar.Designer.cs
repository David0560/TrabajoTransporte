namespace CV_Presentacion.Forms.Documentacion
{
    partial class frm_MenuActualizar
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
            this.btnRegistroConducir = new System.Windows.Forms.Button();
            this.btnVtv = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario2
            // 
            this.pnlFormulario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario2.Location = new System.Drawing.Point(0, 27);
            this.pnlFormulario2.Name = "pnlFormulario2";
            this.pnlFormulario2.Size = new System.Drawing.Size(636, 437);
            this.pnlFormulario2.TabIndex = 5;
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnRegistroConducir);
            this.pnlPanel1.Controls.Add(this.btnVtv);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(636, 27);
            this.pnlPanel1.TabIndex = 4;
            // 
            // btnRegistroConducir
            // 
            this.btnRegistroConducir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistroConducir.Location = new System.Drawing.Point(75, 0);
            this.btnRegistroConducir.Name = "btnRegistroConducir";
            this.btnRegistroConducir.Size = new System.Drawing.Size(75, 27);
            this.btnRegistroConducir.TabIndex = 1;
            this.btnRegistroConducir.Text = "Registro";
            this.btnRegistroConducir.UseVisualStyleBackColor = true;
            this.btnRegistroConducir.Click += new System.EventHandler(this.btnRegistroConducir_Click);
            // 
            // btnVtv
            // 
            this.btnVtv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVtv.Location = new System.Drawing.Point(0, 0);
            this.btnVtv.Name = "btnVtv";
            this.btnVtv.Size = new System.Drawing.Size(75, 27);
            this.btnVtv.TabIndex = 0;
            this.btnVtv.Text = "VTV";
            this.btnVtv.UseVisualStyleBackColor = true;
            this.btnVtv.Click += new System.EventHandler(this.btnVtv_Click);
            // 
            // frm_MenuActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 464);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Name = "frm_MenuActualizar";
            this.Text = "frm_MenuActualizar";
            this.Load += new System.EventHandler(this.frm_MenuActualizar_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button btnRegistroConducir;
        private System.Windows.Forms.Button btnVtv;
    }
}