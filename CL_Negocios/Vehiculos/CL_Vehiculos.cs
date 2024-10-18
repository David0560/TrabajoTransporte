using System;
using CD_ConexionDatos;
using CL_Servicios.Entidades;
using CL_Negocios.Entidades;
using CapaServicios.Entidades;
using System.Data;

namespace CL_Negocios
{
    public class CL_Vehiculos
    {
        private CD_Vehiculos cdVehiculos;

        public CL_Vehiculos()
        {
            cdVehiculos = new CD_Vehiculos();
        }

        // Método para guardar un nuevo vehículo
        public void GuardarVehiculo(Vehiculo vehiculo, DateTime fechaOtorgadoVTV, DateTime fechaVencimientoVTV)
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
                    vehiculo.IdCombustible,
                    fechaOtorgadoVTV,
                    fechaVencimientoVTV
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el vehículo: " + ex.Message);
            }
        }
        public DataTable ObtenerVehículosPorPatente(string patente)
        {
            return cdVehiculos.ObtengoVehículosPorPatente(patente);
        }
    }
}