using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Documentacion.Actualizar
{
    public partial class frm_Licencia : Form
    {
        public frm_Licencia()
        {
            InitializeComponent();
            ocultarCarga();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            grbNuevaLicencia.Enabled = true;
            lblNombreL.Focus();
        }
        private void ocultarCarga()
        {
            grbNuevaLicencia.Enabled = true;
        }

        private void btnGuardarL_Click(object sender, EventArgs e)
        {

            grbNuevaLicencia.Enabled = false;
        }
    }
}
