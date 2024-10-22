using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CL_Servicios.Entidades
{
    public class Vehiculo {
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

      /*  // Propiedades públicas
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }

        public string Dominio
        {
            get { return dominio; }
            set { dominio = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string MarcaMotor
        {
            get { return marcaMotor; }
            set { marcaMotor = value; }
        }

        public string NumeroMotor
        {
            get { return numeroMotor; }
            set { numeroMotor = value; }
        }

        public string MarcaChasis
        {
            get { return marcaChasis; }
            set { marcaChasis = value; }
        }

        public string NumeroChasis
        {
            get { return numeroChasis; }
            set { numeroChasis = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int CantidadPlazas
        {
            get { return cantidadPlazas; }
            set { cantidadPlazas = value; }
        }

        public decimal Km
        {
            get { return km; }
            set { km = value; }
        }

        public int IdCombustible
        {
            get { return idCombustible; }
            set { idCombustible = value; }
        }

        public DateTime FechaOtorgadoVTV
        {
            get { return fechaOtorgadoVTV; }
            set { fechaOtorgadoVTV = value; }
        }

        public DateTime FechaVencimientoVTV
        {
            get { return fechaVencimientoVTV; }
            set { fechaVencimientoVTV = value; }
        }
        public Vehiculo() { }
        public Vehiculo(DateTime fechaAlta, string dominio, string tipo, string marca,
                      string modelo, string marcaMotor, string numeroMotor, string marcaChasis,
                      string numeroChasis, string estado, int cantidadPlazas, decimal km,
                      int idCombustible, DateTime fechaOtorgadoVTV, DateTime fechaVencimientoVTV)
       : this (0, fechaAlta, dominio, tipo, marca, modelo, marcaMotor, numeroMotor, marcaChasis,
           numeroChasis, estado, cantidadPlazas, km, idCombustible, fechaOtorgadoVTV,
           fechaVencimientoVTV)
        { }
        public Vehiculo(int id, DateTime fechaAlta, string dominio, string tipo, string marca,
                     string modelo, string marcaMotor, string numeroMotor, string marcaChasis,
                     string numeroChasis, string estado, int cantidadPlazas, decimal km,
                     int idCombustible, DateTime fechaOtorgadoVTV, DateTime fechaVencimientoVTV)
        {

            this.id = id;
        }
        public Vehiculo(int id, string dominio, string tipo, string marca,
                   string modelo, string marcaMotor, string numeroMotor, string marcaChasis,
                   string numeroChasis, string estado, int cantidadPlazas, decimal km,
                   int idCombustible, DateTime fechaOtorgadoVTV, DateTime fechaVencimientoVTV)
        {

            this.id = id;
        }
    }
}*/