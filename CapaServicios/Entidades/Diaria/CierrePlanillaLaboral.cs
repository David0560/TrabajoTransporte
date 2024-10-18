using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Diaria
{
    public class CierrePlanillaLaboral
    {
        public int Id { get; set; }
        public TimeSpan HoraCierre { get; set; }
        public int KmLlegada { get; set; }
        public int CombustibleLlegada { get; set; }


        public CierrePlanillaLaboral(int id,TimeSpan horaCierre, int kmLlegada, int CombuLlegada)
        {
            this.Id = id;
            this.HoraCierre = horaCierre;
            this.KmLlegada = kmLlegada;
            this.CombustibleLlegada = CombuLlegada;
        }
    }
}
