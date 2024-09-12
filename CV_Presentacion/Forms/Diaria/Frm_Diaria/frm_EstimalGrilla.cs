
using CL_Negocios;
using CL_Negocios.GrillaLaboral;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla
{
    
    public partial class frm_EstimalGrilla : Form
    {
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_AdministrarGrilla grilla = new CL_AdministrarGrilla();
        public frm_EstimalGrilla()
        {
            InitializeComponent();
        }

        private void frm_EstimalGrilla_Load(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboRamales, "spVerRamal");
        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int id = Convert.ToInt32(cboRamales.SelectedValue);

            //dgvGrillaDelDia.DataSource = grilla.ChoferesQueTrabajan(grilla.GrillaPorRamal(id, fecha),fecha).Columns.Add();
            DataTable Tabla2 = grilla.ChoferesQueTrabajan(grilla.GrillaPorRamal(id, fecha), fecha);
            DataTable Tabla = grilla.GrillaPorRamal(id, fecha);
            //Tabla.DefaultView.Table.Columns.Add("Legajo", typeof(int));
            //Tabla.DefaultView.Table.Columns.Add("Chofer", typeof(String));

            dgvGrillaDelDia.DataSource = Tabla;
            //dgvGrillaDelDia.DataSource = grilla.GrillaPorRamal(id, fecha)// devuelve todos los choferes
        }

    }
}
