using CL_Negocios.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Frm_Empleados
{
    public partial class frm_ModificarEmpleados : Form
    {
        private CL_AdministrarEmpleados cl_AdministrarEmpleados;
        DataTable dtEmpleados;
        public frm_ModificarEmpleados()
        {
            InitializeComponent();
            lsbEmpleado.Visible = false;
            cl_AdministrarEmpleados = new CL_AdministrarEmpleados();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
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
                        lsbEmpleado.Items.Add(fila["apellido"].ToString());
                    }
                }
                else
                {
                    lsbEmpleado.Visible = false; // Ocultar si no hay resultados
                }
            }
         
             
            }
        }
    


