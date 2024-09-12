using System;

namespace CL_Servicios.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Dominio { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string MarcaMotor { get; set; }
        public string NumeroMotor { get; set; }
        public string MarcaChasis { get; set; }
        public string NumeroChasis { get; set; }
        public string Estado { get; set; }
        public int CantidadPlazas { get; set; }
        public decimal Km { get; set; }
        public int IdCombustible { get; set; }
        public DateTime FechaOtorgadoVTV { get; set; }
        public DateTime FechaVencimientoVTV { get; set; }
    }
}