using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Negocio
{
    public class CD_PlanillaCierre
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public DataTable ListaDeRegistrosCierre(DateTime fecha)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spListaParaCierre", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xfecha", con));
                comando.Parameters["@xfecha"].Value = fecha;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable lista = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(lista);
                con.Close();
                return lista;
            }
        }
    }
}
