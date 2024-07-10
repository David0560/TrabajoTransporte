using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio.Entidades;
using CapaLogicaNegocio.Llenar_Combos;

namespace CapaVistas.ABM_Empleados
{
    public partial class frmEmpleados : Form
    {

        private cls_Empleados empleado = new cls_Empleados();
        private int EmpleadoSeleccionadoId;


        public frmEmpleados()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void LlenarCombos()  //Método que llena los combos de Empleados
        {
            // Llenar ComboBox de Sexos
            cls_LlenarCombos CMBSexo = new cls_LlenarCombos(cmbSexo, "Sexo", "id", "descripcion");

            // Llenar ComboBox de Tipos de DNI
            cls_LlenarCombos CMBTipoDNI = new cls_LlenarCombos(cmbTipoDNI, "Documento_ident", "id", "tipo");

            // Llenar ComboBox de Localidades
            cls_LlenarCombos CMBLocalidad = new cls_LlenarCombos(cmbLocalidad, "Localidad", "id", "localidad");

            // Llenar ComboBox de Cargos
            cls_LlenarCombos CMBCargo = new cls_LlenarCombos(cmbCargo, "Tarea", "id_tarea", "nombre_tarea");

            cls_LlenarCombos CMBSexoModif = new cls_LlenarCombos(cmbSexoModif, "Sexo", "id", "descripcion");
            cls_LlenarCombos CMBTipoDNIModif = new cls_LlenarCombos(cmbTipoDNIModif, "Documento_ident", "id", "tipo");
            cls_LlenarCombos CMBLocalidadModif = new cls_LlenarCombos(cmbLocalidadModif, "Localidad", "id", "localidad");
            cls_LlenarCombos CMBCargoModif = new cls_LlenarCombos(cmbCargoModif, "Tarea", "id_tarea", "nombre_tarea");

            cls_LlenarCombos CMBSexoBaja = new cls_LlenarCombos(cmbSexoBaja, "Sexo", "id", "descripcion");
            cls_LlenarCombos CMBTipoDNIBaja = new cls_LlenarCombos(cmbTipoDNIBaja, "Documento_ident", "id", "tipo");
            cls_LlenarCombos CMBLocalidadBaja = new cls_LlenarCombos(cmbLocalidadBaja, "Localidad", "id", "localidad");
            cls_LlenarCombos CMBCargoBaja = new cls_LlenarCombos(cmbCargoBaja, "Tarea", "id_tarea", "nombre_tarea");
        }


        #region Método para validar todos los campos completos de Alta
        public bool ValidarCamposAlta(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                mensaje = "El campo Nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                mensaje = "El campo Apellido es obligatorio.";
                return false;
            }

            if (cmbSexo.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Sexo válido.";
                return false;
            }

            if (cmbTipoDNI.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Tipo de DNI válido.";
                return false;
            }

            if (!EsNumero(txtDNI.Text))
            {
                mensaje = "El campo DNI debe ser numérico.";
                return false;
            }

            if (dateNacimiento.Value == default)
            {
                mensaje = "Debe seleccionar una Fecha de Nacimiento válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                mensaje = "El campo Email es obligatorio.";
                return false;
            }
            if (!EsNumero(txtCelularAlta.Text))
            {
                mensaje = "El campo Celular debe ser numérico.";
                return false;
            }

            if (cmbLocalidad.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar una Localidad válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                mensaje = "El campo Calle es obligatorio.";
                return false;
            }

            if (!EsNumero(txtNumCalle.Text))
            {
                mensaje = "El campo Número de Calle debe ser numérico.";
                return false;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Cargo válido.";
                return false;
            }


            return true;
        }
        #endregion

