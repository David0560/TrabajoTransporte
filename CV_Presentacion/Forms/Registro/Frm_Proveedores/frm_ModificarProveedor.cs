using CapaServicios.Entidades;
using CL_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Frm_Proveedores
{
    public partial class frm_ModificarProveedor : Form
    {
        private CL_Proveedores cL_Proveedores;
        public frm_ModificarProveedor()
        {
            InitializeComponent();
            cL_Proveedores = new CL_Proveedores();
            CargarProveedoresPorEmpresa();
            CargarProveedoresPorNombre();


        }

        private void frm_ModificarProveedor_Load(object sender, EventArgs e)
        {
            rb1.Checked = true;
            CargarProveedoresPorEmpresa();



        }
        private void CargarProveedoresPorEmpresa()
        {
            // Crear una instancia de la capa lógica


            // Obtener el DataTable
            DataTable proveedores = cL_Proveedores.ObtenerProveedoresPorEmpresa();
            // Asignar el DataTable al ComboBox
            comboBox1.DataSource = proveedores;
            comboBox1.DisplayMember = "Empresa"; //ColumnaEmpresa
            /*  foreach (DataRow fila in proveedores.Rows)
              {
                  int idPorEmpresa = Convert.ToInt32(fila["Id"]);
                  lblId.Text = idPorEmpresa.ToString();
              }
              */
        }
        private void CargarProveedoresPorNombre()
        {
            // Crear una instancia de la capa lógica


            // Obtener el DataTable
            DataTable proveedores = cL_Proveedores.ObtenerProveedoresPorNombre();
            // Asignar el DataTable al ComboBox
            comboBox1.DataSource = proveedores;
            comboBox1.DisplayMember = "Contacto"; //ColumnaEmpresa
            /*     foreach (DataRow fila in proveedores.Rows)
                 {
                     int idPorNombre = Convert.ToInt32(fila["Id"]);
                     lblId.Text = idPorNombre.ToString();
                 }
            */


        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

            CargarProveedoresPorNombre();

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            CargarProveedoresPorEmpresa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                int idEmpresa = int.Parse(lblId.Text);
                DataTable proveedores = cL_Proveedores.TraerProovedoresIdEmpresa(idEmpresa);
                if (proveedores.Rows.Count > 0)
                {
                    // Suponiendo que las columnas en el DataTable son "Nombre", "Contacto", etc.
                    DataRow fila = proveedores.Rows[0];
                    txtNombreEmpresa.Text = fila["Empresa"].ToString();
                    txtContacto.Text = fila["Contacto"].ToString();
                    txtTelefono.Text = fila["Teléfono"].ToString();
                    txtEmail.Text = fila["Email"].ToString();
                    txtCiudad.Text = fila["Ciudad"].ToString();
                    txtCalle.Text = fila["Calle"].ToString();
                    txtCP.Text = fila["CódigoPostal"].ToString();
                    txtPais.Text = fila["País"].ToString();
                    txtNumero.Text = fila["Numero"].ToString();
                }
            }
            if (rb2.Checked == true)
            {
                int idContacto = int.Parse(lblId.Text);
                DataTable proveedores = cL_Proveedores.TraerProovedoresIdContacto(idContacto);
                if (proveedores.Rows.Count > 0)
                {
                    // Suponiendo que las columnas en el DataTable son "Nombre", "Contacto", etc.
                    DataRow fila = proveedores.Rows[0];
                    txtNombreEmpresa.Text = fila["Empresa"].ToString();
                    txtContacto.Text = fila["Contacto"].ToString();
                    txtTelefono.Text = fila["Teléfono"].ToString();
                    txtEmail.Text = fila["Email"].ToString();
                    txtCiudad.Text = fila["Ciudad"].ToString();
                    txtCalle.Text = fila["Calle"].ToString();
                    txtCP.Text = fila["CódigoPostal"].ToString();
                    txtPais.Text = fila["País"].ToString();
                    txtNumero.Text = fila["Numero"].ToString();
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                int idPorNombre = Convert.ToInt32(selectedRow["Id"]); // Obtiene el ID
                lblId.Text = idPorNombre.ToString(); // Asigna el ID al label
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
                int id = Convert.ToInt32(lblId.Text);
               

                cL_Proveedores.ModificarProveedores(id, txtNombreEmpresa.Text, txtContacto.Text, txtTelefono.Text, txtEmail.Text, txtCiudad.Text, txtPais.Text, txtCalle.Text, txtNumero.Text, int.Parse(txtCP.Text));
                MessageBox.Show("Proveedor modificado exitosamente.");
                txtNombreEmpresa.Text = "";
                txtContacto.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                txtCiudad.Text = "";
                txtPais.Text = "";
                txtCalle.Text = "";
                txtNumero.Text = "";
                txtCP.Text = "";
            CargarProveedoresPorEmpresa();


        }
    }
}
    


    


    

