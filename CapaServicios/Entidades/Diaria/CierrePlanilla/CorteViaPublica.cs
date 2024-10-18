using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Diaria.CierrePlanilla
{
    public class CorteViaPublica
    {
        public TimeSpan Hora { get; set; }
        public string Lugar { get; set; }
        public string Motivo { get; set; }
        public string Retomo { get; set; }
        public TimeSpan HoraSalida { get; set; }


        public CorteViaPublica(TimeSpan hora, string lugar, string motivo, string retomo, TimeSpan horasalida)
        {
            this.Hora = hora;
            this.Lugar = lugar;
            this.Motivo = motivo;
            this.Retomo = retomo;
            this.HoraSalida = horasalida;
        }
    }
}
