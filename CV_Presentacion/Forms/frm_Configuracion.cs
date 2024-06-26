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
using CL_Negocios;

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
            string encrip = a.crearSHA256(textBox1.Text, textBox2.Text);
            
            label5.Text = encrip;

            int valor = a.crearCodigoVerificador(encrip);
            label6.Text = Convert.ToString(valor);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
