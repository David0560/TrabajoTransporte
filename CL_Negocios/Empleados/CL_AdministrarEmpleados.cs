using System;
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

    }
}