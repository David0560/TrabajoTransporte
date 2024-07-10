using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Entidades
{
    public class cls_EmpleadosQ : cls_EjecutarQ
    {
        // Propiedades del empleado
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Id_Documento_Ident { get; set; }
        public int Numero_Ident { get; set; }
        public int Id_Sexo { get; set; }
        public int Id_Localidad { get; set; }
        public string Calle { get; set; }
        public int Numero_Domicilio { get; set; }
        public string Email { get; set; }
        public int Id_Tarea { get; set; }

        // Métodos CRUD
        public DataTable ObtenerEmpleados(string datos)
        {
            DataTable resultado = null;
            try
            {
                string sSQL;
                List<SqlParameter> listaParametros = new List<SqlParameter>();
                if (string.IsNullOrEmpty(datos))
                {
                    sSQL = "SELECT * FROM Persona";
                }
                else
                {
                    sSQL = "SELECT * FROM Persona WHERE nombre + apellido LIKE @datos";
                    listaParametros.Add(new SqlParameter("@datos", "%" + datos.Trim() + "%"));
                }
                resultado = ConsultaRead(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al buscar empleados", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al buscar empleados", ex);
            }
            return resultado;
        }

        public void AgregarEmp()
        {
            try
            {
                string sSQL = "INSERT INTO Persona (nombre, apellido, id_sexo, id_documento_ident, numero_ident, fecha_nacimiento, email, id_localidad, calle, numero_domicilio, id_tarea) " +
                              "VALUES (@nombre, @apellido, @id_sexo, @id_tipodni, @dni, @fecha_nac, @correo, @telefono, @id_localidad, @calle, @numero_calle, @id_cargo)";
                List<SqlParameter> listaParametros = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", Nombre),
                    new SqlParameter("@apellido", Apellido),
                    new SqlParameter("@id_sexo", Id_Sexo),
                    new SqlParameter("@id_tipodni", Id_Documento_Ident),
                    new SqlParameter("@dni", Numero_Ident),
                    new SqlParameter("@fecha_nac", Fecha_Nacimiento),
                    new SqlParameter("@correo", Email),
                    new SqlParameter("@id_localidad", Id_Localidad),
                    new SqlParameter("@calle", Calle),
                    new SqlParameter("@numero_calle", Numero_Domicilio),
                    new SqlParameter("@id_cargo", Id_Tarea),
                };
                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al agregar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al agregar empleado", ex);
            }
        }
        public void ModificarEmp()
        {
            try
            {
                string sSQL = "UPDATE Persona SET nombre = @nombre, apellido = @apellido, " +
                              "id_sexo = @id_sexo, id_documento_ident = @id_tipodni, numero_ident = @dni, " +
                              "fecha_nacimiento = @fecha_nac, email = @correo, id_localidad = @id_localidad, " +
                              "calle = @calle, numero_domicilio = @numero_calle, id_tarea = @id_cargo" +
                              "WHERE id = @id_empleado";

                List<SqlParameter> listaParametros = new List<SqlParameter>
                {
                    new SqlParameter("@id_empleado", Id),
                    new SqlParameter("@nombre", Nombre),
                    new SqlParameter("@apellido", Apellido),
                    new SqlParameter("@id_sexo", Id_Sexo),
                    new SqlParameter("@id_tipodni", Id_Documento_Ident),
                    new SqlParameter("@dni", Numero_Ident),
                    new SqlParameter("@fecha_nac", Fecha_Nacimiento),
                    new SqlParameter("@correo", Email),
                    new SqlParameter("@id_localidad", Id_Localidad),
                    new SqlParameter("@calle", Calle),
                    new SqlParameter("@numero_calle", Numero_Domicilio),
                    new SqlParameter("@id_cargo", Id_Tarea),
                };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al modificar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al modificar empleado", ex);
            }
        }

        public void EliminarEmp(int idEmpleado)
        {
            try
            {
                string sSQL = "DELETE FROM Persona WHERE id = @id_empleado";

                List<SqlParameter> listaParametros = new List<SqlParameter>
        {
            new SqlParameter("@id_empleado", idEmpleado)
        };

                ConsultaWrite(sSQL, listaParametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de SQL: {ex.Message}");
                throw new Exception("Error al eliminar empleado", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Error general al eliminar empleado", ex);
            }
        }


    }
}