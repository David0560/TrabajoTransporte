using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Negocios.Entidades;
using CD_ConexionDatos.Entidades;
using CapaServicios;

namespace CD_ConexionDatos
{
    public class CD_crearRegistros
    {

        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public CD_crearRegistros() { }
        int cantidad;
        //
        // relacionados al Usuario
        //
        public void guardarNuevoUsuario(Usuario usuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xnombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@xestado", usuario.Estado);
                comando.Parameters.AddWithValue("@xid_persona", usuario.Id_persona);
                comando.Parameters.AddWithValue("@xpassword_user", usuario.Password_user);
                comando.Parameters.AddWithValue("@xfecha_vence_pass", usuario.Fecha_vence_pass);
                comando.Parameters.AddWithValue("@xfecha_user_temporal", usuario.Fecha_user_temporal);
                comando.Parameters.AddWithValue("@xfecha_alta", DateTime.Now);
                comando.Parameters.AddWithValue("@xid_familia", usuario.Id_familia);

                comando.ExecuteNonQuery();
            }
        }
        public void borrarUsuario(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBorrarUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xnombre", con));
                comando.Parameters["@xpregunta"].Value = nombreUsuario;

                comando.ExecuteNonQuery();
            }
        }
        public void bloqueoDeUsuario(int id, bool valor)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBloquearUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.Parameters.Add(new SqlParameter("@xestado", con));
                comando.Parameters["@xestado"].Value = valor;

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public int obtenerUltimoUsuario()
        {
            
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
               
                using (SqlCommand comando = new SqlCommand("spVerUltimoUsuairo", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cantidad = Convert.ToInt32(leer["id"]);
                        }
                            
                    }
                    
                }
               
            }
            return cantidad;
        }
        public void actualizarPasswordUsuario(int idUsuario, string password)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarPasswordUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid", idUsuario);
                comando.Parameters.AddWithValue("@xpassword_user", password);

                comando.ExecuteNonQuery();


            }
        }

        //
        // relacionados con los roles
        //
        public void guardarNuevoPermiso(Permisos permiso)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoPermiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_famil_rol", permiso.Id_familia_rol);
                comando.Parameters.AddWithValue("@xid_usuario", permiso.Id_usuario);
                comando.Parameters.AddWithValue("@xfecha_alta", DateTime.Now);
                comando.Parameters.AddWithValue("@xfecha_baja", permiso.Fecha_baja);
                
                comando.ExecuteNonQuery();
            }
            
        }
        public void EliminarPermisoDeUsuario(int id)
        {

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBorrarPermisoUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;

                comando.ExecuteNonQuery();
            }
        }
        public void ActualizarFechaVencimiento(int id, DateTime? nuevafecha)
        {
            using(con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarFechaPermiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.Parameters.Add(new SqlParameter("@xfecha_baja", con));
                comando.Parameters["@xfecha_baja"].Value = nuevafecha;

                comando.ExecuteNonQuery();
            }
        }
        //
        //relacionado a las Contraseñas
        //
        public void GuardarNuevaContraseña(ContrasenaUsuario constrasena)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevaContraseña", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_usuario", constrasena.Id_usuario);
                comando.Parameters.AddWithValue("@xcontraseña", constrasena.Contraseña);
                comando.Parameters.AddWithValue("@xsistema", constrasena.Sistema);
                comando.Parameters.AddWithValue("@xfecha", DateTime.Now);

                comando.ExecuteNonQuery();
            }
        }

        public void GuardarNuevoCodigoV(codigoVerificador codeV)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoCodigo", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_usuario", codeV.Id_usuario);
                comando.Parameters.AddWithValue("@xvalor", codeV.Valor);

                comando.ExecuteNonQuery();
            }
        }
        public void ActualizarCodigoV(codigoVerificador codeV)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarCodigo", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_usuario", codeV.Id_usuario);
                comando.Parameters.AddWithValue("@xvalor", codeV.Valor);

                comando.ExecuteNonQuery();
            }
        }

        // Método para obtener el ID de usuario por nombre de usuario
        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int idUsuario = 0;

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spUbicarUsuarioLogin", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xnombre", nombreUsuario);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idUsuario = Convert.ToInt32(reader["id"]);
                    }
                }
            }

            return idUsuario;
        }

        // Método para actualizar la contraseña y otros campos relacionados
        public void ActualizarContraseña(int idUsuario, string nombreUsuario, string contraseñaActual, string nuevaContraseña, string nuevaContraseñaHasheada, int nuevoCodigoVerificador)
        {
            using (SqlConnection con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                //SqlTransaction transaction = con.BeginTransaction();

                // Verificar la contraseña actual antes de proceder con la actualización
                string contraseñaActualAlmacenada = ObtenerContraseñaActualDesdeBD(idUsuario); // Implementa este método según cómo obtengas la contraseña actual de la BD

                if (contraseñaActual != contraseñaActualAlmacenada)
                {
                    throw new Exception("La contraseña actual ingresada no es válida.");
                }
                try
                {
                    CS_contraseña password = new CS_contraseña(); // Crear una instancia de CS_contraseña

                    // Actualizar la tabla Usuario
                    SqlCommand comando = new SqlCommand("UPDATE Usuario SET password_user = @password_user WHERE id = @id_usuario", con);
                    comando.Parameters.AddWithValue("@password_user", nuevaContraseña);
                    comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                    comando.ExecuteNonQuery();


                    // Actualizar la tabla Contraseña (nueva y ultima contraseña)
                    SqlCommand comandoC = new SqlCommand("spGuardarNuevaContraseña", con);
                    comandoC.CommandType = CommandType.StoredProcedure;
                    comandoC.Parameters.AddWithValue("@xid_usuario", idUsuario);
                    comandoC.Parameters.AddWithValue("@xcontraseña", nuevaContraseñaHasheada);
                    comandoC.Parameters.AddWithValue("@xsistema", 0);
                    comandoC.Parameters.AddWithValue("@xfecha", DateTime.Now);
                    comandoC.ExecuteNonQuery();

                    // Actualizar la tabla Codigo_v
                    SqlCommand comandoV = new SqlCommand("UPDATE Codigo_v SET valor = @xvalor WHERE id_usuario = @xid_usuario", con);
                    comandoV.Parameters.AddWithValue("@xvalor", nuevoCodigoVerificador);
                    comandoV.Parameters.AddWithValue("@xid_usuario", idUsuario);
                    comandoV.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    //comando.Rollback();C
                    throw new Exception("Error al actualizar la contraseña en las tablas.", ex);
                }
                /*catch (Exception ex)
                {
                    transaction.Rollback();

                    // Registro de detalles del error
                    
                    //string errorMessage = $"Error al actualizar la contraseña en las tablas: {ex.Message}\n" +
                                       //   $"Stack Trace: {ex.StackTrace}";
                    // LogError(errorMessage);

                    //throw new Exception(errorMessage, ex);
                    throw new Exception("Error en la actualización");
                }*/
            }
        }

        /* // Método para registrar errores (implementación básica)
         private void LogError(string message)
         {
             // Ejemplo: Registrar el error en un archivo de texto
             string logFilePath = "ruta_a_tu_archivo_de_registro.txt"; // Cambia esto a la ruta deseada
             using (StreamWriter writer = new StreamWriter(logFilePath, true))
             {
                 writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + message);
             }
         }*/



        // Método para obtener la contraseña actual desde la base de datos
        private string ObtenerContraseñaActualDesdeBD(int idUsuario)
        {
            using (SqlConnection con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT password_user FROM Usuario WHERE id = @id_usuario", con);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                return null; // Manejar caso donde no se encuentra la contraseña
            }
        }
    }
}
