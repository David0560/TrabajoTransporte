using CV_Presentacion.Forms.Frm_Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Registro.Frm_Proveedores
{
    public partial class frm_MenuProveedores : Form
    {
        public frm_MenuProveedores()
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
        private void frm_MenuProveedores_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaProveedor(), sender);
        }

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaProveedor(), sender);
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ModificarProveedor(), sender);
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
