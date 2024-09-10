using CV_Presentacion.Forms.Taller.Frm_Insumos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Frm_Taller
{
    public partial class frm_MenuMecanica : Form
    {
        public frm_MenuMecanica()
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
        private void frm_MenuMecanica_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Mecanica(), sender);
        }

        private void btnAltaMecanica_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Mecanica(), sender);
        }

        private void btnModificarMecanica_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarMecanica_Click(object sender, EventArgs e)
        {

        }
    }
}
