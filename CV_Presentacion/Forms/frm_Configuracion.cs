using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;
using CL_Negocios.Entidades;

namespace CV_Presentacion.Forms
{
    public partial class frm_Configuracion : Form
    {
        public frm_Configuracion()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            CS_contraseña a = new CS_contraseña();
            //textBox2.Text= a.crearContraseñaRandom(4,8,true,true,true,true);

            label6.Text = Convert.ToString(a.crearCodigoVerificador(textBox1.Text, textBox2.Text));

            label5.Text = a.crearSHA256(textBox1.Text, textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
