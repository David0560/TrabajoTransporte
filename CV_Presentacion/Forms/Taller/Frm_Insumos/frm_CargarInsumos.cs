using CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla.Frm_Anexados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Taller.Frm_Insumos
{
    public partial class frm_CargarInsumos : Form
    {
        public frm_CargarInsumos()
        {
            InitializeComponent();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Form corte = new frm_Insumos();
            corte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
