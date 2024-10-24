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
    public partial class frm_PermisosUsuarios : Form
    {
        CL_administrarComboBox _combo = new CL_administrarComboBox();
        CS_servicios _servicio = new CS_servicios();
        CL_administrarTablas _tabla = new CL_administrarTablas();
        CL_AdministrarRoles _rolUsuario = new CL_AdministrarRoles();

        public frm_PermisosUsuarios()
        {
            InitializeComponent();
            grbPermisoV.Enabled = false;
        }
        private void cboSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeleccionarUsuario.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
            }
            sinSeleccion();
        }
        private void frm_PermisosUsuarios_Load(object sender, EventArgs e)
        {
            _servicio.parametrosDataGridView(dgvDatos);
            _servicio.parametrosDataGridView(dgvRoles);
            _combo.seleccionCombo(cboSeleccionarUsuario, "spVerUsuario");

        }

        private void btnCargarRolAUsuario_Click(object sender, EventArgs e)
        {
            int idU = Convert.ToInt32(cboSeleccionarUsuario.SelectedValue.ToString());
            int idFR = Convert.ToInt32(this.dgvRoles.SelectedRows[0].Cells["id"].Value);
            _rolUsuario.cargarNuevoRolUsuario(idU, idFR);
            actualizaDGV();
            sinSeleccion();
        }//ok
        private void btnCargarPermisos_Click(object sender, EventArgs e)
        {
            int idU = Convert.ToInt32(cboSeleccionarUsuario.SelectedValue.ToString());
            int idFR = Convert.ToInt32(this.dgvRoles.SelectedRows[0].Cells["id"].Value);
            if (string.IsNullOrWhiteSpace(mkdFechaVence.Text) || mkdFechaVence.Text == "  /  /    ")
            {
                MessageBox.Show("El Campo VENCIMIENTO debe ser llenado.");
            }
            else
            {
                DateTime fechav = Convert.ToDateTime(mkdFechaVence.Text);
                _rolUsuario.NuevoRolConVencimiento(idU, idFR, fechav);
                actualizaDGV();
                sinSeleccion();
            }

        }//ok
        private void btnEliminarPermisos_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells["id"].Value);
            _rolUsuario.eliminarPersmisoAUsuario(idP);
            actualizaDGV();
            sinSeleccion();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells["id"].Value);

            if (string.IsNullOrWhiteSpace(mkdFechaVence.Text) || mkdFechaVence.Text == "  /  /    ")
            {
                MessageBox.Show("El Campo VENCIMIENTO debe ser llenado.");
            }
            else
            {
                DateTime fechav = Convert.ToDateTime(mkdFechaVence.Text);
                _rolUsuario.ActualizarFechaVenPermiso(idP, fechav);
                actualizaDGV();
                sinSeleccion();
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRoles.ClearSelection();
            grbPermisoV.Enabled = false;
            btnCargarRolAUsuario.Enabled = false;
            btnEliminarPermisos.Enabled = true;
        }
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRoles.ClearSelection();
            grbPermisoV.Enabled = true;
            btnModificar.Enabled = true;
            btnCargarPermisos.Enabled = false;
            btnEliminarPermisos.Enabled = false;
            lblPermiso.Text = dgvDatos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
        }
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ClearSelection();
            grbPermisoV.Enabled = false;
            btnEliminarPermisos.Enabled = false;
            btnCargarRolAUsuario.Enabled = true;
        }
        private void dgvRoles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ClearSelection();
            grbPermisoV.Enabled = true;
            btnCargarPermisos.Enabled = true;
            btnModificar.Enabled = false;
            btnCargarRolAUsuario.Enabled =false;
            btnEliminarPermisos.Enabled = false;
            lblPermiso.Text = dgvRoles.Rows[e.RowIndex].Cells["Posibles"].Value.ToString();
        }

        private void sinSeleccion()
        {
            btnCargarRolAUsuario.Enabled = false;
            btnEliminarPermisos.Enabled = false;
            lblPermiso.Text = "";
            mkdFechaVence.Text = "";
            grbPermisoV.Enabled = false;
            dgvDatos.ClearSelection();
            dgvRoles.ClearSelection();

        }
        private void actualizaDGV()
        {
            estiloDGV();
            dgvDatos.DataSource = _tabla.permisosPorUsuario(Convert.ToInt32(cboSeleccionarUsuario.SelectedValue.ToString()));
            dgvDatos.Columns["id"].Visible = false;
            dgvRoles.DataSource = _tabla.permisosNoUsuario(Convert.ToInt32(cboSeleccionarUsuario.SelectedValue.ToString()));
            dgvRoles.Columns["id"].Visible = false;
        }
        private void estiloDGV()
        {
            _servicio.parametrosDataGridView(dgvDatos);
            _servicio.parametrosDataGridView(dgvRoles);
        }
        private void listaPermiso()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboSeleccionarUsuario.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboSeleccionarUsuario.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    dgvDatos.DataSource = _tabla.permisosPorUsuario(valorSeleccionado);
                    dgvDatos.Columns["id"].Visible = false;
                    dgvRoles.DataSource = _tabla.permisosNoUsuario(valorSeleccionado);
                    dgvRoles.Columns["id"].Visible = false;
                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }


        /*private void PermitirCambios()
        {
            if (ckbModificar.Checked)
            {
                grbPermisoV.Enabled = true;
            }
            else
            {
                grbActualizar.Enabled = false;
                lblNomChofer.Text = null;
                lblNomUnidad.Text = null;
            }
        }*/
    }
}
