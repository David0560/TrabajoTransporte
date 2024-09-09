namespace CV_Presentacion.Frm_Usuario
{
    partial class frm_Bloqueos
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
            this.btnNuevoPassword = new System.Windows.Forms.Button();
            this.btnGuardarBloqueos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoPassword
            // 
            this.btnNuevoPassword.Location = new System.Drawing.Point(391, 418);
            this.btnNuevoPassword.Name = "btnNuevoPassword";
            this.btnNuevoPassword.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPassword.TabIndex = 7;
            this.btnNuevoPassword.Text = "Password";
            this.btnNuevoPassword.UseVisualStyleBackColor = true;
            this.btnNuevoPassword.Click += new System.EventHandler(this.btnNuevoPassword_Click);
            // 
            // btnGuardarBloqueos
            // 
            this.btnGuardarBloqueos.Location = new System.Drawing.Point(472, 418);
            this.btnGuardarBloqueos.Name = "btnGuardarBloqueos";
            this.btnGuardarBloqueos.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarBloqueos.TabIndex = 6;
            this.btnGuardarBloqueos.Text = "&Actualizar";
            this.btnGuardarBloqueos.UseVisualStyleBackColor = true;
            this.btnGuardarBloqueos.Click += new System.EventHandler(this.btnGuardarBloqueos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bloqueos de usuarios";
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(24, 81);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(523, 323);
            this.dgvListaUsuarios.TabIndex = 4;
            // 
            // frm_Bloqueos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 476);
            this.Controls.Add(this.btnNuevoPassword);
            this.Controls.Add(this.btnGuardarBloqueos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Name = "frm_Bloqueos";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_Bloqueos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPassword;
        private System.Windows.Forms.Button btnGuardarBloqueos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
    }
}