using CapaServicios;
using CapaServicios.Entidades;
using CapaServicios.Entidades.Diaria;
using CapaServicios.Entidades.Diaria.CierrePlanilla;
using CL_Negocios;
using CL_Negocios.Entidades;
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
        int id;
        private ContolUnidad ControlU; // Objeto para almacenar la persona de Form2

        private List<CorteViaPublica> listaCorte;
        private List<Testigo> listaTestigo;
        private List<Lesionados> listaLesionado;
        private List<Accidente> listaAccidente;

        public frm_CierrePlanilla()
        {
            InitializeComponent();
            servicio.parametrosDataGridView(dgvCierre);

            
            
        }

        //Botones con llamadas
        private void btnControlUnidad_Click(object sender, EventArgs e)
        {
            frm_ControlUnidad unidad = new frm_ControlUnidad();

           if (unidad.ShowDialog() == DialogResult.OK) 
            {
                ControlU = unidad.objetos1;
                lblControUnidad.Text = "1";
            }
           ErrorCargarUnidad();
        } // listo - ok
        private void btnCorte_Click(object sender, EventArgs e)
        {
            frm_Cortes corte = new frm_Cortes();
            corte.ShowDialog();
        
            //recibir la lista de objetos desde formulariox
            listaCorte = corte.GetListaCorte();
            lblCorte.Text = listaCorte.Count().ToString();
        } // listo
        private void btnRecambio_Click(object sender, EventArgs e)
        {
            frm_Recambio recambio = new frm_Recambio();
            recambio.ShowDialog();

        }
        private void btnAccidente_Click(object sender, EventArgs e)
        {
            frm_Accidentes accidente = new frm_Accidentes();
            accidente.ShowDialog();

            //recibir la lista de objetos desde formulario
            listaAccidente = accidente.GetListaAccidente();
            lblAccidente.Text = listaAccidente.Count().ToString();

        }//listo
        private void btnLesionados_Click(object sender, EventArgs e)
        {
            frm_Lesionados lesion = new frm_Lesionados();
            lesion.ShowDialog();

            //recibir la lista de objetos desde formulariox
            listaLesionado = lesion.GetListaLesionados();
            lblLesionado.Text = listaLesionado.Count().ToString();
        } //listo
        private void btnTestigo_Click(object sender, EventArgs e)
        {
            frm_Testigo testigo = new frm_Testigo();
            testigo.ShowDialog();

            //recibir la lista de objetos desde formulariox
            listaTestigo = testigo.GetListaTestigo();
            lblTestigo.Text = listaTestigo.Count().ToString();
        }//listo


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
        private void CargarRegistro()
        {
            id = Convert.ToInt32(this.dgvCierre.SelectedRows[0].Cells["id"].Value);
            DataTable dt = new DataTable();
            dt = PCierre.verRegistro(id);

            lblEmpleado.Text = dt.Rows[0][0].ToString();//hora salida colectivo
            lblUnidad.Text = dt.Rows[0][1].ToString(); //Nombre unidad
            lblHoraS.Text = dt.Rows[0][2].ToString();// Horalaboral
            lblHoraSal.Text = dt.Rows[0][3].ToString();// horaSAlida
            lblRamal.Text = dt.Rows[0][4].ToString();// ramal
            lblKmsalida.Text = dt.Rows[0][5].ToString();// kilometros con los que salio
        }
        private void dgvCierre_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarRegistro();
            ErrorCargarUnidad();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(this.dgvCierre.SelectedRows[0].Cells["id"].Value);
            int kmLlegada = Convert.ToInt32(txbKm.Text);
            int combustible = Convert.ToInt32(txbCombustible.Text);
            TimeSpan hora = TimeSpan.Parse(mrkHora.Text);

            if (ValidarObjeto.ContieneDatos(ControlU)) 
            {
                CierrePlanillaLaboral objeto = new CierrePlanillaLaboral(id, hora, kmLlegada, combustible);

                if (PCierre.GuardarCierre(objeto))
                {  
                    // Guardar el objeto en la base de datos
                    if (PCierre.GuardarControlUnidad(ControlU, id))
                    {
                        if (PCierre.GuardarRecorrida(listaCorte, listaAccidente, listaLesionado, listaTestigo, id))
                        {
                            MessageBox.Show("Todos los Documentos fueron guardados");
                        }
                        else
                        {
                            MessageBox.Show("Error al cargar los registros, comuniquese con el administrador");
                        }
                        
                    }
                    else{
                        MessageBox.Show("No se pudieron guardar los registros."); //
                    }
                }else{
                    MessageBox.Show("No se puede guardar. La control de unidad.");//
                }
                MessageBox.Show($"El cierre fue guardado");
                servicio.LimpiarFormulario(this);
                mrkHora.Text = "";//
                limpiarLabelFormulario();
                CargarPlanillas();
            }else{
                MessageBox.Show($"error al cargar los datos");
                limpiarLabelFormulario();
            }
        }
        private void limpiarLabelFormulario()
        {
            lblEmpleado.Text = "";
            lblUnidad.Text = "";
            lblHoraS.Text = "";
            lblHoraSal.Text = "";
            lblRamal.Text = "";

            lblControUnidad.Text = "0";
            lblCorte.Text = "0";
            lblCambio.Text = "0";
            lblAccidente.Text = "0";
            lblLesionado.Text = "0";
            lblTestigo.Text = "0";

        }
        private void ErrorCargarUnidad()
        {
            if (lblControUnidad.Text == "1")
            {
                btnControlUnidad.Enabled = false;
            }
            else
            {
                btnControlUnidad.Enabled = true;
            }
        }

        private void MostrarContenido(int id) // pendiente (no esta funcionando)
        {
            if (id > 0)
            {
                btnControlUnidad.Enabled = false;
                btnControlUnidad.Enabled = false;
                btnCorte.Enabled = false;
                btnRecambio.Enabled = false;
                btnAccidente.Enabled = false;
                btnLesionados.Enabled = false;
                btnTestigo.Enabled = false;
            }
        }
    }
}
