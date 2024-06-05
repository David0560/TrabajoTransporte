using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Negocios;


namespace CV_Presentacion
{
    public partial class frmLogin : Form
    {
        operaciones operaciones = new operaciones();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Resultado = operaciones.ValidarUsuario(txtPassword.Text, txtUsuario.Text);

           if(Resultado > 0 )
            {
                FrmMenu menu = new FrmMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else if(Resultado <= 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
            }
        }
    }
}
