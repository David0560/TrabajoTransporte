using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;

namespace CL_Negocios
{
    public class datosSql
    {

        SqlDataReader dr; // permite lee la secuencia de filas en una tabla "dr es una variable"
        DataTable dt = new DataTable(); // instancia un objeto tipo tabla
        SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores
        
        


        //metodo para listar los elementos de la tablas.
        public DataTable listar()
        {           
            try
            {
                // primero creo una instancia de la clase connectionBD luego activo activo el constructor y por ultimo llamo al metodo para crear la conexion.
                using (con = connectionBD.CreaInstacia().CrearConexion())// nos devuelve el string de conexin a sql
                {
                    using (SqlCommand comando = new SqlCommand("spListaPermisos", con))
                    {
                        con.Open();// abro la conexion.
                        dr = comando.ExecuteReader(); // comando va a tener los resultados de la consulta y los lleva atraves del executereade estos los voy a cargar en la lista.
                        dt.Load(dr); // la variable tabla (dataTable) va a cargar lo que tiene lista
                        return dt; // devuelvo tabla que lo contiene en memora depues lo mando al grid
                    } ; // preparo la BD para que reciva la consulta (consulta, conexion)
                }
            }
            catch (Exception ex)
            {
                 throw ex;
            }
            finally // permite colocar una condicion para saber el estado de la conexión
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close(); // cierra la conexión
                }
             }
        }


        public DataTable listarPermisos()
        {
            //utilizo el DataReader que fue instanciado antes como dr"
            //utiliso la variable declarada antes.
           
            try
            {
                int id_tipo_usuario = 2;
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    using (SqlCommand comando = new SqlCommand("spListarPermisosPorTipoUser", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@id_tipo_usuario", con));
                        comando.Parameters["@id_tipo_usuario"].Value = id_tipo_usuario;
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        con.Open();
                        da.Fill(dt);
                        return dt; 
                    } 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // permite colocar una condicion para saber el estado de la conexión
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // cierra la conexión
                }
            }
        }





    }
}
