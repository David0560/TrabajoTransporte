using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //muestra la contraseña
        private void pbxMostrar_Click(object sender, EventArgs e)
        {
            pbxOcultar.BringToFront();
            txtPassword.PasswordChar = '\0';
        }
        //oculta la contraseña
        private void pbxOcultar_Click(object sender, EventArgs e)
        {
            pbxMostrar.BringToFront();
            txtPassword.PasswordChar = '*';
        }
    }
}
