using CapaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms
{
    public partial class frm_AltaEmpleados : Form
    {

        public frm_AltaEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CS_contraseña pass = new CS_contraseña();

            string nombre = textBox1.Text.ToString();
            string passuser = textBox2.Text.ToString();

            string sha = pass.crearSHA256(nombre, passuser);

          //  textBox3.Text = sha;

            label3.Text = pass.crearCodigoVerificador(sha).ToString(); ;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
