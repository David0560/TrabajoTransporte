namespace CV_Presentacion.Forms.Taller.Frm_Insumos
{
    partial class frm_CargarInsumos
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtListaArticulos = new System.Windows.Forms.DataGridView();
            this.btnElimiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbArticulo = new System.Windows.Forms.ListBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.mskFechaVenc = new System.Windows.Forms.MaskedTextBox();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbProveedor = new System.Windows.Forms.ListBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaArticulos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(143, 319);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(370, 319);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 319);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtListaArticulos
            // 
            this.dtListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripción,
            this.Cantidad,
            this.FechaVenc});
            this.dtListaArticulos.Location = new System.Drawing.Point(28, 365);
            this.dtListaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtListaArticulos.Name = "dtListaArticulos";
            this.dtListaArticulos.RowHeadersWidth = 51;
            this.dtListaArticulos.Size = new System.Drawing.Size(892, 331);
            this.dtListaArticulos.TabIndex = 33;
            // 
            // btnElimiar
            // 
            this.btnElimiar.Location = new System.Drawing.Point(256, 319);
            this.btnElimiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimiar.Name = "btnElimiar";
            this.btnElimiar.Size = new System.Drawing.Size(112, 38);
            this.btnElimiar.TabIndex = 7;
            this.btnElimiar.Text = "Elimiar";
            this.btnElimiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbArticulo);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.mskFechaVenc);
            this.groupBox2.Controls.Add(this.btnArticulos);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.lblFechaVenc);
            this.groupBox2.Location = new System.Drawing.Point(28, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(454, 198);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carga";
            // 
            // lsbArticulo
            // 
            this.lsbArticulo.FormattingEnabled = true;
            this.lsbArticulo.ItemHeight = 20;
            this.lsbArticulo.Location = new System.Drawing.Point(115, 65);
            this.lsbArticulo.Name = "lsbArticulo";
            this.lsbArticulo.Size = new System.Drawing.Size(198, 84);
            this.lsbArticulo.TabIndex = 38;
            this.lsbArticulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbArticulo_MouseClick);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(115, 38);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(198, 26);
            this.txtArticulo.TabIndex = 37;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            // 
            // mskFechaVenc
            // 
            this.mskFechaVenc.Location = new System.Drawing.Point(207, 139);
            this.mskFechaVenc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskFechaVenc.Mask = "00/00/0000";
            this.mskFechaVenc.Name = "mskFechaVenc";
            this.mskFechaVenc.Size = new System.Drawing.Size(100, 26);
            this.mskFechaVenc.TabIndex = 4;
            this.mskFechaVenc.ValidatingType = typeof(System.DateTime);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(342, 38);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(37, 32);
            this.btnArticulos.TabIndex = 36;
            this.btnArticulos.Text = "+";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(129, 89);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(91, 26);
            this.txtCantidad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Articulo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(45, 95);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFechaVenc
            // 
            this.lblFechaVenc.AutoSize = true;
            this.lblFechaVenc.Location = new System.Drawing.Point(45, 145);
            this.lblFechaVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenc.Name = "lblFechaVenc";
            this.lblFechaVenc.Size = new System.Drawing.Size(150, 20);
            this.lblFechaVenc.TabIndex = 7;
            this.lblFechaVenc.Text = "Fecha Vencimiento:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(143, 51);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(320, 26);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor:";
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.lblCiudad);
            this.gbInformacion.Controls.Add(this.lblEmpresa);
            this.gbInformacion.Controls.Add(this.lblContacto);
            this.gbInformacion.Controls.Add(this.lblTelefono);
            this.gbInformacion.Controls.Add(this.lblEmail);
            this.gbInformacion.Controls.Add(this.label9);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Controls.Add(this.label2);
            this.gbInformacion.Controls.Add(this.label5);
            this.gbInformacion.Controls.Add(this.label6);
            this.gbInformacion.Location = new System.Drawing.Point(512, 38);
            this.gbInformacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformacion.Size = new System.Drawing.Size(408, 318);
            this.gbInformacion.TabIndex = 34;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(188, 241);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(65, 20);
            this.lblCiudad.TabIndex = 17;
            this.lblCiudad.Text = "Nombre";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(188, 46);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(65, 20);
            this.lblEmpresa.TabIndex = 13;
            this.lblEmpresa.Text = "Nombre";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(188, 95);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(68, 20);
            this.lblContacto.TabIndex = 14;
            this.lblContacto.Text = "Persona";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(188, 145);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 20);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Numero";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(188, 194);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Correo@Electronico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ciudad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contacto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo Electronico:";
            // 
            // lsbProveedor
            // 
            this.lsbProveedor.FormattingEnabled = true;
            this.lsbProveedor.ItemHeight = 20;
            this.lsbProveedor.Location = new System.Drawing.Point(143, 78);
            this.lsbProveedor.Name = "lsbProveedor";
            this.lsbProveedor.Size = new System.Drawing.Size(320, 84);
            this.lsbProveedor.TabIndex = 35;
            this.lsbProveedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbProveedor_MouseClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 8;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "Fecha Vencimiento";
            this.FechaVenc.MinimumWidth = 8;
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            this.FechaVenc.Width = 150;
            // 
            // frm_CargarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 714);
            this.Controls.Add(this.lsbProveedor);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtListaArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnElimiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtProveedor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_CargarInsumos";
            this.Text = "frm_CargarInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaArticulos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtListaArticulos;
        private System.Windows.Forms.Button btnElimiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.MaskedTextBox mskFechaVenc;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsbProveedor;
        private System.Windows.Forms.ListBox lsbArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
    }
}