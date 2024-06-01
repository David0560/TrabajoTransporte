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
using CL_Negocios;


namespace CV_Presentacion
{
    public partial class frm_Usuario : Form
    {
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
            listaPermiso(); // es mejor cargarlo en una lista para porde borrarlo antes de cargarles los permisos..... pendiente
            

        }

        // llenar el combo Empleados
        private void comboRoles()
        {
            combosSql cn = new combosSql();
            cboPermisos.DataSource = cn.CargarRoles();
            // indicamos las tablas a mostrar  y el valor que va a tomar.
            cboPermisos.DisplayMember = "nombre_rol"; // acá indicamos que es lo que queremos visualizar
            cboPermisos.ValueMember = "id_rol"; // en esta nos dice que valor va a tomar ese combo

        }
        private void comboEmpleado()
        {
            combosSql cn = new combosSql();
            cboEmpleados.DataSource = cn.CargarEmpleados();
            // indicamos las tablas a mostrar  y el valor que va a tomar.
            cboEmpleados.DisplayMember = "nombre"; // acá indicamos que es lo que queremos visualizar
            cboEmpleados.ValueMember = "id_persona"; // en esta nos dice que valor va a tomar ese combo
        }
        private void comboFamilia()
        {
            combosSql cn = new combosSql();
            cboFamilias.DataSource = cn.CargarFamilia();
            //cboFamilias.Items.Insert(0, ""); // agrego el primer intem null para que se pueda selecciona un elemento.
            //indicamos las tablas a mostrar  y el valor que va a tomar.
            cboFamilias.DisplayMember = "nombre"; // acá indicamos que es lo que queremos visualizar
            cboFamilias.ValueMember = "id_familia"; // en esta nos dice que valor va a tomar ese combo
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
                dgvPermisoUsuario.DataSource = ds.listarPermisos();
                //lblFilas.Text = "total registros: " + Convert.ToString(dgvDatos.Rows.Count - 1); // resto 1 solo si me pone una fina en blanco.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblVerValor.Text = cboPermisos.SelectedValue.ToString();
        }
    }
}
