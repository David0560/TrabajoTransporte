
using CapaServicios;
using CD_ConexionDatos.Entidades;
using CL_Negocios;
using CL_Negocios.Entidades;
using CL_Negocios.GrillaLaboral;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla
{
    
    public partial class frm_EstimalGrilla : Form
    {
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_AdministrarGrilla grilla = new CL_AdministrarGrilla();
        CS_servicios Servicio = new CS_servicios();
        public frm_EstimalGrilla()
        {
            InitializeComponent();

        }
       
        private void frm_EstimalGrilla_Load(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboRamales, "spVerRamal");
            Servicio.parametrosDataGridView(dgvGrillaDelDia);
        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int ramal = Convert.ToInt32(cboRamales.SelectedValue);


            // Simulación de una lista de personas
            //dgvGrillaDelDia.DataSource = grilla.Frecunacia(ramal);
            //dgvGrillaDelDia.DataSource = grilla.ChoferesQueTrabajan(fecha);
            //dgvGrillaDelDia.DataSource = grilla.UnidadesActivas(fecha);

            dgvGrillaDelDia.DataSource = grilla.GenerarGrilla(ramal,fecha);

            
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            Servicio.LimpiarControlesForm(this);
            MessageBox.Show("Los Registros fueron creados con exito.");
        }
    }
}
