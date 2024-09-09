using CapaServicios;
using CL_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_PermisosGrupos : Form
    {

        CL_administrarComboBox _combo = new CL_administrarComboBox();
        CL_administrarTablas _tabla = new CL_administrarTablas();
        CS_servicios _servicio = new CS_servicios();
        public frm_PermisosGrupos()
        {
            InitializeComponent();
        }
        private void frm_PermisosGrupos_Load(object sender, EventArgs e)
        {
            _combo.seleccionCombo(cboTUsuarios, "spVerFamilias");
            _combo.seleccionCombo(cboPermisos, "spVerRoles");
            _servicio.parametrosDataGridView(dgvPermisosFamilia);
        }
 
        private void cboTUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTUsuarios.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
            }
        } 
        private void listaPermiso()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboTUsuarios.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboTUsuarios.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    dgvPermisosFamilia.DataSource = _tabla.permisosTorTipoDeUsuario(valorSeleccionado);
                }
            }
        }

    }
}
