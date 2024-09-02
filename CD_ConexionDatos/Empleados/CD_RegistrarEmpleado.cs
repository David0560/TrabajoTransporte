using System;
using System.Data;
using System.Data.SqlClient;
using CL_Negocios.Entidades;

namespace CD_ConexionDatos.Empleados
{
    public class CD_RegistrarEmpleado
    {
        private SqlConnection con = new SqlConnection();

        // Método para guardar un nuevo empleado en la base de datos.
        public void GuardarNuevoEmpleado(Persona persona)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();

                SqlCommand comando = new SqlCommand("spGuardarNuevoEmpleado", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("@xnombre", persona.Nombre);
                comando.Parameters.AddWithValue("@xapellido", persona.Apellido);
                comando.Parameters.AddWithValue("@xfecha_nacimiento", persona.Fecha_nacimiento);
                comando.Parameters.AddWithValue("@xid_documento_ident", persona.Id_documento_iden);
                comando.Parameters.AddWithValue("@xnumero_ident", persona.Numero_identidad);
                comando.Parameters.AddWithValue("@xid_sexo", persona.Id_sexo);
                comando.Parameters.AddWithValue("@xid_localidad", persona.Id_localidad);
                comando.Parameters.AddWithValue("@xcalle", persona.Calle);
                comando.Parameters.AddWithValue("@xnumero_domicilio", persona.Numero_domicilio);
                comando.Parameters.AddWithValue("@xemail", persona.Email);
                comando.Parameters.AddWithValue("@xid_tarea", persona.Id_tarea);

                comando.ExecuteNonQuery();

                con.Close();
            }
        }

    }
}