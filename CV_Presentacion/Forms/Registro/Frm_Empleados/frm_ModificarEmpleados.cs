using CL_Negocios.Empleados;
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
        public frm_ModificarEmpleados()
        {
            InitializeComponent();
            lsbEmpleado.Visible = false;
            cl_AdministrarEmpleados = new CL_AdministrarEmpleados();
            lsbEmpleado.SelectedIndexChanged += lsbEmpleado_SelectedIndexChanged;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (rbNomAp.Checked)
            {
                string textoBusqueda = txtApellido.Text.Trim().ToLower();
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
                string dni = txtApellido.Text.Trim().ToLower();
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
            txtApellido.Text = "";
        }

        private void rbDni_CheckedChanged(object sender, EventArgs e)
        {
            txtApellido.Text = "";
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
                }
                else if (rbDni.Checked) // Suponiendo que tienes un RadioButton llamado rbBuscarPorContacto
                {
                    // Busca el empleado en el DataTable por número documento
                    filasEncontradas = dtEmpleados.Select($"numero_ident = '{empleadoSeleccionado}'");
                }
                else
                {
                    return; // Si no está seleccionado ninguno, salimos
                }

                if (filasEncontradas.Length > 0)
                {
                    DataRow fila = filasEncontradas[0]; // Tomamos el primer resultado

                   
                    txtNombre.Text = fila["nombre"].ToString();
                    txtApellid.Text = fila["apellido"].ToString();
                    mtbFecha.Text = fila["fecha_nacimiento"].ToString();
                    txtNumeroDNI.Text = fila["numero_ident"].ToString();
                 //   cbSexo.Text = fila["sexo"].ToString();
                    txtEmail.Text = fila["email"].ToString();
                    txtDireccion.Text = fila["calle"].ToString();
                    txtNumeroDomicilio.Text = fila["numero_domicilo"].ToString();
               
                }
            }
        }

        private void frm_ModificarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void txtDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }
    


