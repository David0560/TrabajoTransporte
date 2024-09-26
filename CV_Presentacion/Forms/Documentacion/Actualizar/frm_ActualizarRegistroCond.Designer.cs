namespace CV_Presentacion.Forms.Documentacion
{
    partial class frm_ActualizarRegistroCond
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
            this.dgvRegistroCond = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbActualizar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskOtorgado = new System.Windows.Forms.MaskedTextBox();
            this.mskVence = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCond)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistroCond
            // 
            this.dgvRegistroCond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCond.Location = new System.Drawing.Point(18, 17);
            this.dgvRegistroCond.Name = "dgvRegistroCond";
            this.dgvRegistroCond.Size = new System.Drawing.Size(508, 213);
            this.dgvRegistroCond.TabIndex = 5;
            this.dgvRegistroCond.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCond_CellDoubleClick);
            this.dgvRegistroCond.SelectionChanged += new System.EventHandler(this.dgvRegistroCond_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.grbActualizar);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblNumeroDoc);
            this.groupBox1.Controls.Add(this.lblApe);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Location = new System.Drawing.Point(20, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Conducir";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(93, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Vencimiento:";
            // 
            // grbActualizar
            // 
            this.grbActualizar.Controls.Add(this.label3);
            this.grbActualizar.Controls.Add(this.mskOtorgado);
            this.grbActualizar.Controls.Add(this.mskVence);
            this.grbActualizar.Controls.Add(this.btnGuardar);
            this.grbActualizar.Controls.Add(this.label2);
            this.grbActualizar.Location = new System.Drawing.Point(290, 16);
            this.grbActualizar.Name = "grbActualizar";
            this.grbActualizar.Size = new System.Drawing.Size(201, 141);
            this.grbActualizar.TabIndex = 47;
            this.grbActualizar.TabStop = false;
            this.grbActualizar.Text = "Actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Otorgado:";
            // 
            // mskOtorgado
            // 
            this.mskOtorgado.Location = new System.Drawing.Point(95, 31);
            this.mskOtorgado.Margin = new System.Windows.Forms.Padding(2);
            this.mskOtorgado.Mask = "00/00/0000";
            this.mskOtorgado.Name = "mskOtorgado";
            this.mskOtorgado.Size = new System.Drawing.Size(68, 20);
            this.mskOtorgado.TabIndex = 43;
            this.mskOtorgado.ValidatingType = typeof(System.DateTime);
            // 
            // mskVence
            // 
            this.mskVence.Location = new System.Drawing.Point(95, 61);
            this.mskVence.Margin = new System.Windows.Forms.Padding(2);
            this.mskVence.Mask = "00/00/0000";
            this.mskVence.Name = "mskVence";
            this.mskVence.Size = new System.Drawing.Size(68, 20);
            this.mskVence.TabIndex = 44;
            this.mskVence.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(111, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Vencimiento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(77, 82);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 13);
            this.lblNumero.TabIndex = 46;
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(18, 82);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroDoc.TabIndex = 35;
            this.lblNumeroDoc.Text = "Numero:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(77, 55);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(0, 13);
            this.lblApe.TabIndex = 45;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(77, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 13);
            this.lblNom.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // frm_ActualizarRegistroCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 429);
            this.Controls.Add(this.dgvRegistroCond);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ActualizarRegistroCond";
            this.Text = "frm_ActualizarVtv";
            this.Load += new System.EventHandler(this.frm_ActualizarRegistroCond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbActualizar.ResumeLayout(false);
            this.grbActualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroCond;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.MaskedTextBox mskVence;
        private System.Windows.Forms.MaskedTextBox mskOtorgado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox grbActualizar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
    }
}