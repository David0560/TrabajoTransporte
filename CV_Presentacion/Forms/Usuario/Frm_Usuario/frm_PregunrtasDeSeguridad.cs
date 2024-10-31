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

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_PregunrtasDeSeguridad : Form
    {

        CL_administrarPreguntas pre = new CL_administrarPreguntas();
        CS_servicios servicio = new CS_servicios();
        public frm_PregunrtasDeSeguridad()
        {
            InitializeComponent();
        }

        private void btnEliminarPregunta_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvPreguntas.SelectedRows[0].Cells[0].Value);
            DialogResult resultado = MessageBox.Show("Está a punto de ELIMINAR un registros. ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                pre.eliminarPregunta(id);
                listados();
            }
        }

        private void btnGuardarPregunta_Click_1(object sender, EventArgs e)
        {
            bool valor;
            valor = pre.crearNuevaPregunta(textBox7.Text);
            if (valor)
            {
                MessageBox.Show("pregunta guardad");
                listados();
            }
            else
            {
                MessageBox.Show("se esperaba un nueva pregunta intente nuevamente.");
            }
        }

        private void frm_PregunrtasDeSeguridad_Load(object sender, EventArgs e)
        {
            listados();
        }

        private void listados() 
        {
            dgvPreguntas.DataSource = null;
            servicio.parametrosDataGridView(dgvPreguntas);

            dgvPreguntas.DataSource = pre.Preguntas();
            dgvPreguntas.Columns["id"].Visible = false; // columna oculta
        }
    }
}