        #region Método para validar que los campos de Modificar Empleado esten completos
        public bool ValidarCamposModif(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(txtNombreModif.Text))
            {
                mensaje = "El campo Nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrEmpty(txtApellidoModif.Text))
            {
                mensaje = "El campo Apellido es obligatorio.";
                return false;
            }

            if (cmbSexoModif.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Sexo válido.";
                return false;
            }

            if (cmbTipoDNIModif.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Tipo de DNI válido.";
                return false;
            }

            if (!EsNumero(txtDNIModif.Text))
            {
                mensaje = "El campo DNI debe ser numérico.";
                return false;
            }

            if (dateNacimientoModif.Value == default)
            {
                mensaje = "Debe seleccionar una Fecha de Nacimiento válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtEmailModif.Text))
            {
                mensaje = "El campo Email es obligatorio.";
                return false;
            }
            if (!EsNumero(txtCelularModif.Text))
            {
                mensaje = "El campo Celular debe ser numérico.";
                return false;
            }

            if (cmbLocalidadModif.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar una Localidad válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtCalleModif.Text))
            {
                mensaje = "El campo Calle es obligatorio.";
                return false;
            }

            if (!EsNumero(txtNumCalleModif.Text))
            {
                mensaje = "El campo Número de Calle debe ser numérico.";
                return false;
            }

            if (cmbCargoModif.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Cargo válido.";
                return false;
            }


            return true;
        }
        #endregion
        private bool EsNumero(string valor)
        {
            return int.TryParse(valor, out _); // Intenta convertir el valor a un entero pero el resultado es un booleano
        }

        


