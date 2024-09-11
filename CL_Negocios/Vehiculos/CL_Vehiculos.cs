using System;
using CD_ConexionDatos;
using CL_Servicios.Entidades;
using CL_Negocios.Entidades; 

namespace CL_Negocios
{
    public class CL_Vehiculos
    {
        private CD_Vehiculos cdVehiculos;

        // Constructor que inicializa la clase de datos
        public CL_Vehiculos()
        {
            cdVehiculos = new CD_Vehiculos();
        }

        // Método para guardar un nuevo vehículo
        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                cdVehiculos.GuardarNuevoVehiculo(
                    vehiculo.FechaAlta,
                    vehiculo.Dominio,
                    vehiculo.Tipo,
                    vehiculo.Marca,
                    vehiculo.Modelo,
                    vehiculo.MarcaMotor,
                    vehiculo.NumeroMotor,
                    vehiculo.MarcaChasis,
                    vehiculo.NumeroChasis,
                    vehiculo.Estado,
                    vehiculo.CantidadPlazas,
                    vehiculo.Km,
                    vehiculo.IdCombustible
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el vehículo: " + ex.Message);
            }
        }
    }
}