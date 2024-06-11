using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;
using CL_Negocios.Entidades;

namespace CL_Negocios
{
    public class datosSql
    {
        List<cachePermisosAlta> Roles = new List<cachePermisosAlta>();// instancio la lista
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
        public DataTable listarPermisos(string str)
        {
            //utilizo el DataReader que fue instanciado antes como dr"
            //utiliso la variable declarada antes.
           
            try
            {
                int str1 = Convert.ToInt32(str);
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    using (SqlCommand comando = new SqlCommand("spListarPermisosPorTipoUser", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@id_tipo_usuario", con));
                        comando.Parameters["@id_tipo_usuario"].Value = str1;
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


        // cargar roles en alta de usuario.
        public List<cachePermisosAlta> obtenerRoles(string id_familiaRol)
        {
            int str1 = Convert.ToInt32(id_familiaRol);
            //List<cachePermisosAlta> Roles = new List<cachePermisosAlta>(); // instancio la lista
            using(con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spListarPermisosPorTipoUser", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@id_tipo_usuario", con));
                    comando.Parameters["@id_tipo_usuario"].Value = str1;
                    con.Open();// abro la conexion.
                    using(SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())// mientras tenga algo para leer
                        {
                            cachePermisosAlta Permiso = new cachePermisosAlta()// instancio el objeto cachePermisos
                            {
                                //cargo los Valores de reader en sus atributos correspondientes
                                IdRol = Convert.ToInt32(leer["id_familia_rol"]),
                                NombreRol = leer["nombre_rol"].ToString()
                            };
                            
                            Roles.Add(Permiso);// los agrego a la lista llamada roles
                        }
                       
                    }
                }
            }
            return Roles; // devuelvo la lista roles
        }
        public void agregarRoles(cachePermisosAlta actores) //cargar un nuevo registro
        {
            if(actores != null)
            {
                Roles.Add(actores);
            }

        }
        public void eliminarRoles(int actores)// eliminar un objeto de la lista
        {
            Roles.RemoveAt(actores);
        }
        public List<cachePermisosAlta> totalRoles()
        {
            return Roles;
        }
    }
}