        #region Tab Ver Empleados        
        private void TraerTodos(DataGridView dgv, string datos = null)
        {
            dgv.DataSource = null;
            dgv.DataSource = empleado.VerEmpleados(datos);
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmp);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvVerEmp.DataSource = null;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (dgvVerEmp.DataSource != null)
            {
                dgvVerEmp.DataSource = null;
                TraerTodos(dgvVerEmp);
            }
        }
        #endregion

        #region Tab Alta Empleados
        private void btnRefreshAlta_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmpAlta);
        }
        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            string mensaje;
            TraerTodos(dgvVerEmpAlta);

            // Llamar a ValidarCampos y verificar si la validación es exitosa
            if (!ValidarCamposAlta(out mensaje))
            {
                // Si la validación falla, mostrar el mensaje de error y salir del método
                MessageBox.Show(mensaje);
                return;
            }

            try
            {
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Id_Sexo = Convert.ToInt32(cmbSexo.SelectedValue);
                empleado.Id_Documento_Ident = Convert.ToInt32(cmbTipoDNI.SelectedValue);
                empleado.Numero_Ident = Convert.ToInt32(txtDNI.Text);
                empleado.Fecha_Nacimiento = dateNacimiento.Value;
                empleado.Email = txtEmail.Text;
                empleado.Id_Localidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
                empleado.Calle = txtCalle.Text;
                empleado.Numero_Domicilio = Convert.ToInt32(txtNumCalle.Text);
                empleado.Id_Tarea = Convert.ToInt32(cmbCargo.SelectedValue);

                empleado.AgregarEmpleado();
                MessageBox.Show("Empleado Agregado Correctamente");
                TraerTodos(dgvVerEmpAlta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex.Message}");
            }

        }



        #endregion

        #region Tab Modificar Empleados
        private void btnRefreshModif_Click(object sender, EventArgs e)
        {
            if (dgvVerEmpModif.DataSource != null)
            {
                dgvVerEmpModif.DataSource = null;
                TraerTodos(dgvVerEmpModif);
            }
        }
        private void btnCargarListaModif_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmpModif);
        }
        private void btnModificarEmp_Click(object sender, EventArgs e)
        {
            string mensaje;

            // Llamar a ValidarCampos y verificar si la validación es exitosa
            if (!ValidarCamposModif(out mensaje))
            {
                // Si la validación falla, mostrar el mensaje de error y salir del método
                MessageBox.Show(mensaje);
                return;
            }
            try
            {
                if (dgvVerEmpModif.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvVerEmpModif.SelectedRows[0];
                    EmpleadoSeleccionadoId = Convert.ToInt32(row.Cells["id"].Value);

                    // Asignar los datos de la fila seleccionada a los controles correspondientes
                    txtNombreModif.Text = row.Cells["nombre"].Value?.ToString();
                    txtApellidoModif.Text = row.Cells["apellido"].Value?.ToString();
                    cmbSexoModif.SelectedValue = row.Cells["id_sexo"].Value ?? -1;
                    cmbTipoDNIModif.SelectedValue = row.Cells["id_documento_ident"].Value ?? -1;
                    txtDNIModif.Text = row.Cells["numero_ident"].Value?.ToString();
                    dateNacimientoModif.Value = row.Cells["fecha_nacimiento"].Value != null ? Convert.ToDateTime(row.Cells["fecha_nacimiento"].Value) : DateTime.Now;
                    txtEmailModif.Text = row.Cells["email"].Value?.ToString();
                    cmbLocalidadModif.SelectedValue = row.Cells["id_localidad"].Value ?? -1;
                    txtCalleModif.Text = row.Cells["calle"].Value?.ToString();
                    txtNumCalleModif.Text = row.Cells["numero_domicilio"].Value?.ToString();
                    cmbCargoModif.SelectedValue = row.Cells["id_tarea"].Value ?? -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del empleado: {ex.Message}");
            }
        }

        private void dgvVerEmpModif_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVerEmpModif.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVerEmpModif.SelectedRows[0];
                EmpleadoSeleccionadoId = Convert.ToInt32(row.Cells["id"].Value);

                // Asignar los datos de la fila seleccionada a los controles correspondientes
                txtNombreModif.Text = row.Cells["nombre"].Value.ToString();
                txtApellidoModif.Text = row.Cells["apellido"].Value.ToString();
                cmbSexoModif.SelectedValue = row.Cells["id_sexo"].Value;
                cmbTipoDNIModif.SelectedValue = row.Cells["id"].Value;
                txtDNIModif.Text = row.Cells["numero_ident"].Value.ToString();
                dateNacimientoModif.Value = Convert.ToDateTime(row.Cells["fecha_nacimiento"].Value);
                txtEmailModif.Text = row.Cells["email"].Value.ToString(); 
                cmbLocalidadModif.SelectedValue = row.Cells["id"].Value;
                txtCalleModif.Text = row.Cells["calle"].Value.ToString();
                txtNumCalleModif.Text = row.Cells["numero_domicilio"].Value.ToString();
                cmbCargoModif.SelectedValue = row.Cells["id"].Value;
            }

        }
        #endregion

        #region Tab Baja de Empleado
        private void btnRefreshBaja_Click(object sender, EventArgs e)
        {
            if (dgvVerEmpBaja.DataSource != null)
            {
                dgvVerEmpBaja.DataSource = null;
                TraerTodos(dgvVerEmpBaja);
            }
        }
        private void btnCargarEmpBaja_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmpBaja);
        }




        #endregion

        private void dgvVerEmpBaja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVerEmpBaja.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVerEmpBaja.SelectedRows[0];
                EmpleadoSeleccionadoId = Convert.ToInt32(row.Cells["id"].Value);

                // Asignar los datos de la fila seleccionada a los controles correspondientes
                txtNombreModif.Text = row.Cells["nombre"].Value.ToString();
                txtApellidoModif.Text = row.Cells["apellido"].Value.ToString();
                cmbSexoModif.SelectedValue = row.Cells["id_sexo"].Value;
                cmbTipoDNIModif.SelectedValue = row.Cells["id"].Value;
                txtDNIModif.Text = row.Cells["numero_ident"].Value.ToString();
                dateNacimientoModif.Value = Convert.ToDateTime(row.Cells["fecha_nacimiento"].Value);
                txtEmailModif.Text = row.Cells["email"].Value.ToString();
                cmbLocalidadModif.SelectedValue = row.Cells["id"].Value;
                txtCalleModif.Text = row.Cells["calle"].Value.ToString();
                txtNumCalleModif.Text = row.Cells["numero_domicilio"].Value.ToString();
                cmbCargoModif.SelectedValue = row.Cells["id"].Value;
            }
        }

        private void btnEliminarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.EliminarEmpleado(EmpleadoSeleccionadoId);
                MessageBox.Show("Empleado Eliminado Correctamente");
                TraerTodos(dgvVerEmpBaja);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex.Message}");
            }
        }
    }
}