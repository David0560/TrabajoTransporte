using CL_Servicios.Entidades;
using System;
using System.Windows.Forms;
using CL_Negocios;

namespace CV_Presentacion.Forms.Registro.Frm_Vehiculos
{
    public partial class frm_AltaVehiculos : Form
    {
        private CL_administrarComboBox administradorCombo = new CL_administrarComboBox();
        private CL_Vehiculos administradorVehiculos;

        public frm_AltaVehiculos()
        {
            InitializeComponent();
            administradorVehiculos = new CL_Vehiculos(); // Instanciar la clase de la capa lógica
        }

        private void frm_AltaVehiculos_Load(object sender, EventArgs e)
        {
            mskIngreso.Text = DateTime.Now.ToShortDateString(); // Establecer la fecha actual en mskIngreso
            administradorCombo.CargarCombustibles(cboCombustible); // Cargar los datos de combustible en cboCombustible
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var vehiculo = new Vehiculo
                {
                    FechaAlta = DateTime.Parse(mskIngreso.Text),
                    Dominio = txtDominio.Text,
                    Tipo = txtTipo.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    MarcaMotor = txtMarcaMotor.Text,
                    NumeroMotor = txtNroMotor.Text,
                    MarcaChasis = txtMarcaChasis.Text,
                    NumeroChasis = txtNroChasis.Text,
                    Estado = txtEstado.Text,
                    CantidadPlazas = (int)numericUpDownPlaza.Value,
                    Km = decimal.Parse(txtKms.Text),
                    IdCombustible = (int)cboCombustible.SelectedValue,

                    // Agregar la información de la verificación (VTV)
                    FechaOtorgadoVTV = DateTime.Parse(mskFechaOtorgada.Text),
                    FechaVencimientoVTV = DateTime.Parse(mskFechaVencimiento.Text)
                };

                administradorVehiculos.GuardarVehiculo(vehiculo, vehiculo.FechaOtorgadoVTV, vehiculo.FechaVencimientoVTV);

                MessageBox.Show("Vehículo guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vehículo: " + ex.Message);
            }
        }

    }
}