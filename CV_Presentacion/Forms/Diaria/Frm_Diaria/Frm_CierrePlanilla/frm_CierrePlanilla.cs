using CV_Presentacion.Forms.Diaria.Frm_Diaria;
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

namespace CV_Presentacion.Forms.Frm_Registros
{
    public partial class frm_CierrePlanilla : Form
    {
        public frm_CierrePlanilla()
        {
            InitializeComponent();
        }

        private void btnControlUnidad_Click(object sender, EventArgs e)
        {
            Form corte = new frm_ControlUnidad();
            corte.Show();
        }
        private void btnCorte_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Cortes();
            corte.Show();
        }
        private void btnRecambio_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Recambio();
            corte.Show();
        }
        private void btnAccidente_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Accidentes();
            corte.Show();
        }
        private void btnLesionados_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Lesionados();
            corte.Show();
        }
        private void btnTestigo_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Testigo();
            corte.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

    }
}
