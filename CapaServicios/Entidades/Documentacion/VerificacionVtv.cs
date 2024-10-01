using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades
{
    public class VerificacionVtv
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Dominio {get;set;}
        public string Modelo { get; set; }
        public DateTime FechaOtorgado { get; set; }   
        public DateTime FechaVencimiento {  get; set; }    

        //
        // Metodos
        //
        public VerificacionVtv(int id, DateTime fechaO, DateTime fechaV)
        {
            this.Id = id;
            this.FechaOtorgado = fechaO;
            this.FechaVencimiento= fechaV;
        }

        public VerificacionVtv(int id, string nombre, string dominio, string modelo, DateTime fechaVencimiento)
        {
            Id = id;
            Nombre = nombre;
            Dominio = dominio;
            Modelo = modelo;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
