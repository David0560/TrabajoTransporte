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
            corte.ShowDialog();
        }
        private void btnCorte_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Cortes();
            corte.ShowDialog();
        }
        private void btnRecambio_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Recambio();
            corte.ShowDialog();
        }
        private void btnAccidente_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Accidentes();
            corte.ShowDialog();
        }
        private void btnLesionados_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Lesionados();
            corte.ShowDialog();
        }
        private void btnTestigo_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Testigo();
            corte.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

    }
}
