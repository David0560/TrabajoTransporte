using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Negocios.Entidades;

namespace CD_ConexionDatos
{
    public class CD_crearRegistros
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public CD_crearRegistros() { }

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
        public void bloqueoDeUsuario(string nombreUsuario)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spBloquearUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xnombre", con));
                comando.Parameters["@xpregunta"].Value = nombreUsuario;

                comando.ExecuteNonQuery();
            }
        }

        
        //
        // relacionados con los roles
        //

    }
}
