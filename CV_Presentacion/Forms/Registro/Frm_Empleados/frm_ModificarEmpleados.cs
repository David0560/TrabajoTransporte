using CapaServicios;
using CL_Negocios;
using CL_Negocios.Empleados;
using CL_Negocios.Entidades;
using CV_Presentacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Frm_Empleados
{
    public partial class frm_ModificarEmpleados : Form
    {
        private CL_AdministrarEmpleados cl_AdministrarEmpleados;
        private DataTable dtEmpleados;
        private CL_administrarComboBox combo = new CL_administrarComboBox();
        private CS_servicios servicios = new CS_servicios();
        public frm_ModificarEmpleados()
        {
            InitializeComponent();
            lsbEmpleado.Visible = false;
            cl_AdministrarEmpleados = new CL_AdministrarEmpleados();
            lsbEmpleado.SelectedIndexChanged += lsbEmpleado_SelectedIndexChanged;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores ingresados por el usuario
                int id = Convert.ToInt32(lblId.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellid.Text;
                string fechaNacimiento = mtbFecha.Text;
                string numeroDocumento = txtNumeroDNI.Text;
                string calle = txtDireccion.Text;
                string numeroDomicilio = txtNumeroDomicilio.Text;
                string email = txtEmail.Text;

                int telefono = Convert.ToInt32(txtTelefono.Text);
                int idDocumentoIdent = Convert.ToInt32(cbTipoDNI.SelectedValue);
                int idSexo = Convert.ToInt32(cbSexo.SelectedValue);
                int idLocalidad = Convert.ToInt32(cbCiudad.SelectedValue);
                int idTarea = Convert.ToInt32(cboTarea.SelectedValue);

                // Crear una instancia de la clase Persona con los datos capturados
                Persona modificopersona = new Persona(id, nombre, apellido, DateTime.Parse(fechaNacimiento), idDocumentoIdent, numeroDocumento, idSexo, idLocalidad, calle, Convert.ToInt32(numeroDomicilio), email, telefono, idTarea);

                // Instanciamos la clase CL_AdministrarEmpleados y guardamos el nuevo empleado
                CL_AdministrarEmpleados administradorEmpleados = new CL_AdministrarEmpleados();
                administradorEmpleados.ModificarPersona(modificopersona);

                MessageBox.Show("Empleado editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            servicios.LimpiarFormulario(this);
            servicios.BloquearControl(this);
            txtBuscar.Enabled = true;
            rbDni.Enabled = true;
            rbNomAp.Enabled = true;
            lsbEmpleado.Text = "";
            lsbEmpleado.Enabled = true;
            
            


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (rbNomAp.Checked)
            {
                string textoBusqueda = txtBuscar.Text.Trim().ToLower();
                lsbEmpleado.Items.Clear(); // Limpiar resultados anteriores

                if (string.IsNullOrEmpty(textoBusqueda))
                {
                    lsbEmpleado.Visible = false; // Ocultar el ListBox si no hay texto
                    return; // No hacer nada si el textbox está vacío
                }

                dtEmpleados = cl_AdministrarEmpleados.ObtenerEmpleadoPorApellido(textoBusqueda);

                if (dtEmpleados != null && dtEmpleados.Rows.Count > 0)
                {
                    lsbEmpleado.Visible = true; // Mostrar el ListBox
                    foreach (DataRow fila in dtEmpleados.Rows)
                    {
                        string nombreCompleto = fila["apellido"].ToString();
                        lsbEmpleado.Items.Add(nombreCompleto);

                    }
                }
                else
                {
                    lsbEmpleado.Visible = false; // Ocultar si no hay resultados
                }
            }
            else if (rbDni.Checked)
            {
                string dni = txtBuscar.Text.Trim().ToLower();
                lsbEmpleado.Items.Clear(); // Limpiar resultados anteriores

                if (string.IsNullOrEmpty(dni))
                {
                    lsbEmpleado.Visible = false; // Ocultar el ListBox si no hay texto
                    return; // No hacer nada si el textbox está vacío
                }

                dtEmpleados = cl_AdministrarEmpleados.ObtenerEmpleadoPorDNI(dni);
                if (dtEmpleados != null && dtEmpleados.Rows.Count > 0)
                {
                    lsbEmpleado.Visible = true; // Mostrar el ListBox
                    foreach (DataRow fila in dtEmpleados.Rows)
                    {
                        string apedni = fila["numero_ident"].ToString();
                        lsbEmpleado.Items.Add(apedni);

                    }
                }
                else
                {
                    lsbEmpleado.Visible = false; // Ocultar si no hay resultados
                }
            }
        }

        private void rbNomAp_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void rbDni_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void lsbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lsbEmpleado.SelectedItem != null)
            {
             
                string empleadoSeleccionado = lsbEmpleado.SelectedItem.ToString();
               
                DataRow[] filasEncontradas;

                if (rbNomAp.Checked) // Suponiendo que tienes un RadioButton llamado rbBuscarPorEmpresa
                {
                    // Busca el empleado en el DataTable por Apellido
                    filasEncontradas = dtEmpleados.Select($"apellido = '{empleadoSeleccionado}'");
                    servicios.BloquearControl(this);
                    rbDni.Enabled = true;
                    rbNomAp.Enabled = true;
                    txtBuscar.Enabled = true; 
                    btnEliminar.Enabled = true;
               btnModificar.Enabled = true;
                    txtBuscar.Text = empleadoSeleccionado;
                  

                }
                else if (rbDni.Checked) // Suponiendo que tienes un RadioButton llamado rbBuscarPorContacto
                {
                    // Busca el empleado en el DataTable por número documento
                    filasEncontradas = dtEmpleados.Select($"numero_ident = '{empleadoSeleccionado}'");
                    servicios.BloquearControl(this);
                    txtBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    txtBuscar.Text = empleadoSeleccionado;
                }
                else
                {
                    return; // Si no está seleccionado ninguno, salimos
                }

                if (filasEncontradas.Length > 0)
                {
                    lsbEmpleado.Visible = false;
                    DataRow fila = filasEncontradas[0]; // Tomamos el primer resultado

                    int id_sexo = Convert.ToInt32(fila["id_sexo"].ToString());
                    int tipo_dni = Convert.ToInt32( fila["id_documento_ident"].ToString());

                    lblId.Text = fila["id"].ToString();
                    txtNombre.Text = fila["nombre"].ToString();
                    txtApellid.Text = fila["apellido"].ToString();
                    mtbFecha.Text = fila["fecha_nacimiento"].ToString();
                    txtNumeroDNI.Text = fila["numero_ident"].ToString();
                 txtTelefono.Text = fila["Telefono"].ToString();
                    txtEmail.Text = fila["email"].ToString();
                    txtDireccion.Text = fila["calle"].ToString();
                    txtNumeroDomicilio.Text = fila["numero_domicilo"].ToString();
                   mtbFecha.Text = fila["fecha_nacimiento"].ToString();
                 if( id_sexo == 1)
                    {
                        cbSexo.Text = "Mujer";
                    }
                    else
                    {
                        cbSexo.Text = "Hombre";
                    }
                    if (tipo_dni == 1)
                    {
                        cbTipoDNI.Text = "DNI";
                    }
                    else
                    {
                        cbTipoDNI.Text = "Elija el tipo de DNI";
                    }

                }
            }
        }

        private void frm_ModificarEmpleados_Load(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboTarea, "spVerTareas");
            combo.seleccionCombo(cbTipoDNI, "spVerDocumentoIdent");
            combo.seleccionCombo(cbSexo, "spVerSexo");
            combo.seleccionCombo(cbCiudad, "spVerCiudad");
        }

        private void txtDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedValue != null)
            {
                listaPermiso();
            }
        }
        void listaPermiso()
        {
            if (cbCiudad.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cbCiudad.SelectedValue.ToString(), out valorSeleccionado))
                {
                    int valor = Convert.ToInt32(cbCiudad.SelectedValue);
                    combo.seleccionarLocalidad(cbLocalidad, valor);

                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            servicios.DesbloquearControl(this);
            rbDni.Enabled = false;
            rbNomAp.Enabled = false;
            btnModificar.Enabled = false;
            txtBuscar.Enabled = false;
            lsbEmpleado.Enabled = false;
            btnEliminar.Enabled = false;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
      "¿Estás seguro de que deseas eliminar este empleado?",
      "Confirmar Eliminación",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (int.TryParse(lblId.Text, out int id))
                    {
                        CL_AdministrarEmpleados eliminarempleado = new CL_AdministrarEmpleados();
                        eliminarempleado.ELiminarEmpleado(id);
                        MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView
                        // Aquí deberías recargar los datos para que reflejen la eliminación

                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lsbEmpleado.Items.Clear(); // Limpiar resultados anteriores

        }
    }
}
            
       
        