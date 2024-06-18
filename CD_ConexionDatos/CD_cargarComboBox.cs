using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class CD_cargarComboBox
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public CD_cargarComboBox() { }

        public DataTable ObtenerDatosComboBox(string query)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }
        }

        /*public DataTable CargarEmpleados()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerEmpleados", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
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
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow();
                dr["nombre"] = null;
                dt.Rows.InsertAt(dr, 0);
                con.Close();
                return dt; // retorno dt
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DataTable CargarRoles()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerRoles", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow();
                dr["nombre"] = null;
                dt.Rows.InsertAt(dr, 0);
                con.Close();
                return dt; // retorno dt
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DataTable CargarDocumentoIdent()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerDocumentoIdent", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
                return dt; // retorno dt

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable CargarLocalidad()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerLocalidad", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
                return dt; // retorno dt

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable CargarSexo()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerSexo", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
                return dt; // retorno dt

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable CargarTareas()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerTareas", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
                return dt; // retorno dt

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable CargarUsuarios()
        {
            try
            {
                con = connectionBD.CreaInstacia().CrearConexion(); //devuelve el string de conexin a sql
                SqlDataAdapter da = new SqlDataAdapter("spVerUsuario", con); // cargo el da con el sp y la conexion.
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure; // indico que este dataAdapter es un procedimiento almacenado con el CommnadType
                DataTable dt = new DataTable(); // creo un datatable
                da.Fill(dt); // cargo el dr con los valores del Da mediante su metodo fill
                DataRow dr = dt.NewRow(); // creo una nueva fila
                dr["nombre"] = null; // indico el nombre de la coluna y su contenido en este caso es vacio.
                dt.Rows.InsertAt(dr, 0); // la agrego a la primera fila.
                return dt; // retorno dt

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/


    }

}
