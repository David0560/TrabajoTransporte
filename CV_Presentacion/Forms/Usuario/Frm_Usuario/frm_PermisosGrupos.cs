using CapaServicios;
using CL_Negocios;
using CL_Negocios.Usuarios;
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
        CL_AdministrarRoles rol = new CL_AdministrarRoles();
        CL_administrarTablas _tabla = new CL_administrarTablas();
        CS_servicios _servicio = new CS_servicios();
        public frm_PermisosGrupos()
        {
            InitializeComponent();
        }
        private void frm_PermisosGrupos_Load(object sender, EventArgs e)
        {
            _combo.seleccionCombo(cboTUsuarios, "spVerFamilias");
            estiloDGV();
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
                    dgvPermisosFamilia.Columns["id_fr"].Visible = false;
                    dgvPermisosFamilia.Columns["id"].Visible = false;
                    dgvRoles.DataSource = _tabla.permisosParaCargar(valorSeleccionado);
                    dgvRoles.Columns["id"].Visible = false;
                }
            }
        }

        private void btnCargarPermiso_Click(object sender, EventArgs e)
        {
            // obtener id rol
            // guardaralo en la familia seleccionada
            //actualizar las tablas.

            int id_Rol = Convert.ToInt32(this.dgvRoles.SelectedRows[0].Cells["id"].Value);
            int id_Familia = Convert.ToInt32(cboTUsuarios.SelectedValue.ToString());

            rol.cargarNuevoRol(id_Rol, id_Familia);
            actualizaDGV();
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            // eliminar el registros seleccionado por id.
            // actualizar las tablas
            int id = Convert.ToInt32(this.dgvPermisosFamilia.SelectedRows[0].Cells["id_Fr"].Value);
            rol.EliminarRolEnFamilia(id);
            actualizaDGV();
        }

        private void actualizaDGV()
        {
            estiloDGV();
            dgvPermisosFamilia.DataSource = _tabla.permisosTorTipoDeUsuario(Convert.ToInt32(cboTUsuarios.SelectedValue.ToString()));
            dgvPermisosFamilia.Columns["id_fr"].Visible = false;
            dgvPermisosFamilia.Columns["id"].Visible = false;
            dgvRoles.DataSource = _tabla.permisosParaCargar(Convert.ToInt32(cboTUsuarios.SelectedValue.ToString()));
            dgvRoles.Columns["id"].Visible = false;
        }
        private void estiloDGV()
        {
            _servicio.parametrosDataGridView(dgvPermisosFamilia);
            _servicio.parametrosDataGridView(dgvRoles);
        }
    }
}
