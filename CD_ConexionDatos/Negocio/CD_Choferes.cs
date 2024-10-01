using CL_Negocios.Entidades;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Empleados
{
    public class CD_Choferes
    {
        //int resultado = 0;
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        //Contructor
        public CD_Choferes() { }

        //Metodos
        public DateTime TrabajaEsteDia(int id)
        {    
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                
                con.Open();
                SqlCommand comando = new SqlCommand("spObtenerFechaGrupo", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    DateTime fechainicio = DateTime.MinValue;
                    if (reader.Read())
                    {
                       fechainicio = reader.GetDateTime(0);
                    }
                    return fechainicio;
                }
               
            }
        }
        public DataTable obteneUnidadesConVTV(DateTime vence) // corresponde a unidades.
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spObtenerTablaUnidadesConvtv", con);
                comando.Parameters.Add(new SqlParameter("@xvence", con));
                comando.Parameters["@xvence"].Value = vence;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable tablaDatos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }

        }
        public DataTable obtenerTablaChoferesConLicencia(DateTime vence)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spObtenerTablaChoferesConLicencia", con);
                comando.Parameters.Add(new SqlParameter("@xvence", con));
                comando.Parameters["@xvence"].Value = vence;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable tablaDatos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }

        }
        public DataTable obtenerTablaChoferesConLicenciaTurno(DateTime vence, int turno)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("obtenerTablaChoferesConLicenciaTurno", con);
                comando.Parameters.Add(new SqlParameter("@xfecha", con));
                comando.Parameters["@xfecha"].Value = vence;
                comando.Parameters.Add(new SqlParameter("@xturno", con));
                comando.Parameters["@xturno"].Value = turno;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable tablaDatos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }

        }




    }
}
