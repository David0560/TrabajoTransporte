using CapaServicios;
using CL_Negocios.GrillaLaboral;
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
        CL_AdministrarPlanillaCierre PCierre = new CL_AdministrarPlanillaCierre();
        CS_servicios servicio = new CS_servicios();
        public frm_CierrePlanilla()
        {
            InitializeComponent();
            servicio.parametrosDataGridView(dgvCierre);
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
        private void CargarPlanillas()
        {
            // cargo el DGV mediate la fecha seleccionada.
            DateTime fecha = dtpFecha.Value; // capturo el valor del DateTimePiquer
            dgvCierre.DataSource = null; // limpio el data grid
            dgvCierre.DataSource = PCierre.ListaSalida(fecha); // cargdo el datagrid
            dgvCierre.Columns["id"].Visible = false; // columna oculta
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarPlanillas();
        }
    }
}
