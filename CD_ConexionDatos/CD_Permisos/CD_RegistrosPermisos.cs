using System;
using System.Data.SqlClient;
using System.Data;
using CL_Negocios.Entidades;

namespace CD_ConexionDatos.CD_Permisos
{
    public class CD_RegistrosPermisos
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
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
            using (con = connectionBD.CreaInstacia().CrearConexion())
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

    }
}
