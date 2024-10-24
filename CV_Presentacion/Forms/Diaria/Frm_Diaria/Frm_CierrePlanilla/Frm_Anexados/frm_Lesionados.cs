using CapaServicios.Entidades.Diaria.CierrePlanilla;
using CapaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    public partial class frm_Lesionados : Form
    {
        CS_servicios servicio = new CS_servicios();
        private List<Lesionados> listaLesionados;

        public frm_Lesionados()
        {
            InitializeComponent();
            txbApellido.Focus();
            listaLesionados = new List<Lesionados>();
            cargar();
            servicio.estiloDataGrid(dgvDatos);
        }
        public List<Lesionados> GetListaLesionados()
        {
            return listaLesionados;
        }
        public void cargar()
        {
            dgvDatos.DataSource = null; // Limpiar la fuente de datos
            dgvDatos.DataSource = listaLesionados;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Lesionados Dato = new Lesionados(
               txbApellido.Text,
               txbNombre.Text,
               Convert.ToInt32(txbDni.Text),
               txbDomicilio.Text,
               Convert.ToInt32(txbNumero.Text),
               Convert.ToInt32(txbTelefono.Text)
                );
            listaLesionados.Add(Dato);
            cargar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            servicio.LimpiarTodoControl(groupBox2);
            txbApellido.Focus();
        }
        private void btnElimiar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int index = dgvDatos.SelectedRows[0].Index;

                // Obtener el objeto a eliminar
                Lesionados objetoAEliminar = listaLesionados[index];

                // Eliminar del origen de datos
                listaLesionados.Remove(objetoAEliminar);

                // Actualizar el DataGridView
                dgvDatos.DataSource = null; // Limpiar la fuente de datos
                dgvDatos.DataSource = listaLesionados; // Volver a establecer la fuente de datos
            }
        }
    }
}
