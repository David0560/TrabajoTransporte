using CV_Presentacion.Forms.Documentacion.Actualizar;
using CV_Presentacion.Forms.Documentacion.Ramales;
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
    public partial class frm_MenuRamales : Form
    {
        public frm_MenuRamales()
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
            OpenChildForm(new frm_Ramales(), sender);
        }
        private void frm_MenuRamales_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Ramales(), sender);
        }
    }
}

