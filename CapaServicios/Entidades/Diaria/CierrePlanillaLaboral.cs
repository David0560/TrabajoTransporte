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
        public int Id_Accidente { get; set; }
        public int Id_Lesionado { get; set; }
        public int Id_Testigo { get; set; }
        public int Id_Corte { get; set; }
        public TimeSpan HoraCierre { get; set; }
        public int KmLlegada { get; set; }
        public int CombustibleLlegada { get; set; }


        public CierrePlanillaLaboral(int id,int idAccidente, int idLesionado, int idTestigo, int idCorte, TimeSpan horaCierre, int kmLlegada, int CombuLlegada)
        {
            this.Id = id;
            this.Id_Accidente = idAccidente;
            this.Id_Lesionado = idLesionado;
            this.Id_Testigo = idTestigo;
            this.Id_Corte = idCorte;
            this.HoraCierre = horaCierre;
            this.KmLlegada = kmLlegada;
            this.CombustibleLlegada = CombuLlegada;
        }
    }
}
