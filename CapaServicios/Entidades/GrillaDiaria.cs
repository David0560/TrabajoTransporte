using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Entidades
{
    public class GrillaDiaria
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime horaEmision { get; set; }

        public GrillaDiaria(int id, DateTime fecha, DateTime horaE)
        {
            this.id = id;
            this.Fecha = fecha;
            this.horaEmision = horaE;
        }
        public GrillaDiaria(DateTime fecha, DateTime horaE)
        {
            this.Fecha = fecha;
            this.horaEmision = horaE;
        }


    }




}
