using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Negocios;


namespace CV_Presentacion
{
    public partial class frmLogin : Form
    {
        CL_administrarLogin login = new CL_administrarLogin();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int valor = login.UbicarUsuario(txtUsuario.Text.ToString(), txtPassword.Text.ToString());

            switch (valor)
            {
                case 1:
                    msgError("Usuario no encontrado");
                    //MessageBox.Show("No se encuentra usuario con este nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    break;

                case 2:
                    msgError("Password no ingresado o incorrecto");
                    //MessageBox.Show("El password no fue ingresado o es incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();

                    break;

                case 3:
                    MessageBox.Show("Usuario Bloqueado, Comuniquese con su administrador", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                    break;

                case 4:
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    menu.Show();
                    menu.FormClosed += CerrarSesion;
                    
                    break;

                default:
                    MessageBox.Show("Su Usuario se encuentra en reparación\nComuniquese con su administrador \n\n Muchas gracias.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        // metodo
        private void msgError(string msg)
        {
            lblError.Text ="ERROR: " + msg;
            lblError.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void lblRecupero_Click(object sender, EventArgs e)
        {
            frmRecuperarPassword contraseña = new frmRecuperarPassword();
            this.Hide();
            contraseña.Show();
        }
    }
}
