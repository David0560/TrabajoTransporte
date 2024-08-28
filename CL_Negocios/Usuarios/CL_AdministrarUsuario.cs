using CD_ConexionDatos;
using CL_Negocios.Entidades;
using System;
using CapaServicios;
using CD_ConexionDatos.Entidades;
using CD_ConexionDatos.Password;
using CD_ConexionDatos.Usuarios;
using System.Windows.Forms;
using CD_ConexionDatos.CD_Permisos;

namespace CL_Negocios.Usuarios
{
    public class CL_AdministrarUsuario
    {
        CS_contraseña _password = new CS_contraseña();
        CD_RegistrosPassword _dbPass = new CD_RegistrosPassword();
        CD_RegistrosPermisos _permisos = new CD_RegistrosPermisos();
        


        private CD_RegistrosUsuarios _crearRegistros; //creo una propiedad con un objeto Crear Registro
        public CL_AdministrarUsuario()
        {
            _crearRegistros = new CD_RegistrosUsuarios(); //dentro del constructor instancio el objeto.    
        }

        //relacionados al usuario
        public bool insertarNuevoUsuario(Usuario usuario, ConfiguracionPassword config)
        {
            if (usuario.Nombre != "")
            {

                string pass = _password.crearContraseña(config);
                DateTime? fechaVU = ValidarFecha(usuario.fechaVU);
                DateTime? fechaVP = ValidarFecha(usuario.fechaVP);

                if (ContieneEspacio(usuario.Nombre))
                {
                    if (validarFechaPosible(fechaVU) & validarFechaPosible(fechaVP))
                    {
                        Usuario guardarUsuario = new Usuario(usuario.Nombre, usuario.Id_persona, usuario.Id_familia, fechaVP, fechaVU, 1, pass);
                        _crearRegistros.guardarNuevoUsuario(guardarUsuario);

                        // Cargar password a la tabla.
                        string nombreUsuario = usuario.Nombre;
                        int id_usuario = _crearRegistros.obtenerUltimoUsuario();
                        string contraseña = _password.crearSHA256(nombreUsuario, pass);
                        bool system = true;
                        ContrasenaUsuario passUser = new ContrasenaUsuario(id_usuario, contraseña, system);
                        _dbPass.GuardarNuevaContraseña(passUser);

                        // cargar codigo verificador
                        int codV = Convert.ToInt32(_password.crearCodigoVerificador(contraseña));
                        codigoVerificador codigoV = new codigoVerificador(id_usuario, codV);
                        _dbPass.GuardarNuevoCodigoV(codigoV);

                        return true;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }

        }
        public void eliminarUsuario(string nombreUsuario)
        {
            _crearRegistros.borrarUsuario(nombreUsuario);
        }
        public void bloquearUsuario(int nombreUsuario, string estado)
        {
            bool valor;
            if (estado == "0" || estado == "false" || estado == "bloqueado")
            {
                valor = false;
            }
            else
            {
                valor = true;
            }
            _crearRegistros.bloqueoDeUsuario(nombreUsuario, valor);
        }
        public void enviarNuevoPassword(int idUsuario, string nombreUsuario, ConfiguracionPassword config)
        {
            string pass = _password.crearContraseña(config);
            // Cargar password a la tabla.
            string contraseña = _password.crearSHA256(nombreUsuario, pass);
            bool system = true;
            ContrasenaUsuario passUser = new ContrasenaUsuario(idUsuario, contraseña, system);
            _dbPass.GuardarNuevaContraseña(passUser);

            // Actualizar codigo verificador
            int codV = Convert.ToInt32(_password.crearCodigoVerificador(contraseña));
            codigoVerificador codigoV = new codigoVerificador(idUsuario, codV);
            _dbPass.ActualizarCodigoV(codigoV);

            // actualizar passwordusurario
            _dbPass.actualizarPasswordUsuario(idUsuario, pass);

        }


        //relacionados a los roles
        public void insertarPermisoPorFamilia(Permisos permiso)
        {
            int id_famil_rol = permiso.Id_familia_rol;
            int id_usuario = _crearRegistros.obtenerUltimoUsuario();
            DateTime? fecha_baja = null;

            Permisos NuevoPermiso = new Permisos(id_famil_rol, id_usuario, fecha_baja);

            _permisos.guardarNuevoPermiso(NuevoPermiso);
        }
        public void insertarNuevoPermiso(Permisos permiso)
        {
            int id_famil_rol = permiso.Id_familia_rol;
            int id_usuario = permiso.Id_usuario;
            DateTime? fecha_baja = ValidarFecha(permiso.fecha_vence);

            Permisos NuevoPermiso = new Permisos(id_famil_rol, id_usuario, fecha_baja);

            _permisos.guardarNuevoPermiso(NuevoPermiso);
        }
        public void elimiarPermiso(int id)
        {
            _permisos.EliminarPermisoDeUsuario(id);
        }
        public void ActualizarFechaRegistro(int id, string fecha)
        {
            DateTime? fecha_baja = ValidarFecha(fecha);
            _permisos.ActualizarFechaVencimiento(id, fecha_baja);
        }

        // Método para cambiar la contraseña del usuario
        public void CambiarContraseña(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            // Obtener el ID del usuario por nombre
            int idUsuario = _crearRegistros.ObtenerIdUsuarioPorNombre(nombreUsuario);

            // Generar la nueva contraseña hasheada usando la instancia 'password'
            string nuevaContraseñaHasheada = _password.crearSHA256(nombreUsuario, nuevaContraseña);

            // Generar el nuevo código verificador usando la instancia 'password'
            int nuevoCodigoVerificador = _password.crearCodigoVerificador(nuevaContraseñaHasheada);

            // Actualizar las tablas con la nueva contraseña
            _dbPass.ActualizarContraseña(idUsuario, nombreUsuario, contraseñaActual, nuevaContraseña, nuevaContraseñaHasheada, nuevoCodigoVerificador);
        }

        //
        //validaciones y metodos
        //
        public DateTime? ValidarFecha(string valor)
        {
            if (valor == "  /  /")
            {
                DateTime? fecha = null;
                return fecha;
            }
            else if (valor == "")
            {
                DateTime? fecha = null;
                return fecha;
            }
            else
            {
                DateTime? fecha = DateTime.Parse(valor);
                return fecha;

            }

        }
        public bool validarFechaPosible(DateTime? valor)
        {
            if (valor > DateTime.Now || valor == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ContieneEspacio(string nombre)
        {
            // Verificar si la cadena contiene espacios en su interior
            if (nombre.Contains(" "))
            {
                return false; // La cadena contiene espacios
            }
            else
            {
                return true; // La cadena no contiene espacios
            }
        }
        public void LimpiarControles(Control control)
        {
            // Recorrer todos los controles dentro del control padre
            foreach (var c in control.Controls)
            {
                // Verificar si el control es un TextBox
                if (c is TextBox)
                {
                    ((TextBox)c).Clear(); // Limpia el contenido del TextBox
                }

                // Verificar si el control es un ComboBox if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; // Reiniciar la selección del ComboBox
                    ((ComboBox)c).Text = ""; // Limpiar el texto del ComboBox
                }

                // Verificar si el control es un DataGridView
                if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null; // Eliminar la fuente de datos del DataGridView
                    ((DataGridView)c).Rows.Clear(); // Limpiar las filas en el DataGridView
                }
            }

        }
        public void LimpiarControlesForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty; // Limpiar el contenido del TextBox
                }
                if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Resetear la selección del ComboBox
                }
                if (c is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null; // Eliminar la fuente de datos del DataGridView
                    dataGridView.Rows.Clear(); // Limpiar las filas en el DataGridView
                }
                if (c is MaskedTextBox maskedtextBox)
                {
                    maskedtextBox.Text = string.Empty; // Limpiar el contenido del maskedTextBox
                }


            }
        }


    }
}
