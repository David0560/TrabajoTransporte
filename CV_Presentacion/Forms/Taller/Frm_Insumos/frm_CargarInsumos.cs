using CD_ConexionDatos.Taller;
using CL_Negocios;
using CL_Negocios.Entidades;
using CL_Negocios.Taller;
using CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla.Frm_Anexados;
using System;
using System.Data;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Taller.Frm_Insumos
{
    public partial class frm_CargarInsumos : Form
    {
        private CL_Proveedores clProveedores;
        private CL_Articulo clArticulo;

        // Variables para almacenar los IDs
        private int selectedProveedorId;
        private int selectedArticuloId;

        public frm_CargarInsumos()
        {
            InitializeComponent();
            clProveedores = new CL_Proveedores();
            clArticulo = new CL_Articulo();
            lsbProveedor.Visible = false;
            lsbArticulo.Visible = false;
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = txtProveedor.Text.Trim();

            if (!string.IsNullOrEmpty(textoBuscado))
            {
                DataTable proveedores = clProveedores.ObtenerProveedoresPorEmpresa(textoBuscado);
                lsbProveedor.Items.Clear();

                foreach (DataRow fila in proveedores.Rows)
                {
                    lsbProveedor.Items.Add(fila["Empresa"].ToString());
                }

                lsbProveedor.Visible = lsbProveedor.Items.Count > 0;
            }
            else
            {
                lsbProveedor.Items.Clear();
                lsbProveedor.Visible = false;
                LimpiarLabelsProveedor();
            }
        }

        private void lsbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsbProveedor.SelectedItem != null)
            {
                string proveedorSeleccionado = lsbProveedor.SelectedItem.ToString();
                txtProveedor.Text = proveedorSeleccionado;
                lsbProveedor.Visible = false;

                // Obtener detalles del proveedor
                DataTable detallesProveedor = clProveedores.ObtenerProveedoresPorEmpresa(txtProveedor.Text);

                if (detallesProveedor.Rows.Count > 0)
                {
                    DataRow filaProveedor = detallesProveedor.Rows[0];

                    // Actualizar los labels con la información del proveedor
                    lblEmpresa.Text = filaProveedor["Empresa"].ToString();
                    lblContacto.Text = filaProveedor["Contacto"].ToString();
                    lblTelefono.Text = filaProveedor["Teléfono"].ToString();
                    lblEmail.Text = filaProveedor["Email"].ToString();
                    lblCiudad.Text = filaProveedor["Ciudad"].ToString();

                    // Guardar el ID del proveedor seleccionado
                    selectedProveedorId = Convert.ToInt32(filaProveedor["Id"]);
                }
                else
                {
                    LimpiarLabelsProveedor();
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
        }

        private void LimpiarLabelsProveedor()
        {
            lblEmpresa.Text = "";
            lblContacto.Text = "";
            lblTelefono.Text = "";
            lblEmail.Text = "";
            lblCiudad.Text = "";
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = txtArticulo.Text.Trim();

            if (!string.IsNullOrEmpty(textoBuscado))
            {
                DataTable articulos = clArticulo.ObtenerArticulosPorNombre(textoBuscado);
                lsbArticulo.Items.Clear();

                foreach (DataRow fila in articulos.Rows)
                {
                    lsbArticulo.Items.Add(fila["Nombre"].ToString());
                }

                lsbArticulo.Visible = lsbArticulo.Items.Count > 0;
            }
            else
            {
                lsbArticulo.Items.Clear();
                lsbArticulo.Visible = false;
            }
        }

        private void lsbArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsbArticulo.SelectedItem != null)
            {
                string articuloSeleccionado = lsbArticulo.SelectedItem.ToString();
                txtArticulo.Text = articuloSeleccionado;
                lsbArticulo.Visible = false;

                // Obtener detalles del artículo
                DataTable detallesArticulo = clArticulo.ObtenerArticulosPorNombre(txtArticulo.Text);

                if (detallesArticulo.Rows.Count > 0)
                {
                    DataRow filaArticulo = detallesArticulo.Rows[0];

                    // Guardar el ID del artículo seleccionado
                    selectedArticuloId = Convert.ToInt32(filaArticulo["Id"]);
                }
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Insumos();
            corte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CL_RInsumos clRInsumos = new CL_RInsumos();
                int idUsuario = 2; // ID del administrador
                int idProveedor = selectedProveedorId; // Usar la variable que ya contiene el ID
                DateTime fechaEntrada = DateTime.Now;

                clRInsumos.GuardarRegistroInsumos(idUsuario, idProveedor, dtListaArticulos, fechaEntrada);

                MessageBox.Show("Registro guardado correctamente.");
                dtListaArticulos.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Valido que hay seleccionado un artículo y que la cantidad sea valida
            if (!string.IsNullOrEmpty(txtArticulo.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                DataTable articulos = clArticulo.ObtenerArticulosPorNombre(txtArticulo.Text);

                if (articulos.Rows.Count > 0)
                {
                    DataRow filaArticulo = articulos.Rows[0];

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtListaArticulos);
                    row.Cells[0].Value = filaArticulo["Id"].ToString();
                    row.Cells[1].Value = filaArticulo["Nombre"].ToString();
                    row.Cells[2].Value = filaArticulo["Descripcion"].ToString();
                    row.Cells[3].Value = cantidad.ToString();
                    row.Cells[4].Value = !string.IsNullOrEmpty(mskFechaVenc.Text) ? mskFechaVenc.Text : "N/A";

                    dtListaArticulos.Rows.Add(row);

                    txtArticulo.Clear();
                    txtCantidad.Clear();
                    mskFechaVenc.Clear();
                }
                else
                {
                    MessageBox.Show("Artículo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
                // Verificar si hay una fila seleccionada
                if (dtListaArticulos.CurrentRow != null)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = dtListaArticulos.CurrentRow.Index;

                    // Confirmar la eliminación
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                           "Confirmar eliminación",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        dtListaArticulos.Rows.RemoveAt(rowIndex);
                        dtListaArticulos.Refresh();
                    }
                }
                else          
                {
                    MessageBox.Show("Selecciona un artículo para eliminar.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
        }

    }
}