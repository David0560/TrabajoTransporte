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
    public partial class frm_Accidentes : Form
    {
        CS_servicios servicio = new CS_servicios();
        private List<Accidente> listaAccidente;
        public frm_Accidentes()
        {
            InitializeComponent();

            txbApellido.Focus();
            listaAccidente = new List<Accidente>();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Accidente Dato = new Accidente(
                txbLugar.Text,
                txbAltura.Text,
                TimeSpan.Parse(mskHora.Text),

                txbApellido.Text,
                txbNombre.Text,
                Convert.ToInt32(txbNRegistro.Text),
                txbDomicilio.Text,
                Convert.ToInt32(txbNumero.Text),
                Convert.ToInt32(txbTelefono.Text),

                txbMarca.Text,
                txbModelo.Text,
                txbPatente.Text,
                txbTitulo.Text,
                txbCSeguro.Text,
                txbPoliza.Text,
                txbDescripcion.Text
               );
            listaAccidente.Add(Dato);
            this.Close();

        }

        public List<Accidente> GetListaAccidente()
        {
            return listaAccidente;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            servicio.LimpiarControlesForm(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
