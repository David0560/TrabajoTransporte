using CV_Presentacion.Forms.Documentacion.Ramales;
using CV_Presentacion.Forms.Documentacion.Unidades;
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
    public partial class frm_MenuUnidad : Form
    {
        public frm_MenuUnidad()
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

        private void frm_MenuUnidad_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Unidades(), sender);
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Unidades(), sender);
        }
    }
}
