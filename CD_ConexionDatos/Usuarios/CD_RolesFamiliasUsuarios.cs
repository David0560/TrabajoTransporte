using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Usuarios
{
    public class CD_RolesFamiliasUsuarios
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public void cargarNuevoRol(int id1, int id2)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevaFamiliaRol", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid_rol", id1);
                comando.Parameters.AddWithValue("@xid_familia",id2);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void EliminarFamiliaRol(int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spEliminarRegistroFamiliaRol", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xid", id);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        
        // cargar nuevo roles a usuario
        public void NuevoRolAUsuario( int idU , int idFR, DateTime fecha)
        {
            
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoRolAUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xidFR", idFR);
                comando.Parameters.AddWithValue("@xfechaA", fecha);
                comando.Parameters.AddWithValue("@xidU", idU);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void NuevoRolAUsuarioConVencimiento(int idU, int idFR, DateTime fecha, DateTime fechaV)
        {

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spGuardarNuevoRolAUsuarioConVencimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xidFR", idFR);
                comando.Parameters.AddWithValue("@xfechaA", fecha);
                comando.Parameters.AddWithValue("@xfechaV", fechaV);
                comando.Parameters.AddWithValue("@xidU", idU);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void ModificarRolFechaVencimiento(int idP, DateTime fechaV)
        {

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spActualizarFechaVenceRolDeUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xfechaV", fechaV);
                comando.Parameters.AddWithValue("@xidPermiso", idP);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void EliminarRolAUsuario(int idP)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spEliminarPermisoAUsuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xidPemiso", idP);

                comando.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
