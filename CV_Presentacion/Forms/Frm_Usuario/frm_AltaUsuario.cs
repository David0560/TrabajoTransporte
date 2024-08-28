using System;
using System.Windows.Forms;
using CL_Negocios;
using CapaServicios;
using CL_Negocios.Entidades;
using CL_Negocios.Usuarios;


namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_AltaUsuario : Form
    {
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CS_servicios servicio = new CS_servicios();

        CL_administrarTablas tabla = new CL_administrarTablas();
        CL_AdministrarUsuario registro = new CL_AdministrarUsuario();

        ConfiguracionPassword configure = new ConfiguracionPassword();
        
        
        private ConfiguracionPasswordBLL configuracionPasswordBLL;
        private string connectionString = "Data Source=not_CASA\\MSSQLSERVER01;Initial Catalog=BD_Trasnporte;Integrated Security=True;"; //Cambiar el data Source por tu cadena de conexión

        public frm_AltaUsuario()
        {
            InitializeComponent();
            configuracionPasswordBLL = new ConfiguracionPasswordBLL(connectionString);
        }

        private void frm_AltaUsuario_Load(object sender, EventArgs e)
        {   //
            // Comportamiento del DatagridView
            //
            servicio.parametrosDataGridView(dgvPermisoUsuario);
            combo.seleccionCombo(cboEmpleados, "spVerEmpleados");
            combo.seleccionCombo(cboFamilias, "spVerFamilias");
            mkdVencePass.Text = null;
            mkdVenceUsuario.Text = null; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // cargar nuevo usuario
            if (cboEmpleados.SelectedValue != null)
            {
                bool respuesta = tabla.validarExistenciaDeUsuario(Convert.ToInt32(cboEmpleados.SelectedValue));
                if (respuesta)
                {

                    string nombre = txtNombreUsuario.Text;
                    int id_empleado = Convert.ToInt32(cboEmpleados.SelectedValue.ToString());
                    int id_familia = Convert.ToInt32(cboFamilias.SelectedValue.ToString());
                    string fvp = mkdVencePass.Text;
                    string fvu = mkdVenceUsuario.Text;

                    // Registro del nuevo usuario
                    Usuario usuario = new Usuario(nombre, id_empleado, id_familia, fvp, fvu);
                    if (registro.insertarNuevoUsuario(usuario, configure))
                    {
                        MessageBox.Show("Nuevo Usuario cargado");

                        // cargar los permisos al usuario creado.
                        foreach (DataGridViewRow fila in dgvPermisoUsuario.Rows)
                        {
                            int id_famil_rol = Convert.ToInt32(fila.Cells["id"].Value);

                            Permisos permiso = new Permisos(id_famil_rol);
                            registro.insertarPermisoPorFamilia(permiso);
                        }

                        servicio.LimpiarControlesForm(this);
                    }
                    else
                    {
                        MessageBox.Show("error al cargar el Usuario");
                    }
                }
                else
                {
                    MessageBox.Show("El empleado ya cuenta con un usuario");
                }
            }
            else
            {
                MessageBox.Show("No se encuentra usuario seleccionado");
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
                    dgvPermisoUsuario.DataSource = tabla.permisosTorTipoDeUsuario(valorSeleccionado);

                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        private void cboFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFamilias.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
            }
        }
    }
}
