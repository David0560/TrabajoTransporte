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
            if (dtProveedores.Columns.Contains("Id"))
            {
                dtProveedores.Columns.Remove("Id");
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
    }
}
    


    


    

