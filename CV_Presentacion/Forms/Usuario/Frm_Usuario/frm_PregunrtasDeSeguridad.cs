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

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_PregunrtasDeSeguridad : Form
    {

        CL_administrarPreguntas pre = new CL_administrarPreguntas();
        public frm_PregunrtasDeSeguridad()
        {
            InitializeComponent();

        }

        /*private void ckbPregunta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPregunta.CheckState == CheckState.Checked) //desactivo el grupo que contiene agregar una nueva pregunta.
            {
                grbPregunta.Visible = false;
                lblTituloPregunta.Text = "Opción de configuracion bloqueada.";
            }
            else
            {
                grbPregunta.Visible = true;
                lblTituloPregunta.Text = "Cargar nueva pregunta de seguridad";
            }
        }*/

        private void btnEliminarPregunta_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvPreguntas.SelectedRows[0].Cells[0].Value);
            DialogResult resultado = MessageBox.Show("Está a punto de ELIMINAR un registros. ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                pre.eliminarPregunta(id);
                //registro.LimpiarControlesEnTabPage(tabPreguntas);

            }
        }

        private void btnGuardarPregunta_Click_1(object sender, EventArgs e)
        {
            bool valor;
            valor = pre.crearNuevaPregunta(textBox7.Text);
            if (valor)
            {
                MessageBox.Show("pregunta guardad");
            }
            else
            {
                MessageBox.Show("se esperaba un nueva pregunta intente nuevamente.");
            }
        }
    }
}
