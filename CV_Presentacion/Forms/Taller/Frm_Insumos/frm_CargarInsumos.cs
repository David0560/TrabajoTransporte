using CL_Negocios;
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

        public frm_CargarInsumos()
        {
            InitializeComponent();
            clProveedores = new CL_Proveedores();
            lsbProveedor.Visible = false; // Ocultar el ListBox por defecto
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = txtProveedor.Text.Trim();

            if (!string.IsNullOrEmpty(textoBuscado))
            {
                // Llamo al método en la capa de lógica para obtener proveedores
                DataTable proveedores = clProveedores.ObtenerProveedoresPorEmpresa(textoBuscado);

                // se limpia el ListBox antes de agregar nuevos resultados
                lsbProveedor.Items.Clear();

                // se llena el ListBox con los nombres de los proveedores encontrados
                foreach (DataRow fila in proveedores.Rows)
                {
                    lsbProveedor.Items.Add(fila["Empresa"].ToString());
                }

                // Muestro el ListBox si hay resultados
                lsbProveedor.Visible = lsbProveedor.Items.Count > 0;
            }
            else
            {
                // Limpiar el ListBox y ocultarlo si el texto está vacío
                lsbProveedor.Items.Clear();
                lsbProveedor.Visible = false;
            }
        }

        private void lsbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsbProveedor.SelectedItem != null)
            {
                txtProveedor.Text = lsbProveedor.SelectedItem.ToString(); // Copia el texto seleccionado al TextBox
                lsbProveedor.Visible = false; // Ocultar el ListBox después de seleccionar
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Insumos();
            corte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}