using CapaServicios;
using CL_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Forms
{
    public partial class frm_Empleados : Form
    {
        private CL_administrarComboBox combo = new CL_administrarComboBox();
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

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboTarea, "spVerTareas");
            combo.seleccionCombo(cboDocumento, "spVerDocumentoIdent");
            combo.seleccionCombo(cboSexo, "spVerSexo");

            combo.seleccionCombo(cboCiudad, "spVerCiudad");
            mskFIngreso.Text = DateTime.Now.ToShortDateString();
        }
        private void listaPermiso()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboCiudad.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboCiudad.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    int valor = Convert.ToInt32(cboCiudad.SelectedValue);
                    combo.seleccionarLocalidad(cboLocalidad, valor); 

                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
            }
        }
    }
}
