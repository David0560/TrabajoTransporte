using CD_ConexionDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios;

namespace CD_ConexionDatos.Password
{
    public class CD_RegistrosPassword
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
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
                con.Close();
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
                con.Close();
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
                con.Close();
            }
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
                    con.Close();

                }
                catch (Exception ex)
                {
                    //comando.Rollback();C
                    throw new Exception("Error al actualizar la contraseña en las tablas.", ex);
                }
            }
        }
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
                con.Close();
            }

            return idUsuario;
        }
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
