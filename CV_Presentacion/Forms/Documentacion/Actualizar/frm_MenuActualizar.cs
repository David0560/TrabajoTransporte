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

namespace CV_Presentacion.Forms.Documentacion
{
    public partial class frm_MenuActualizar : Form
    {
        public frm_MenuActualizar()
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
        private void btnVtv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ActualizarVtv(), sender);
        }
        private void btnRegistroConducir_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ActualizarRegistroCond(), sender);
        }

        private void frm_MenuActualizar_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ActualizarVtv(), sender);
        }
    }
}
