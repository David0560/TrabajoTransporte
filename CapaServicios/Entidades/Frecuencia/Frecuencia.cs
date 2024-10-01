using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Frecuencia
{
    public class Frecuencia
    {
        public int Id { get; set; } 
        public int Id_Ramal { get; set; }     
        public TimeSpan HoraInicio{ get; set; }


        // metodos
        public Frecuencia(int id,int id_ramal, TimeSpan horaIni)
        {
            this.Id = id;
            this.Id_Ramal = id_ramal;
            this.HoraInicio = horaIni;
        }
    }
}
