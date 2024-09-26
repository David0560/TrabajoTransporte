using CapaServicios;
using CL_Negocios.ActualizarRegistros;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Documentacion
{
    public partial class frm_ActualizarVtv : Form
    {
        CL_AdministrarRegistros Registros = new CL_AdministrarRegistros();
        CS_servicios servicio = new CS_servicios();

        public frm_ActualizarVtv()
        {
            InitializeComponent();
        }

        private void dgvVerificacionVtv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el valor de la celda seleccionada
                var Nombre = dgvVerificacionVtv.Rows[e.RowIndex].Cells["Nombre"].Value;
                var Dominio = dgvVerificacionVtv.Rows[e.RowIndex].Cells["Dominio"].Value;
                var Modelo = dgvVerificacionVtv.Rows[e.RowIndex].Cells["Modelo"].Value;
                var vence = dgvVerificacionVtv.Rows[e.RowIndex].Cells["FechaVencimiento"].Value;

                // Asigna el valor al Label
                lblUnidad.Text = Nombre?.ToString() ?? "Sin valor"; // Maneja nulos
                lblDominio.Text = Dominio?.ToString() ?? "Sin valor"; // Maneja nulos
                lblModelo.Text = Modelo?.ToString() ?? "Sin valor"; // Maneja nulos
                lblFechaV.Text = vence?.ToString() ?? "Sin valor"; // Maneja nulos
            }
        }

        private void frm_ActualizarVtv_Load(object sender, EventArgs e)
        {
            servicio.estiloDataGrid(dgvVerificacionVtv);
            dgvVerificacionVtv.DataSource = Registros.CargarRegistrosVehiculos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // captura los datos del registro
            var Nombre = dgvVerificacionVtv.SelectedRows[0].Cells["Nombre"].Value;
            var Apellido = dgvVerificacionVtv.SelectedRows[0].Cells["Apellido"].Value;

            DialogResult resultado = MessageBox.Show($"Se encuetra a punto de cambiar el registro de\n \n {Nombre}  {Apellido} \n \n ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                int id = Convert.ToInt32(this.dgvVerificacionVtv.SelectedRows[0].Cells[0].Value);
                DateTime fechaO = Convert.ToDateTime(mskOtorgado.Text);
                DateTime fechaV = Convert.ToDateTime(mskVence.Text);

                if (Registros.ActualizarVtv(id, fechaO, fechaV))
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    servicio.LimpiarControlesForm(this);
                    dgvVerificacionVtv.DataSource = Registros.CargarRegistrosVehiculos();
                }
                else
                {
                    MessageBox.Show("Error: revise los campos");
                }
            }
        }
    }
}
