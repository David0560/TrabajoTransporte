using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Diaria.CierrePlanilla
{
    public class Accidente
    {
        public string Lugar { get; set; }
        public string Altura { get; set; }
        public TimeSpan Hora { get; set; }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int NumeroRegistro { get; set; }
        public string Domicilio { get; set; }
        public int Numero { get; set; }
        public int Telefono { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string TitularDelVehiculo { get; set; }
        public string Compañia { get; set; }
        public int NumeroPoliza { get; set; }

        public string Descripcion { get; set; }

        public Accidente(string lugar, string altura, TimeSpan hora, string apellido, string nombre, int numeroRegistro, string domicilio, int numero, int telefono, string marca, string modelo, string patente, string titularDelVehiculo, string compañia, int numeroPoliza, string descripcion)
        {
            Lugar = lugar;
            Altura = altura;
            Hora = hora;
            Apellido = apellido;
            Nombre = nombre;
            NumeroRegistro = numeroRegistro;
            Domicilio = domicilio;
            Numero = numero;
            Telefono = telefono;
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            TitularDelVehiculo = titularDelVehiculo;
            Compañia = compañia;
            NumeroPoliza = numeroPoliza;
            Descripcion = descripcion;
        }
    }
}
