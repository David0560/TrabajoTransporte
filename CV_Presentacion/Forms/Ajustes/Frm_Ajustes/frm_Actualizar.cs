using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaServicios;
using CL_Negocios;
using CL_Negocios.Login;

namespace CV_Presentacion.Forms
{
    public partial class frm_Actualizar : Form
    {
        CL_AdministrarRecuperoPass validarpass = new CL_AdministrarRecuperoPass();
        public frm_Actualizar(string nombreUsuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
        }
        public frm_Actualizar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string NombreUsuario = lblNombreUsuario.Text;
            string contraActual = txtContraseñaActual.Text;
            string NuevaPass = txtNuevaContraseña.Text;
            string ValidarPass = txtRepetir.Text;
            //validar Pass
            if (NuevaPass == ValidarPass)
            {
                if (validarpass.ValidarNuevoPass(NombreUsuario, contraActual, NuevaPass))
                {
                    MessageBox.Show("Datos Guardados Exitosamente");
                }
                else
                {
                    MessageBox.Show("error al cargar los Datos");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Valores incompatibles.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}