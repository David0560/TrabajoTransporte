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
       
        public frm_AltaProveedor()
        {
            InitializeComponent();
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string NombreEmpresa = txtNombreEmpresa.Text;
                   string  Contacto = txtContacto.Text;
                int Telefono = int.Parse(txtTelefono.Text);
                string Email = txtEmail.Text;
                string Ciudad = txtCiudad.Text;
                string Pais = txtPais.Text;
                string  Calle = txtCalle.Text;
                string Numero = txtNumero.Text;
                int CP = int.Parse(txtCP.Text);
            Proveedores nuevoProveedor = new Proveedores(NombreEmpresa, Contacto, Telefono, Email, Ciudad, Pais, Calle, Numero, CP);
                CL_Proveedores guardoproveedor = new CL_Proveedores();
                guardoproveedor.GuardarProveedores(nuevoProveedor);
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

        private void frm_AltaProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}