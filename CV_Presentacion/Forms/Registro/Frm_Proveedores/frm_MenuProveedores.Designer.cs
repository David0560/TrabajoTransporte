namespace CV_Presentacion.Forms.Registro.Frm_Proveedores
{
    partial class frm_MenuProveedores
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
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnAltaProveedor = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario2
            // 
            this.pnlFormulario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario2.Location = new System.Drawing.Point(0, 27);
            this.pnlFormulario2.Name = "pnlFormulario2";
            this.pnlFormulario2.Size = new System.Drawing.Size(584, 423);
            this.pnlFormulario2.TabIndex = 3;
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnBuscarProveedor);
            this.pnlPanel1.Controls.Add(this.btnModificarProveedor);
            this.pnlPanel1.Controls.Add(this.btnAltaProveedor);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(584, 27);
            this.pnlPanel1.TabIndex = 2;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(150, 0);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificarProveedor.Location = new System.Drawing.Point(75, 0);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 27);
            this.btnModificarProveedor.TabIndex = 1;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaProveedor.Location = new System.Drawing.Point(0, 0);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(75, 27);
            this.btnAltaProveedor.TabIndex = 0;
            this.btnAltaProveedor.Text = "Alta";
            this.btnAltaProveedor.UseVisualStyleBackColor = true;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnAltaProveedor_Click);
            // 
            // frm_MenuProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.pnlFormulario2);
            this.Controls.Add(this.pnlPanel1);
            this.Name = "frm_MenuProveedores";
            this.Text = "frm_MenuProveedores";
            this.Load += new System.EventHandler(this.frm_MenuProveedores_Load);
            this.pnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario2;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnAltaProveedor;
    }
}