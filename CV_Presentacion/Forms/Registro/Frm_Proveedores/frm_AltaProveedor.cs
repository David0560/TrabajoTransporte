using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios.Entidades;
using CL_Negocios;
using CL_Servicios.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CV_Presentacion.Forms.Frm_Proveedores
{
    public partial class frm_AltaProveedor : Form
    {
        private CL_Proveedores guardoproveedores;
        public frm_AltaProveedor()
        {
            InitializeComponent();
            guardoproveedores = new CL_Proveedores();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedores = new Proveedores

                {

                    NombreEmpresa = txtNombreEmpresa.Text,
                    Contacto = txtContacto.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Ciudad = txtCiudad.Text,
                    Pais = txtPais.Text,
                    Calle = txtCalle.Text,
                    Numero = txtNumero.Text,
                    CP = int.Parse(txtCP.Text)
                };
                guardoproveedores.GuardarProveedores(proveedores);
                MessageBox.Show("Proveedor guardado exitosamente.");
                txtNombreEmpresa.Text = "";
                txtContacto.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                txtCiudad.Text = "";
                txtPais.Text = "";
                txtCalle.Text = "";
                txtNumero.Text = "";
                txtCP.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Proovedor: " + ex.Message);
            }
        }
    }
}