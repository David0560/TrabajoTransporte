using System;
using System.Windows.Forms;
using CL_Negocios;
using CL_Negocios.Entidades;
using CapaServicios;
using Microsoft.VisualBasic;


namespace CV_Presentacion
{
    public partial class frm_Usuario : Form
    {
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_administrarTablas tabla = new CL_administrarTablas();
        CL_administrarRegistros registro = new CL_administrarRegistros();
        CS_contraseña conta = new CS_contraseña();
        CS_servicios servicio = new CS_servicios();
        ConfiguracionPassword configure = new ConfiguracionPassword();
        public frm_Usuario()
        {
            InitializeComponent();
        }
                
        private void frm_Usuario_Load_1(object sender, EventArgs e)

        {
            configure.Configuracion(4, 8, true, true, false);
            // declaro la configuracion inicial
            txtMinCaracter.Text = configure.Minimo.ToString();
            txtMaxCaracter.Text = configure.Maximo.ToString() ;
            chkMayusMinus.Checked = configure.Mayuscula;
            chkNumLetras.Checked = configure.Mayuscula;
            chkCaracterEspecial.Checked = configure.Especial;

            //
            // Comportamiento del DatagridView
            //
            servicio.parametrosDataGridView(dgvDatos);
            servicio.parametrosDataGridView(dgvListaUsuarios);
            servicio.parametrosDataGridView(dgvPermisoUsuario);

            timer1.Enabled = true;
            combo.seleccionCombo(cboEmpleados, "spVerEmpleados");
            combo.seleccionCombo(cboFamilias,"spVerFamilias");
            mkdVencePass.Text = null;
            mkdVenceUsuario.Text = null;

            registro.LimpiarControlesEnTabPage(tabBloqueos);
            dgvListaUsuarios.DataSource = tabla.ListarUsuarios();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");// coloco la hora actual de la pc en el label
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
                    Usuario usuario = new Usuario(nombre, id_empleado,id_familia,fvp,fvu);
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
                        
                        registro.LimpiarControlesEnTabPage(tabCrearUsuario);
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
        private void cboFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboFamilias.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
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

        //
        // tab administrar permisos
        //
        private void tabAltaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (tabAltaUsuario.SelectedTab == tabAdministrarPermisos)
            

             //dgvListaUsuarios.DataSource = tabla.ListarUsuarios();
            //dgvListaUsuarios.DataSource = null;


            // if (tabAltaUsuario.SelectedTab == tabAdministrarPermisos)

            combo.seleccionCombo(cboSeleccionarUsuario, "spVerUsuario");// carga los registros al seleccionar un tab
                combo.seleccionCombo(cboSeleccionarPermiso, "spVerRoles");
            
            
        }
        private void cboSeleccionarUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSeleccionarUsuario.SelectedValue != null) //reparo la falta de seleccion en el combobox.
             {
                listaRoles();                
             }
            else
            {
                dgvDatos.DataSource = null;
            }
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
                    dgvDatos.DataSource = tabla.permisosPorUsuario(valorSeleccionado);
                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }

        }
        private void btnCargarPermisos_Click(object sender, EventArgs e)
        {
            int id_usuario = Convert.ToInt32(cboSeleccionarUsuario.SelectedValue);
            int id_famil_rol = Convert.ToInt32(cboSeleccionarPermiso.SelectedValue);
            string fecha_vence = mkdFechaVence.Text;

            Permisos nuevoPermiso = new Permisos(id_famil_rol, id_usuario, fecha_vence);
            registro.insertarNuevoPermiso(nuevoPermiso);
            limpiarPermisos();
            listaRoles();
        }
        private void btnEliminarPermisos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value);
            DialogResult resultado = MessageBox.Show("Está a punto de ELIMINAR un registros. ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                registro.elimiarPermiso(id);
                limpiarPermisos();
                listaRoles();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            string nombre = this.dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            
            int id = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value);
            string cadena = Convert.ToString(Interaction.InputBox($"ingrese la nueva fecha de Vencimiento \nPara el permiso: \n \n{nombre} \n \nRecuerde el formato de la fecha dd/MM/yyyy"));
            registro.ActualizarFechaRegistro(id, cadena);
            limpiarPermisos();
            listaRoles();
        }
        /*private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //e.Column.SortMode = DataGridViewColumnSortMode.NotSortable; // sin flecha para ordenar
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // llenar la tabla al espacio del datagridview
        }*/
        
        public void limpiarPermisos()
        {
            cboSeleccionarPermiso.SelectedValue = -1;
            mkdFechaVence.Text = string.Empty;

        }
       
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

        //
        // tab configuracion del password
        //
        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(txtMinCaracter.Text);
            int max = Convert.ToInt32(txtMaxCaracter.Text);
            bool mayu = chkMayusMinus.Checked;
            bool num = chkNumLetras.Checked;
            bool esp = chkCaracterEspecial.Checked;

             configure.Configuracion(min, max, mayu, num, esp);

        }
        //
        // Tab Bolqueos de usuarios
        //
        private void btnGuardarBloqueos_Click(object sender, EventArgs e)
        {
            string nombre = this.dgvListaUsuarios.SelectedRows[0].Cells[3].Value.ToString();

            int id = Convert.ToInt32(this.dgvListaUsuarios.SelectedRows[0].Cells[0].Value);
            string estado = Convert.ToString(Interaction.InputBox($"Realizará cambios en el estado del \nUsuario: \n \n{nombre} \n \nColoque el estado que desee para el usuario \n0 = bloqueado, 1 = activo"));
            registro.bloquearUsuario(id, estado);
            registro.LimpiarControlesEnTabPage(tabBloqueos);
            dgvListaUsuarios.DataSource = tabla.ListarUsuarios();
        }

    }
}