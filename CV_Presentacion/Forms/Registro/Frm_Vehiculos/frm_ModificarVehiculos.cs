﻿using CapaServicios;
using CL_Negocios;
using CL_Negocios.Empleados;
using CL_Negocios.Entidades;
using CL_Servicios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CV_Presentacion.Frm_Unidades
{
    public partial class frm_ModificarVehiculos : Form
    {
        private CL_administrarComboBox administradorCombo = new CL_administrarComboBox();
        private CL_Vehiculos administradorVehiculos;
        private CS_servicios servicios = new CS_servicios();
        DataTable dtvehiculos;
        DataTable dtVTV;
      
        public frm_ModificarVehiculos()
        {
            InitializeComponent();
            administradorVehiculos = new CL_Vehiculos();
        }



        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();
            lsbPatente.Items.Clear(); // Limpiar resultados anteriores

            if (string.IsNullOrEmpty(textoBusqueda))
            {
              //  lsbPatente.Visible = false; // Ocultar el ListBox si no hay texto
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

       
        private void frm_ModificarVehiculos_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtMarcaMotor.Enabled = true;
            txtNroMotor.Enabled = true;
            txtMarcaChasis.Enabled = true;
            txtNroChasis.Enabled = true;
            txtDominio.Enabled = true;
            txtKms.Enabled = true;
            numericUpDownPlaza.Enabled = true;
            cboCombustible.Enabled = true;
            txtTipo.Enabled = true;
            txtEstado.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void lsbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

            {
                if (lsbPatente.SelectedItem != null)
                {
                
                    string vehiculoSeleccionado = lsbPatente.SelectedItem.ToString();

                    // Buscar en la tabla de vehículos
                    DataRow[] filasVehiculos = dtvehiculos.Select($"Dominio = '{vehiculoSeleccionado}'");

                    if (filasVehiculos.Length > 0)
                    {
                        DataRow filaVehiculo = filasVehiculos[0]; // Tomamos el primer resultado
                        txtBuscar.Text = filaVehiculo["Dominio"].ToString();
                     
                            lsbPatente.Items.Clear();
                        txtMarca.Enabled = false;
                        txtModelo.Enabled = false;
                        txtMarcaMotor.Enabled = false;
                        txtNroMotor.Enabled = false;
                        txtMarcaChasis.Enabled = false;
                        txtNroChasis.Enabled = false;
                        txtDominio.Enabled = false;
                        txtKms.Enabled = false;
                        numericUpDownPlaza.Enabled = false;
                        cboCombustible.Enabled = false;
                        txtTipo.Enabled = false;
                        txtEstado.Enabled = false;
                        


                            // Llenar los datos del vehículo
                        lblid.Text = filaVehiculo["id"].ToString();
                       mskIngreso.Text = filaVehiculo["FechaAlta"].ToString();
                        txtMarca.Text = filaVehiculo["Marca"].ToString();
                        txtModelo.Text = filaVehiculo["Modelo"].ToString();
                        txtMarcaMotor.Text = filaVehiculo["MarcaMotor"].ToString();
                        txtNroMotor.Text = filaVehiculo["NumeroMotor"].ToString();
                        txtMarcaChasis.Text = filaVehiculo["MarcaChasis"].ToString();
                        txtNroChasis.Text = filaVehiculo["NumeroChasis"].ToString();
                        txtDominio.Text = filaVehiculo["Dominio"].ToString();

                        int cant = Convert.ToInt32(filaVehiculo["CantidadPlazas"]);
                        numericUpDownPlaza.Value = cant;
                        txtKms.Text = filaVehiculo["Km"].ToString();
                            int combustible = Convert.ToInt32(filaVehiculo["id_combustible"]);
                            string mostrarcombustible;

                            switch (combustible)
                            {
                                case 1:
                                    mostrarcombustible = "Diesel";
                                    break;
                                case 2:
                                    mostrarcombustible = "Diesel Premium";
                                    break;
                                case 3:
                                    mostrarcombustible = "Biodiesel";
                                    break;
                                default:
                                    mostrarcombustible = "Desconocido"; // Valor por defecto si no coincide
                                    break;
                            }
                            cboCombustible.Text = mostrarcombustible;
                            txtTipo.Text = filaVehiculo["Tipo"].ToString();
                        txtEstado.Text = filaVehiculo["Estado"].ToString();

                        // Obtener datos de VTV
                        dtVTV = administradorVehiculos.ObtenerVehículosPorVTV(lblid.Text); // Llama a la capa lógica

                        if (dtVTV != null && dtVTV.Rows.Count > 0)
                        {
                            DataRow filaVTV = dtVTV.Rows[0]; // Tomamos el primer resultado

                            // Llenar las fechas de VTV
                            if (filaVTV["FechaOtorgado"] != DBNull.Value)
                            {
                                mskFechaOtorgada.Text = Convert.ToDateTime(filaVTV["FechaOtorgado"]).ToString("dd/MM/yyyy");
                            }

                            if (filaVTV["FechaVencimiento"] != DBNull.Value)
                            {
                                mskFechaVencimiento.Text = Convert.ToDateTime(filaVTV["FechaVencimiento"]).ToString("dd/MM/yyyy");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos de VTV para el vehículo seleccionado.");
                        }
                    }
                }
            }
        }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblid.Text) || !int.TryParse(lblid.Text, out int id))
                    throw new ArgumentException("ID inválido.");
                // Capturamos los valores ingresados por el usuario
              //  int id = Convert.ToInt32(lblid.Text);
                string dominio = txtDominio.Text;
                string tipo = txtTipo.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string marcaMotor = txtMarcaMotor.Text;
                string numeroMotor = txtNroMotor.Text;
                string marcaChasis = txtMarcaChasis.Text;
                string numeroChasis = txtNroChasis.Text;
                string estado = txtEstado.Text;
                int cantidadPlazas = (int)numericUpDownPlaza.Value;
                decimal km = decimal.Parse(txtKms.Text);
                int idCombustible = 0;

                 switch (cboCombustible.Text)
    {
        case "Diesel":
            idCombustible = 1;
            break;
        case "Diesel Premium":
            idCombustible = 2;
            break;
        case "Biodiesel":
            idCombustible = 3;
            break;
        default:
            throw new ArgumentException("Seleccione un tipo de combustible válido.");
    }


                // Agregar la información de la verificación (VTV)
                DateTime fechaOtorgadoVTV = DateTime.Parse(mskFechaOtorgada.Text);
                DateTime fechaVencimientoVTV = DateTime.Parse(mskFechaVencimiento.Text);

                // Crear una instancia de la clase Vehiculo
                var vehiculo = new Vehiculo
                {
                    Id = id, // Asignamos el ID del vehículo
                    Dominio = dominio,
                    Tipo = tipo,
                    Marca = marca,
                    Modelo = modelo,
                    MarcaMotor = marcaMotor,
                    NumeroMotor = numeroMotor,
                    MarcaChasis = marcaChasis,
                    NumeroChasis = numeroChasis,
                    Estado = estado,
                    CantidadPlazas = cantidadPlazas,
                    Km = km,
                    IdCombustible = idCombustible,
                    FechaOtorgadoVTV = fechaOtorgadoVTV,
                    FechaVencimientoVTV = fechaVencimientoVTV
                };

                // Instanciamos la clase de negocio y guardamos el vehículo
            
                administradorVehiculos.ModificarVehiculos(vehiculo);

                // Modificar la verificación
                administradorVehiculos.ModificarVerificacion(vehiculo.Id, vehiculo.FechaOtorgadoVTV, vehiculo.FechaVencimientoVTV);

                MessageBox.Show("Vehículo y verificación editados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de datos incorrecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            servicios.LimpiarFormulario(this);
        }

        private void cboCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

                

        
            
        
        



