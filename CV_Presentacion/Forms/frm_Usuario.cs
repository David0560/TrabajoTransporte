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
using CapaServicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CV_Presentacion
{
    public partial class frm_Usuario : Form
    {
        connectionBD conexion = new connectionBD("BD_Trasnporte", "DESKTOP-MN8P3IJ\\SQLEXPRESSS", "DESKTOP-MN8P3IJ\\david", "");
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_administrarTablas tabla = new CL_administrarTablas();
        CL_administrarRegistros registro = new CL_administrarRegistros();
        CS_contraseña password = new CS_contraseña();
        public frm_Usuario()
        {
            InitializeComponent();
            
        }
                
        private void frm_Usuario_Load_1(object sender, EventArgs e)

        {
            //
            // valores para hacer el dateTimePicker null
            //
            dtpVencePass.CustomFormat = " ";
            dtpVencePass.ValueChanged += new System.EventHandler(this.dtpVencePass_ValueChanged);
            dtpVencePass.ShowCheckBox = true;
            dtpVencePass.Checked = false;
            dtpVencePass.MinDate = DateTime.Today;

            dtpVenceUsuario.CustomFormat = " ";
            dtpVenceUsuario.ValueChanged += new System.EventHandler(this.dtpVenceUsuario_ValueChanged);
            dtpVenceUsuario.ShowCheckBox = true;
            dtpVenceUsuario.Checked = false;
            dtpVenceUsuario.MinDate = DateTime.Today;

            //
            // Comportamiento del DatagridView
            //
            dgvPermisoUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer click en alguna celda
            dgvPermisoUsuario.MultiSelect = false; // Que no pueda seleccionar multiples filas
            dgvPermisoUsuario.ReadOnly = true; // Hace que la grilla no se pueda editar
            dgvPermisoUsuario.AllowUserToAddRows = false; // Desactiva  la ultima fila 
            dgvPermisoUsuario.RowHeadersVisible = false; // Oculto los encabezados de filas
            // Grafica
            dgvPermisoUsuario.AutoResizeColumns();
            dgvPermisoUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPermisoUsuario.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
            dgvPermisoUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Quito los bordes de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Color de fondo de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto de la cabecera
            //dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue; // Color de fondo de la celda del encabezado seleccionada
            dgvPermisoUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras


            timer1.Enabled = true;
            combo.seleccionCombo(cboEmpleados, "spVerEmpleados");
            combo.seleccionCombo(cboFamilias,"spVerFamilias");
            lblVerValor.Text = dtpVencePass.Value.ToString();
            //dateTime.now.toString("yyyy-MM-dd")
            // txtBox.text =hoy.ToShirtDateString; devuelve la fecha de hoy.
            // hoy.ToString("yyyy-MM-dd=);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");// coloco la hora actual de la pc en el label
        }
        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVerValor.Text = Convert.ToString(cboEmpleados.SelectedValue);// selectedValue toma el id del combo
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // cargar nuevo usuario
            if (cboEmpleados.SelectedValue != null)
            {
                bool respuesta = tabla.validarExistenciaDeUsuario(Convert.ToInt32(cboEmpleados.SelectedValue));
                if (respuesta)
                {
                    
                    string pass = password.crearContraseñaRandom(4,8,true,false,false,false);
                    DateTime fecha = DateTime.Now;
                    int id_empleado = Convert.ToInt32(cboEmpleados.SelectedValue.ToString());
                    int id_familia = Convert.ToInt32(cboFamilias.SelectedValue.ToString());
                    DateTime fvp = dtpVencePass.Value;
                    DateTime fvu = dtpVenceUsuario.Value;
                   

                    // cargar un nuevo usuario
                    Usuario usuario = new Usuario(txtNombreUsuario.Text,1,id_empleado,pass,id_familia,fvp,fvu);
                    registro.insertarNuevoUsuario(usuario);
                    MessageBox.Show("Nuevo Usuario cargado");



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
                MessageBox.Show("No se encuentra usuario seleccionado");
                //lblVerValor.Text = respuesta.ToString();
            }
        }

        private void cboFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFamilias.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
                lblVerValor.Text = cboFamilias.SelectedValue.ToString();
            }
        }

        private void listaPermiso()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboFamilias.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboFamilias.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    dgvPermisoUsuario.DataSource = tabla.permisosPorFamilia(valorSeleccionado);
                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        private void dtpVencePass_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp.ShowCheckBox)
            {
                if (dtp.Checked)
                {
                    dtp.Format = DateTimePickerFormat.Short;
                }
                else
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
        }
        private void dtpVenceUsuario_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp.ShowCheckBox)
            {
                if (dtp.Checked)
                {
                    dtp.Format = DateTimePickerFormat.Short;
                }
                else
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
        }


        //
        // tab administrar permisos
        //
        private void tabAltaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboSeleccionarUsuario, "spVerUsuario");// carga los registros al seleccionar un tab
            combo.seleccionCombo(cboSeleccionarPermiso, "spVerRoles");
        }
        private void listaRoles()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboSeleccionarUsuario.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboSeleccionarUsuario.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    dgvDatos.DataSource = tabla.permisosPorFamilia(valorSeleccionado);
                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        private void cboSeleccionarUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cboSeleccionarUsuario.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaRoles();
                lblFilas.Text = cboSeleccionarUsuario.SelectedValue.ToString();
            }
        }
        






        /*private void btnCargarPermisos_Click(object sender, EventArgs e)
        {
             cachePermisosAlta permiso = new cachePermisosAlta()// instancio el objeto cachePermisos
             {
                 //cargo los Valores de reader en sus atributos correspondientes
                 IdRol = Convert.ToInt32(cboSeleccionarPermiso.SelectedIndex.ToString()),
                 NombreRol = cboSeleccionarPermiso.Text.ToString()
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
             dgvPermisoUsuario.DataSource = tabla.totalRoles();
         }
        */

        //
        //Tab para generar nuevas preguntas.
        //
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
        private void btnGuardarPregunta_Click(object sender, EventArgs e)
        {
            CL_administrarPreguntas pre = new CL_administrarPreguntas();
            pre.crearNuevaPregunta(textBox7.Text);
        }

    }
}