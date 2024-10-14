using System;
using System.Windows.Forms;
using CapaServicios.Entidades.Taller;
using CL_Negocios.Taller;

namespace CV_Presentacion.Forms.Taller.Frm_Insumos
{
    public partial class frm_Insumos : Form
    {
        public frm_Insumos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Valido que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNvoArticulo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creo el objeto Articulo
            Articulo nuevoArticulo = new Articulo
            {
                Nombre = txtNvoArticulo.Text,
                Descripcion = txtDescripcion.Text
            };

            // Creo la instancia de la clase lógica
            CL_Articulo clArticulo = new CL_Articulo();

            try
            {
                // Llamada al método para guardar el nuevo artículo
                clArticulo.GuardarNuevoArticulo(nuevoArticulo);
                MessageBox.Show("Artículo guardado con éxito.");

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNvoArticulo.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
