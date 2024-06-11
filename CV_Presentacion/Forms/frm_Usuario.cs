using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CD_ConexionDatos;
using CL_Negocios;
using CL_Negocios.Entidades;


namespace CV_Presentacion
{
    public partial class frm_Usuario : Form
    {
        connectionBD conexion = new connectionBD("BD_Trasnporte", "DESKTOP-8ROL9DF", "DESKTOP-8ROL9DF//Morinigo David", "");
        
        public frm_Usuario()
        {
            InitializeComponent();
            
        }
                
        private void frm_Usuario_Load_1(object sender, EventArgs e)
        {
            // llamar al método listar
            
            timer1.Enabled = true;
            lista();
            comboEmpleado();
            comboFamilia();
            comboRoles();
            comboUsuarios();
            //listaPermiso(); // es mejor cargarlo en una lista para porde borrarlo antes de cargarles los permisos..... pendiente
            

        }

        // llenar el comboBox
        private void comboRoles()
        {
            combosSql cn = new combosSql();
            cboPermisos.DataSource = cn.CargarRoles();
            // indicamos las tablas a mostrar  y el valor que va a tomar.
            cboPermisos.DisplayMember = "nombre_rol"; // acá indicamos que es lo que queremos visualizar
            cboPermisos.ValueMember = "id_rol"; // en esta nos dice que valor va a tomar ese combo
            cboPermisos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPermisos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }
        private void comboEmpleado()
        {
            combosSql cn = new combosSql();
            cboEmpleados.DataSource = cn.CargarEmpleados();
            // indicamos las tablas a mostrar  y el valor que va a tomar.
            cboEmpleados.DisplayMember = "nombre"; // acá indicamos que es lo que queremos visualizar
            cboEmpleados.ValueMember = "id_persona"; // en esta nos dice que valor va a tomar ese combo
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }
        private void comboFamilia()
        {
            combosSql cn = new combosSql();
            cboFamilias.DataSource = cn.CargarFamilia();
            //indicamos las tablas a mostrar  y el valor que va a tomar.
            cboFamilias.DisplayMember = "nombre"; // acá indicamos que es lo que queremos visualizar
            cboFamilias.ValueMember = "id_familia"; // en esta nos dice que valor va a tomar ese combo
            cboFamilias.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboFamilias.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void comboUsuarios()
        {
            combosSql cn = new combosSql();
            cboUsuario.DataSource = cn.CargarUsuarios();
            //indicamos las tablas a mostrar  y el valor que va a tomar.
            cboUsuario.DisplayMember = "nombre_usuario"; // acá indicamos que es lo que queremos visualizar
            cboUsuario.ValueMember = "id_usuario"; // en esta nos dice que valor va a tomar ese combo
            cboUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }


        // crear un metod void para llenar el datagridview
        private void lista()
        {
            try
            {
                // referencia hacia la clase datosSql
                datosSql ds = new datosSql();
                dgvDatos.DataSource = ds.listar();
                lblFilas.Text = "total registros: " + Convert.ToString(dgvDatos.Rows.Count -1); // resto 1 solo si me pone una fina en blanco.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void listaPermiso()
        {
            try
            {
                    // referencia hacia la clase datosSql
                    datosSql ds = new datosSql();
                    dgvPermisoUsuario.DataSource = ds.listarPermisos(cboFamilias.SelectedIndex.ToString());
                    //lblFilas.Text = "total registros: " + Convert.ToString(dgvDatos.Rows.Count - 1); // resto 1 solo si me pone una fina en blanco.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listaDePermisos()
        {
            try
            {
                // referencia hacia la clase datosSql
                //datosSql ds = new datosSql();
                datosSql datos = new datosSql();
                List<cachePermisosAlta> permisos = datos.obtenerRoles(cboFamilias.SelectedIndex.ToString());
                dgvPermisoUsuario.DataSource = permisos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();// coloco la hora actual de la pc en el label
        }

        private void ckbPregunta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPregunta.CheckState == CheckState.Checked) //desactivo el grupo que contiene agregar una nueva pregunta.
            {
                grbPregunta.Visible = false;
                lblTituloPregunta.Text = "Opción de configuracion bloqueada.";
            }
            else
            {
                grbPregunta.Visible = true;
                lblTituloPregunta.Text = "Cargar nueva pregunta de seguridad";
            }
        }

        private void cboPermisos_SelectedValueChanged(object sender, EventArgs e)
        {
            lblVerValor.Text = cboPermisos.SelectedValue.ToString();
        }

        private void cboFamilias_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboFamilias.SelectedIndex != -1) //reparo la falta de seleccion en el combobox.
            {
                listaDePermisos();
            }
        }

    }
}
