using CapaServicios;
using CL_Negocios.ActualizarRegistros;
using CL_Negocios.Entidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Documentacion
{
    public partial class frm_ActualizarRegistroCond : Form
    {
        CL_AdministrarRegistros Registros = new CL_AdministrarRegistros();
        CS_servicios servicio = new CS_servicios();

        public frm_ActualizarRegistroCond()
        {
            InitializeComponent();
        }

        private void frm_ActualizarRegistroCond_Load(object sender, EventArgs e)
        {
            servicio.parametrosDataGridView(dgvRegistroCond);
            dgvRegistroCond.DataSource = Registros.CargarRegistrosCond();

            dgvRegistroCond.CurrentCell = null;
        }

        private void dgvRegistroCond_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtén el valor de la celda seleccionada
                var Nombre = dgvRegistroCond.Rows[e.RowIndex].Cells["Nombre"].Value;
                var Apellido = dgvRegistroCond.Rows[e.RowIndex].Cells["Apellido"].Value;
                var numero = dgvRegistroCond.Rows[e.RowIndex].Cells["Numero"].Value;
                var vence = dgvRegistroCond.Rows[e.RowIndex].Cells["FechaVencimiento"].Value;

                // Asigna el valor al Label
                lblNom.Text = Nombre?.ToString() ?? "Sin valor"; // Maneja nulos
                lblApe.Text = Apellido?.ToString() ?? "Sin valor"; // Maneja nulos
                lblNumero.Text = numero?.ToString() ?? "Sin valor"; // Maneja nulos
                lblFecha.Text = vence?.ToString() ?? "Sin valor"; // Maneja nulos
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // captura los datos del registro
            var Nombre = dgvRegistroCond.SelectedRows[0].Cells["Nombre"].Value;
            var Apellido = dgvRegistroCond.SelectedRows[0].Cells["Apellido"].Value;

            DialogResult resultado = MessageBox.Show($"Se encuetra a punto de cambiar el registro de\n \n {Nombre}  {Apellido} \n \n ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                int id = Convert.ToInt32(this.dgvRegistroCond.SelectedRows[0].Cells[0].Value);
                DateTime fechaO = Convert.ToDateTime(mskOtorgado.Text);
                DateTime fechaV = Convert.ToDateTime(mskVence.Text);

                if (Registros.ActualizarRegistroCond(id, fechaO, fechaV))
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    servicio.LimpiarControlesForm(this);
                    dgvRegistroCond.DataSource = Registros.CargarRegistrosCond();
                }
                else
                {
                    MessageBox.Show("Error: revise los campos");
                }
            }
        }

        private void dgvRegistroCond_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas en el DataGridView
            if (dgvRegistroCond.SelectedRows.Count > 0)
            {
                // Si hay una fila seleccionada, habilita los controles
                grbActualizar.Enabled = true; // o cualquier control que estés utilizando
            }
            else
            {
                // Si no hay fila seleccionada, deshabilita los controles
                grbActualizar.Enabled = false; // o cualquier control que estés utilizando
            }
        }
    }
}
