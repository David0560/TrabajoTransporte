using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CV_Presentacion
{
    public partial class frmLogin : Form
    {
        //ProdLogica logica_prod = new ProdLogica();


        public frmLogin()
        {
            InitializeComponent();
            picShowPass.BringToFront();
        }

        private int intentos = 0;
        private string usuario = "";

        #region MoverVentana  | Métodos para poder mover la ventana |
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MoverForm() //Método para mover la ventana del formulario por la pantalla libremente
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form_Login_MouseDown(object sender, MouseEventArgs e) //Evento al mantener el click izquierdo del mouse y moverlo
        {
            MoverForm();
        }
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm();
        }
        private void picBoxLogin_MouseDown(object sender, MouseEventArgs e) //Evento al mantener el click izquierdo del mouse y moverlo
        {
            MoverForm();
        }
        #endregion
        private void btnCerrarLogin_Click(object sender, EventArgs e) //Evento de cierre al logo de Cerrar
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        #region Placeholders y Show/Hide  | Métodos para dar el efecto Placeholder a los campos de Usuario y Password y mostrar/ocultar Pass |
        private void txtBoxUsers_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsers.Text == "USUARIO")
            {
                txtBoxUsers.Text = "";
                txtBoxUsers.ForeColor = Color.White;
            }
        }
        private void txtBoxUsers_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsers.Text == "")
            {
                txtBoxUsers.Text = "USUARIO";
                txtBoxUsers.ForeColor = Color.Silver;
            }
        }

        private void txtBoxPassw_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassw.Text == "CONTRASEÑA")
            {
                txtBoxPassw.Text = "";
                txtBoxPassw.ForeColor = Color.White;
                txtBoxPassw.UseSystemPasswordChar = true;
                if (txtBoxPassw.Text == "")
                {
                    picShowPass.BringToFront();
                }
            }
        }
        private void txtBoxPassw_Leave(object sender, EventArgs e)
        {
            if (txtBoxPassw.Text == "")
            {
                txtBoxPassw.Text = "CONTRASEÑA";
                txtBoxPassw.ForeColor = Color.Silver;
                txtBoxPassw.UseSystemPasswordChar = false;
            }
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            picHidePass.BringToFront();
            txtBoxPassw.UseSystemPasswordChar = false;
        }
        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (txtBoxPassw.Text != "CONTRASEÑA" || txtBoxPassw.Text == "")
            {
                picShowPass.BringToFront();
                txtBoxPassw.UseSystemPasswordChar = true;
            }
        }
        #endregion
        

        private void MsgError(string msg) //Mensaje de error de validación de campos
        {
            lblErrorMsg.Text = msg;
            lblErrorMsg.Visible = true;
            picError.Visible = true;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUsers.Text;
            string contraseña = txtBoxPassw.Text;
            if (txtBoxUsers.Text == "USUARIO" && txtBoxPassw.Text == "CONTRASEÑA")
            {
                MsgError("Complete los campos Usuario y Contraseña");
            }
            else if (txtBoxUsers.Text == "USUARIO")
            {
                MsgError("Complete el campo Usuario");
            }
            else if (txtBoxPassw.Text == "CONTRASEÑA")
            {
                MsgError("Complete el campo Contraseña");
            }

            //Llamada a la capa de lógica para la autenticación
            //bool loginExitoso = LogicaUsuario.AutenticarUsuario(usuario, contraseña);

            //if (loginExitoso)
            //{
            //    FormMenu formMenu = new FormMenu();
            //    formMenu.FormClosed += LogOut;
            //    formMenu.Show();
            //    this.Hide();
            //    MessageBox.Show("Bienvenido, " + usuario + ".");
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrectos.");
            //}
            //lblErrorMsg.Visible = false;
            //picError.Visible = false;
        }

        //private void LogOut(object sender, FormClosedEventArgs e)
        //{
        //    txtBoxUsers.Clear();
        //    txtBoxPassw.Clear();
        //    lblErrorMsg.Visible = false;
        //    this.Show();
        //    txtBoxUsers.Text = "USUARIO";
        //    txtBoxPassw.Text = "CONTRASEÑA";
        //}

        

        
    }
}
