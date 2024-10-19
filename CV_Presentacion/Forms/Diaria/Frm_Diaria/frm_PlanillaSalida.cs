using CapaServicios;
using CapaServicios.Entidades.Diaria;
using CL_Negocios.Entidades;
using CL_Negocios.GrillaLaboral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    public partial class frm_PlanillaSalida : Form
    {
        CL_AdministrarPlanillaSalida PSalida = new CL_AdministrarPlanillaSalida();
        CS_servicios servicio = new CS_servicios();
        
        public frm_PlanillaSalida()
        {
            InitializeComponent();
            PermitirCambios();
            servicio.parametrosDataGridView(dgvSalidar);
            
        }
        
        //eventos
        private void ckbModificar_CheckedChanged(object sender, EventArgs e)
        {
            PermitirCambios();
            lblNomChofer.Text = lblChofer.Text;
            lblNomUnidad.Text = lblUnidad.Text;

            int turno = Turno();

            //bomboBox para la modificacion
            DateTime fecha = dtpFechas.Value;
            CmbChofer.DataSource = PSalida.SelecinarChoferes(fecha, turno);
            CmbChofer.DisplayMember = "Chofer"; // acá indicamos que es lo que queremos visualizar
            CmbChofer.ValueMember = "legajo"; // en esta nos dice que valor va a tomar ese combo
            CmbChofer.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbChofer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbChofer.SelectedIndex = -1; // mostrar el combo vacio.

            CmbUnidad.DataSource = PSalida.SeleccionarUnidades(fecha);
            CmbUnidad.DisplayMember = "Nombre"; // acá indicamos que es lo que queremos visualizar
            CmbUnidad.ValueMember = "IdUnidad"; // en esta nos dice que valor va a tomar ese combo
            CmbUnidad.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbUnidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbUnidad.SelectedIndex = -1; // mostrar el combo vacio.


        }
        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            CargarPlanillas();
        }
        private void dgvSalidar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos();
            ckbModificar.Checked = false;
            limpiarLabelActualizar();
        }
        private void btnActualizarRegistros_Click(object sender, EventArgs e)
        {
            //actualizar registros
            // +++ obtener el resto de los recursos no cargados en la tabla
            // +++ choferes y unidades no utilizadas ese dia.
            // +++ realizar validaciones
            // +++ actualizar el registro con el nuevo recurso
            //volver a cargar la vista
            //bloquear panel 

            int id = Convert.ToInt32(dgvSalidar.SelectedRows[0].Cells["id"].Value);

            // selecciono una valor del comboBox en el caso de ser null devuelve valor 0
            int id_empleado = (CmbChofer.SelectedValue != null) ? (int)CmbChofer.SelectedValue : 0;
            int id_Unidad = (CmbUnidad.SelectedValue != null) ? (int)CmbUnidad.SelectedValue : 0;
           
            if (PSalida.CambiarRegistro(id, id_empleado, id_Unidad))
            {
                MessageBox.Show($"actualzacion exitosa");
                CargarDatos();
                ckbModificar.Checked = false; // bloqueo el check
                limpiarLabelActualizar();
            }
            else
            {
                MessageBox.Show($"error al cargar los datos");
                limpiarLabelActualizar();
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvSalidar.SelectedRows[0].Cells["id"].Value);
            TimeSpan hora = TimeSpan.Parse(mskHoraLabo.Text); //// capturar un dato y convertirlo en timespan
            int km = Convert.ToInt32(txbKmSalida.Text);
            int combustible = Convert.ToInt32(tbxCombustibleSalida.Text);

            PlanillaLab Reg = new PlanillaLab(id, km, combustible, hora );//objeto creado.

            if (PSalida.guardarPlanilla(Reg))
            {
                MessageBox.Show($"El registro fue guardado");
                CargarDatos();
                ckbModificar.Checked = false; // bloqueo el check
                servicio.LimpiarFormulario(this);//

                LimpiarLabelGuardar();
                mskHoraLabo.Clear();
                limpiarLabelActualizar();
                CargarPlanillas();
            }
            else
            {
                MessageBox.Show($"error al cargar los datos");
                limpiarLabelActualizar();
            }
        }

        // metodos privados
        private void CargarDatos()
        {
            int id = Convert.ToInt32(this.dgvSalidar.SelectedRows[0].Cells["id"].Value); // cargo el id en una variable para luego pasarla por parametro
            DateTime fecha = dtpFechas.Value;
            //fecha 
            DataTable dt = new DataTable();
            dt = PSalida.VerRegistro(id);
            //cargar valores
            lblSalida.Text = dt.Rows[0][0].ToString();//hora salida colectivo
            lblChofer.Text = dt.Rows[0][1].ToString(); //Nombre y Apellido
            lblUnidad.Text = dt.Rows[0][2].ToString();// nombre
            lblRamal.Text = dt.Rows[0][3].ToString();// nombre
        }
        private int Turno()
        {
            int id = Convert.ToInt32(this.dgvSalidar.SelectedRows[0].Cells["id"].Value); // cargo el id en una variable para luego pasarla por parametro
            DateTime fecha = dtpFechas.Value;
            //fecha 
            DataTable dt = new DataTable();
            dt = PSalida.VerRegistro(id);
            //cargar valores
            int turno;
            return turno = Convert.ToInt32(dt.Rows[0][4].ToString());// nombre
        }
        private void limpiarLabelActualizar()
        {
            lblNomChofer.Text = "";
            lblNomUnidad.Text = "";
        }
        private void LimpiarLabelGuardar()
        {
            lblUnidad.Text = "";
            lblRamal.Text = "";
            lblSalida.Text = "";
            lblChofer.Text = "";
        }
        private void PermitirCambios()
        {
            if (ckbModificar.Checked)
            {
                grbActualizar.Enabled = true;
            }
            else
            {
                grbActualizar.Enabled = false;
                lblNomChofer.Text = null;
                lblNomUnidad.Text = null;
            }
        }
        private void CargarPlanillas()
        {
            // cargo el DGV mediate la fecha seleccionada.
            DateTime fecha = dtpFechas.Value; // capturo el valor del DateTimePiquer
            dgvSalidar.DataSource = null; // limpio el data grid
            dgvSalidar.DataSource = PSalida.ListaSalida(fecha); // cargdo el datagrid
            dgvSalidar.Columns["id"].Visible = false; // columna oculta
        }
    }
}
