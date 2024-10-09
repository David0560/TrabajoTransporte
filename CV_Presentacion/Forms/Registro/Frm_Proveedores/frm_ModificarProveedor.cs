using CapaServicios.Entidades;
using CL_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Forms.Frm_Proveedores
{
    public partial class frm_ModificarProveedor : Form
    {

        public frm_ModificarProveedor()
        {
            InitializeComponent();
            txtBuscar.TextChanged += new EventHandler(txtBuscar_TextChanged);
            rbEmpresa.Checked = true;
        }

        private void CargarProveedores()
        {
            CL_Proveedores clProveedores = new CL_Proveedores();
            DataTable dtProveedores;
             

            string textoBuscar = txtBuscar.Text;

            if (rbEmpresa.Checked) // Si el RadioButton de empresa está seleccionado
            {
                dtProveedores = clProveedores.ObtenerProveedoresPorEmpresa(textoBuscar);
            }
            else if (rbContacto.Checked) // Si el RadioButton de contacto está seleccionado
            {
                dtProveedores = clProveedores.ObtenerProveedoresPorContacto(textoBuscar);
            }
            else
            {
                dtProveedores = new DataTable(); // Si no hay selección, no se muestra nada

            }
         

            dataGridViewProveedores.DataSource = dtProveedores;
        }
        private void frm_ModificarProveedor_Load(object sender, EventArgs e)
        {



        }



        private void rb2_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewProveedores.Rows[e.RowIndex];
                // Asignar los valores de las celdas a los TextBox
                labelId.Text = (row.Cells["Id"].Value.ToString());
                txtNombreEmpresa.Text = row.Cells["Empresa"].Value.ToString();
                txtContacto.Text = row.Cells["Contacto"].Value.ToString();
                txtTelefono.Text = row.Cells["Teléfono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
                txtPais.Text = row.Cells["País"].Value.ToString();
                txtCalle.Text = row.Cells["Calle"].Value.ToString();
                txtNumero.Text = row.Cells["Numero"].Value.ToString();
                txtCP.Text = row.Cells["CódigoPostal"].Value.ToString();
                
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled=false;
           txtNombreEmpresa.Enabled = true;
            txtContacto.Enabled = true;
           txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtCiudad.Enabled = true;
            txtPais.Enabled = true;
            txtCalle.Enabled = true;
            txtNumero.Enabled = true;
            txtCP.Enabled = true;
                txtTelefono.Enabled = true;
            btnGuardar.Enabled = true;
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //  V<
            try
            {
                int Id;
                Id = Convert.ToInt32(labelId.Text);
                string NombreEmpresa = txtNombreEmpresa.Text;
                string Contacto = txtContacto.Text;
                int Telefono = int.Parse(txtTelefono.Text);
                string Email = txtEmail.Text;
                string Ciudad = txtCiudad.Text;
                string Pais = txtPais.Text;
                string Calle = txtCalle.Text;
                string Numero = txtNumero.Text;
                int CP = int.Parse(txtCP.Text);
                Proveedores modificoproveeedor = new Proveedores(Id, NombreEmpresa, Contacto, Telefono, Email, Ciudad, Pais, Calle, Numero, CP);
                CL_Proveedores guardoproveedor = new CL_Proveedores();
                guardoproveedor.ModificarProveedor(modificoproveeedor);
                MessageBox.Show("Provedor modificado");
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;

                CargarProveedores();

           

                txtNombreEmpresa.Enabled = false;
                txtContacto.Enabled = false;
                txtTelefono.Enabled = false;
                txtEmail.Enabled = false;
                txtCiudad.Enabled = false;
                txtPais.Enabled = false;
                txtCalle.Enabled = false;
                txtNumero.Enabled = false;
                txtCP.Enabled = false; 
                txtTelefono.Enabled = false;
            

               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Proovedor: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
         "¿Estás seguro de que deseas eliminar este proveedor?",
         "Confirmar Eliminación",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (int.TryParse(labelId.Text, out int id))
                    {
                        CL_Proveedores eliminarProveedor = new CL_Proveedores();
                        eliminarProveedor.ELiminarProveedores(id);
                        MessageBox.Show("Proveedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView
                        // Aquí deberías recargar los datos para que reflejen la eliminación
                        CargarProveedores(); // Suponiendo que tienes un método para cargar los datos
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("ID de proveedor no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


;
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}

    


    


    

