using CL_Negocios;
using CL_Negocios.Taller;
using CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla.Frm_Anexados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Taller.Frm_Insumos
{
    public partial class frm_CargarInsumos : Form
    {
        private CL_Proveedores clProveedores;
        private CL_Articulo clArticulo;

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
                //Metodo para obtener proveedores
                DataTable proveedores = clProveedores.ObtenerProveedoresPorEmpresa(textoBuscado);

                //Limpio el ListBox antes de agregar nuevos resultados
                lsbProveedor.Items.Clear();

                //Lleno el ListBox con los nombres de los proveedores encontrados
                foreach (DataRow fila in proveedores.Rows)
                {
                    lsbProveedor.Items.Add(fila["Empresa"].ToString());
                }

                //Muestra el ListBox si hay resultados
                lsbProveedor.Visible = lsbProveedor.Items.Count > 0;
            }
            else
            {
                //Limpia el ListBox y ocultarlo si el texto está vacío
                lsbProveedor.Items.Clear();
                lsbProveedor.Visible = false;

                //Limpia los labels cuando el texto está vacío
                lblEmpresa.Text = "";
                lblContacto.Text = "";
                lblTelefono.Text = "";
                lblEmail.Text = "";
                lblCiudad.Text = "";
            }
        }

        private void lsbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsbProveedor.SelectedItem != null)
            {
                txtProveedor.Text = lsbProveedor.SelectedItem.ToString();
                lsbProveedor.Visible = false; 

                DataTable detallesProveedor = clProveedores.ObtenerProveedoresPorEmpresa(txtProveedor.Text);

                if (detallesProveedor.Rows.Count > 0)
                {
                    DataRow filaProveedor = detallesProveedor.Rows[0];

                    //Actualizo los labels con la información del proveedor
                    lblEmpresa.Text = filaProveedor["Empresa"].ToString();
                    lblContacto.Text = filaProveedor["Contacto"].ToString();
                    lblTelefono.Text = filaProveedor["Teléfono"].ToString();
                    lblEmail.Text = filaProveedor["Email"].ToString();
                    lblCiudad.Text = filaProveedor["Ciudad"].ToString();
                }
                else
                {
                    //Si no hay proveedor, limpiar los labels
                    lblEmpresa.Text = "";
                    lblContacto.Text = "";
                    lblTelefono.Text = "";
                    lblEmail.Text = "";
                    lblCiudad.Text = "";
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = txtArticulo.Text.Trim();

            if (!string.IsNullOrEmpty(textoBuscado))
            {
                //Metodo para obtener artículos
                DataTable articulos = clArticulo.ObtenerArticulosPorNombre(textoBuscado);

                //Limpio el ListBox antes de agregar nuevos resultados
                lsbArticulo.Items.Clear();

                //Lleno el ListBox con los nombres de los artículos encontrados
                foreach (DataRow fila in articulos.Rows)
                {
                    lsbArticulo.Items.Add(fila["Nombre"].ToString());
                }

                //Muestro el ListBox si hay resultados
                lsbArticulo.Visible = lsbArticulo.Items.Count > 0;
            }
            else
            {
                //Limpio el ListBox y ocultarlo si el texto está vacío
                lsbArticulo.Items.Clear();
                lsbArticulo.Visible = false;
            }
        }

        private void lsbArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsbArticulo.SelectedItem != null)
            {
                txtArticulo.Text = lsbArticulo.SelectedItem.ToString();
                lsbArticulo.Visible = false; //Se Oculta el ListBox después de seleccionar
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
    }
}