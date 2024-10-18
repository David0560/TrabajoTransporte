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

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    public partial class frm_Testigo : Form
    {
        CS_servicios servicio = new CS_servicios();
        private List<Testigo> listaTestigo;
        public frm_Testigo()
        {
            InitializeComponent();
            txbApellido.Focus();
            listaTestigo = new List<Testigo>();
            cargar();
            servicio.estiloDataGrid(dgvDatos);
        }
        public List<Testigo> GetListaTestigo()
        {
            return listaTestigo;
        }

        public void cargar()
        {
            dgvDatos.DataSource = null; // Limpiar la fuente de datos
            dgvDatos.DataSource = listaTestigo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Testigo Dato = new Testigo(
               txbApellido.Text,
               txbNombre.Text,
               Convert.ToInt32(txbDNI.Text),
               txbDomicilio.Text,
               Convert.ToInt32(txbNumero.Text),
               Convert.ToInt32(txbTelefono.Text)
                );
            listaTestigo.Add(Dato);
            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            servicio.LimpiarTodoControl(groupBox2);
            txbApellido.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
