using CapaServicios.Entidades;
using CD_ConexionDatos;
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
        private CL_Proveedores clProveedores;
        DataTable dtProveedores;
        public frm_ModificarProveedor()
        {
            InitializeComponent();

            rbEmpresa.Checked = true;
            lsbProveedores.Visible = false;
            clProveedores = new CL_Proveedores();
            lsbProveedores.SelectedIndexChanged += lsbProveedores_SelectedIndexChanged;
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
         

            string textoBusqueda = txtBuscar.Text.Trim().ToLower();
            lsbProveedores.Items.Clear(); // Limpiar resultados anteriores

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                lsbProveedores.Visible = false; // Ocultar el ListBox si no hay texto
                return; // No hacer nada si el textbox está vacío
            }

            if (rbEmpresa.Checked)
            {
                dtProveedores = clProveedores.ObtenerProveedoresPorEmpresa(textoBusqueda);

                if (dtProveedores != null && dtProveedores.Rows.Count > 0)
                {
                    lsbProveedores.Visible = true; // Mostrar el ListBox
                    foreach (DataRow fila in dtProveedores.Rows)
                    {
                        lsbProveedores.Items.Add(fila["Empresa"].ToString());
                    }
                }
                else
                {
                    lsbProveedores.Visible = false; // Ocultar si no hay resultados
                }
            }
            else if (rbContacto.Checked)
            {
                dtProveedores = clProveedores.ObtenerProveedoresPorContacto(textoBusqueda);

                if (dtProveedores != null && dtProveedores.Rows.Count > 0)
                {
                    lsbProveedores.Visible = true; // Mostrar el ListBox
                    foreach (DataRow fila in dtProveedores.Rows)
                    {
                        lsbProveedores.Items.Add(fila["Contacto"].ToString());
                    }
                }
                else
                {
                    lsbProveedores.Visible = false; // Ocultar si no hay resultados
                }
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
            lsbProveedores.Items.Clear(); // Limpiar resultados anteriores


            ;
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lsbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProveedores.SelectedItem != null)
            {
                string proveedorSeleccionado = lsbProveedores.SelectedItem.ToString();

                // Busca el proveedor en el DataTable
                DataRow[] filasEncontradas = dtProveedores.Select($"Empresa = '{proveedorSeleccionado}'");

                if (filasEncontradas.Length > 0)
                {
                    DataRow fila = filasEncontradas[0]; // Tomamos el primer resultado

                    labelId.Text = (fila["Id"].ToString());
                    txtNombreEmpresa.Text = fila["Empresa"].ToString();
                    txtContacto.Text = fila["Contacto"].ToString();
                    txtTelefono.Text = fila["Teléfono"].ToString();
                    txtEmail.Text = fila["Email"].ToString();
                    txtCiudad.Text = fila["Ciudad"].ToString();
                    txtPais.Text = fila["País"].ToString();
                    txtCalle.Text = fila["Calle"].ToString();
                    txtNumero.Text = fila["Numero"].ToString();
                    txtCP.Text = fila["CódigoPostal"].ToString();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    lsbProveedores.Items.Clear();
                    txtBuscar.Text = "";
                    }
            }
        
    }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    


    


    

