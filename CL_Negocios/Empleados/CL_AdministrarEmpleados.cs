using System;
using System.Data;
using CapaServicios.Entidades;
using CD_ConexionDatos;
using CD_ConexionDatos.Empleados; 
using CL_Negocios.Entidades;

namespace CL_Negocios.Empleados
{
    public class CL_AdministrarEmpleados
    {
        // Instancia de la clase de la capa de datos para registrar empleados
        private CD_RegistrarEmpleado registrarEmpleado = new CD_RegistrarEmpleado();

        // Método para guardar un nuevo empleado
        public void GuardarEmpleado(Persona persona)
        {
            if (string.IsNullOrEmpty(persona.Nombre) || string.IsNullOrEmpty(persona.Apellido))
            {
                throw new ArgumentException("El nombre y apellido son obligatorios.");
            }

            registrarEmpleado.GuardarNuevoEmpleado(persona);
        }
        public DataTable ObtenerEmpleadoPorApellido(string apellido)
        {
            return registrarEmpleado.BuscarEmpleadosPorApellido(apellido);
        }

        public DataTable ObtenerEmpleadoPorDNI(string dni)
        {
            return registrarEmpleado.BuscarEmpleadosPorDNI(dni);
        }
            public void ModificarPersona(Persona persona) //EDITAR
             {

                 try
                 {

                     registrarEmpleado.ModificoPersona(persona);

                 }
                 catch (Exception ex)
                 {

                     Console.WriteLine("Ocurrió un error al guardar el proveedor: " + ex.Message);
                 }
             }
        public void ELiminarEmpleado(int id) //ELIMINAR
        {
            try
            {

                registrarEmpleado.EliminoEmpleado(id);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocurrió un error al eliminar el proveedor: " + ex.Message);
            }
        }

    }

}