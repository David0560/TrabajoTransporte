
using CapaServicios;
using CapaServicios.Entidades.Frecuencia;
using CD_ConexionDatos.Entidades;
using CL_Negocios;
using CL_Negocios.Entidades;
using CL_Negocios.GrillaLaboral;
using Microsoft.Win32;
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
            DateTime fecha = dtpFecha.Value;
            int ramal = Convert.ToInt32(cboRamales.SelectedValue);

            dgvGrillaDelDia.DataSource = grilla.GrillaDia(grilla.GenerarGrilla(ramal, fecha));
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //crear registro grilla ----- ok
            // llamar el ultimo registro grilla ------- ok
            // pasar como parametro idGrilla ------- ok
            //llenar una lista con las planillasdiarias -------ok 
            //cargar los registros. -------ok

            //filtrar proximos intentos de dias y ramales ya creados
            //filtrar personal ya guardado y unidades ya asignadas.
            //


            DateTime fecha = dtpFecha.Value;
            int ramal = Convert.ToInt32(cboRamales.SelectedValue);

            int IdGrilla = 1;  //grilla.GuardarGrilla(fecha);

            if (IdGrilla!=0)
            {
               bool resultado= grilla.guardarPlanillasLaboral(IdGrilla, ramal,fecha);
                if (resultado == true)
                {
                    MessageBox.Show("registros Guardados exitozamente");

                }
                else
                {
                    MessageBox.Show("registros Guardados exitozamente");
                }
            }
            Servicio.LimpiarFormulario(this);
        }
    }
}
