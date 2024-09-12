using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Entidades
{
    public class PlanillaLaboral
    {
        public int id { get; set; }
        public int id_GrillaDelDia { get; set; }   
        public int Id_Emplado { get; set; }
        public int Id_Unidad {  get; set; }    
        public int id_Frecuencias {  get; set; }
        public TimeSpan HoraSalida {  get; set; }


        public PlanillaLaboral(int id, int id_grilla, int id_emple, int id_unid, int id_frec, TimeSpan hora)
        {
            this.id = id;
            this.id_GrillaDelDia = id_grilla;
            this.Id_Emplado = id_emple;
            this.Id_Unidad = id_unid;
            this.id_Frecuencias = id_frec;
            this.HoraSalida = hora;
        }
            



    }
}
