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
        //metodo para listar los elementos de la tablas.
        public DataTable listar()
        {
            SqlDataReader lista; // permite lee la secuencia de filas en una tabla "lista es una variable"
            DataTable Tabla = new DataTable();
            // nos conectamos a la base de datos
            SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores
            try
            {
                String sqlconsulta = "SELECT nombre_rol as Permisos FROM Rol";
                // primero creo una instancia de la clase connectionBD luego activo activo el constructor y por ultimo llamo al metodo para crear la conexion.
                con = connectionBD.CreaInstacia().CrearConexion(); // nos devuelve el string de conexin a sql
                SqlCommand comando = new SqlCommand(sqlconsulta, con); // preparo la BD para que reciva la consulta (consulta, conexion)
                con.Open();
                lista = comando.ExecuteReader(); // comando va a tener los resultados de la consulta y los lleva atraves del executereade estos los voy a cargar en la lista.
                Tabla.Load(lista); // la variable tabla (dataTable) va a cargar lo que tiene lista
                return Tabla; // devuelvo tabla que lo contiene en memora depues lo mando al grid

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
    }
}
