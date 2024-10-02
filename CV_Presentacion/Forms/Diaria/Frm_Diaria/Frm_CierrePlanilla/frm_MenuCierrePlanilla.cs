using CV_Presentacion.Forms.Frm_Registros;
using CV_Presentacion.Frm_Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    public partial class frm_MenuCierrePlanilla : Form
    {
        public frm_MenuCierrePlanilla()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {

                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlFormulario2.Controls.Add(childForm);
            this.pnlFormulario2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_CierrePlanilla(), sender);
        }

        private void frm_MenuCierrePlanilla_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_CierrePlanilla(), sender);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
