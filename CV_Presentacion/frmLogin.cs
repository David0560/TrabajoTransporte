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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //frmMenu menu = new FrmMenu();
            //this.Hide();
            //menu.ShowDialog();
        }
    }
}
