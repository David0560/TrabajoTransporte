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
    public partial class frm_Empleados : Form
    {

        public frm_Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CS_contraseña pass = new CS_contraseña();

            string nombre = textBox1.Text.ToString();
            string passuser = textBox2.Text.ToString();

            string sha = pass.crearSHA256(nombre, passuser);

            textBox3.Text = sha;

            label3.Text = pass.crearCodigoVerificador(sha).ToString(); ;


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
