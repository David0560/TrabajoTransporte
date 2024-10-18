using CL_Negocios;
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

namespace CV_Presentacion.Frm_Unidades
{
    public partial class frm_ModificarVehiculos : Form
    {
        private CL_administrarComboBox administradorCombo = new CL_administrarComboBox();
        private CL_Vehiculos administradorVehiculos;
        DataTable dtvehiculos;
        public frm_ModificarVehiculos()
        {
            InitializeComponent();
            administradorVehiculos = new CL_Vehiculos();
        }

        

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox10.Text.Trim().ToLower();
            lsbPatente.Items.Clear(); // Limpiar resultados anteriores

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                lsbPatente.Visible = false; // Ocultar el ListBox si no hay texto
                return; // No hacer nada si el textbox está vacío
            }


            {
                dtvehiculos = administradorVehiculos.ObtenerVehículosPorPatente(textoBusqueda);

                if (dtvehiculos != null && dtvehiculos.Rows.Count > 0)
                {
                    lsbPatente.Visible = true; // Mostrar el ListBox
                    foreach (DataRow fila in dtvehiculos.Rows)
                    {
                        lsbPatente.Items.Add(fila["Dominio"].ToString());
                    }
                }
                else
                {
                    lsbPatente.Visible = false; // Ocultar si no hay resultados
                }

            }
        }

        private void lsbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lsbPatente.SelectedItem != null)
            {
                string vehiculoSeleccionado = lsbPatente.SelectedItem.ToString();

                DataRow[] filasEncontradas;

                filasEncontradas = dtvehiculos.Select($"Dominio = '{vehiculoSeleccionado}'");
                
                if (filasEncontradas.Length > 0)
                {
                    DataRow fila = filasEncontradas[0]; // Tomamos el primer resultado

                    lblid.Text = (fila["id"].ToString());
                    txtMarca.Text = fila["Marca"].ToString();
                    txtModelo.Text = fila["Modelo"].ToString();
                    txtMarcaMotor.Text = fila["MarcaMotor"].ToString();
                    txtNroMotor.Text = fila["NumeroMotor"].ToString();
                    txtMarcaChasis.Text = fila["MarcaChasis"].ToString();
                    txtNroChasis.Text = fila["NumeroChasis"].ToString();
                    txtDominio.Text = fila["Dominio"].ToString();
                    int cant = Convert.ToInt32(fila["CantidadPlazas"]);
                    numericUpDownPlaza.Value = cant;
                    txtKms.Text = fila["Km"].ToString();
                    cboCombustible.Text = fila["id_combustible"].ToString();
                    txtKms.Text = fila["Km"].ToString();
                    txtTipo.Text = fila["Tipo"].ToString();
                    txtEstado.Text = fila["Estado"].ToString();
              
                }
            }
        }
    }
}

