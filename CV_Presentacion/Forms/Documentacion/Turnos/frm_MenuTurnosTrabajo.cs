using CV_Presentacion.Forms.Documentacion.Turnos;
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
    public partial class frm_MenuTurnosTrabajo : Form
    {
        public frm_MenuTurnosTrabajo()
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

        private void frm_MenuTurnosTrabajo_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Turnos(), sender);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Turnos(), sender);
        }
    }
}
