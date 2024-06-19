using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CD_ConexionDatos;
using CL_Negocios;
using CL_Negocios.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CV_Presentacion
{
    public partial class frm_Usuario : Form
    {
        connectionBD conexion = new connectionBD("BD_Trasnporte", "DESKTOP-MN8P3IJ\\SQLEXPRESSS", "DESKTOP-MN8P3IJ\\david", "");
        //private datosSql datos = new datosSql();
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_administrarTablas tabla = new CL_administrarTablas();
        public frm_Usuario()
        {
            InitializeComponent();
            
        }
                
        private void frm_Usuario_Load_1(object sender, EventArgs e)
        {
            // Comportamiento
            dgvPermisoUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer click en alguna celda
            dgvPermisoUsuario.MultiSelect = false; // Que no pueda seleccionar multiples filas
            dgvPermisoUsuario.ReadOnly = true; // Hace que la grilla no se pueda editar
            dgvPermisoUsuario.AllowUserToAddRows = false; // Desactiva  la ultima fila 
            dgvPermisoUsuario.RowHeadersVisible = false; // Oculto los encabezados de filas

            // Grafica
            dgvPermisoUsuario.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
            dgvPermisoUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Quito los bordes de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Color de fondo de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue; // Color de fondo de la celda del encabezado seleccionada
            dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras


            timer1.Enabled = true;
            combo.seleccionCombo(cboEmpleados, "spVerEmpleados");
            combo.seleccionCombo(cboFamilias,"spVerFamilias");
            combo.seleccionCombo(cboSeleccionarUsuario, "spVerUsuario");





        }

        // crear un metod void para llenar el datagridview
        /*private void lista()
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
                listaPermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }*/
        
         
       
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
        /*private void cboFamilias_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboFamilias.SelectedIndex != -1) //reparo la falta de seleccion en el combobox.
            {
                listaDePermisos();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {         
            cachePermisosAlta permiso = new cachePermisosAlta()// instancio el objeto cachePermisos
            {
                //cargo los Valores de reader en sus atributos correspondientes
                IdRol = Convert.ToInt32(cboPermisos.SelectedIndex.ToString()),
                NombreRol = cboPermisos.Text.ToString()
            };
            datos.agregarRoles(permiso);
            actualizarDataGrid();
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            datos.eliminarRoles(1);
            actualizarDataGrid();
        }
        private void actualizarDataGrid()
        {
            dgvPermisoUsuario.DataSource = null;
            dgvPermisoUsuario.DataSource = datos.totalRoles();
        }*/

        private void btnGuardarPregunta_Click(object sender, EventArgs e)
        {
            CL_administrarPreguntas pre = new CL_administrarPreguntas();
            pre.crearNuevaPregunta(textBox7.Text);
        }

        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVerValor.Text = Convert.ToString(cboEmpleados.SelectedValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (cboEmpleados.SelectedValue != null)
            {
                bool respuesta = tabla.validarExistenciaDeUsuario(Convert.ToInt32(cboEmpleados.SelectedValue));
                    if (respuesta)
                {
                    MessageBox.Show("valores a cargar");
                    lblVerValor.Text = respuesta.ToString();
                }
                else
                {
                    MessageBox.Show("El empleado ya cuenta con un usuario");
                    lblVerValor.Text = respuesta.ToString();
                }
            }
            else
            {
                MessageBox.Show("ya existe un usuario con este empleado");
                //lblVerValor.Text = respuesta.ToString();
            }
        }
    }
}
