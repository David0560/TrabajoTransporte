using CV_Presentacion.Frm_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion
{
    public partial class frm_MenuEmpleado1 : Form
    {
        private Form activeForm;
        public frm_MenuEmpleado1()
        {
            InitializeComponent();
        }
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

        // abrir los formularios del submenu
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaUsuario(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PermisosUsuarios(), sender);
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaUsuario(), sender);
        }
    }
}
