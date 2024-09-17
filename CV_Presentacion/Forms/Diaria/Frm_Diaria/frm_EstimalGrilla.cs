
using CapaServicios;
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
            int id = Convert.ToInt32(cboRamales.SelectedValue);
            //dgvGrillaDelDia.DataSource = grilla.GrillaPorRamal(id);
            //dgvGrillaDelDia.DataSource = grilla.ChoferesQueTrabajan(fecha);
            DataTable Tabla2 = grilla.ChoferesQueTrabajan(fecha);
            DataTable Tabla = grilla.GrillaPorRamal(id);

           DataTable Tt = new DataTable();
            Tt.Columns.Add("Nombre", typeof(string));
            Tt.Columns.Add("HoraInicio", typeof(TimeSpan));
            Tt.Columns.Add("Legajo", typeof(int));
            Tt.Columns.Add("Chofer", typeof(string));


            while (Tabla.Rows.Count >0 && Tabla2.Rows.Count > 0)
            {
                DataRow fila1 = Tabla.Rows[0];
                DataRow fila2 = Tabla2.Rows[0];

                DataRow filaTt = Tt.NewRow();
                filaTt["Nombre"] = fila1["Nombre"];
                filaTt["HoraInicio"] = fila1["HoraInicio"];
                filaTt["Legajo"] = fila2["Legajo"];
                filaTt["Chofer"] = fila2["Chofer"];

                Tt.Rows.Add(filaTt);

                Tabla.Rows.Remove(fila1);
                Tabla2.Rows.Remove(fila2);

            }

            dgvGrillaDelDia.DataSource = Tt;



            //Tabla.DefaultView.Table.Columns.Add("Legajo", typeof(int));
            //Tabla.DefaultView.Table.Columns.Add("Chofer", typeof(String));


            //dgvGrillaDelDia.DataSource = grilla.GrillaPorRamal(id, fecha)// devuelve todos los choferes
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            Servicio.LimpiarControlesForm(this);
            MessageBox.Show("Los Registros fueron creados con exito.");
        }
    }
}
