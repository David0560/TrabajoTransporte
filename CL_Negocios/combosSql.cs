using CD_ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    public class combosSql
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        public combosSql() { }

        public DataTable CargarEmpleados()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerEmpleados", con); // cargo el da con el sp y la conexion.
                //con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                return dt; // retorno dt
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }
        public DataTable CargarFamilia()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerFamilias", con); // cargo el da con el sp y la conexion.
                //con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                return dt; // retorno dt
            }
            catch (Exception ex)
            {

                throw ex;
            }
                       


        }

    }
}
