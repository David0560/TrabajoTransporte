using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Diaria
{
    public class PlanillaLab
    {
        public int Id { get; set; }
        public int Id_GrillaDelDia { get; set; }
        public int Id_Frecuencias { get; set; }
        public int Id_Empleados { get; set; }
        public int Id_Unidad { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int KmSalida {  get; set; }
        public int CombustibleSalida { get; set; }
        public TimeSpan HoraLaboral { get; set; }


        public PlanillaLab(int id, int idGrilla, int idFrecuencia, int idEmpleado, int idUnidad, TimeSpan horaEntrada,
            TimeSpan horaSalida, int kmSalida, int CombuSalida)
        {
            this.Id = id;
            this.Id_GrillaDelDia = idGrilla;
            this.Id_Frecuencias = idFrecuencia;
            this.Id_Empleados = idEmpleado;
            this.Id_Unidad = idUnidad;
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
            this.KmSalida = kmSalida;
            this.CombustibleSalida = CombuSalida;
        }
        public PlanillaLab(int idGrilla, int idFrecuencia, int idEmpleado, int idUnidad, TimeSpan horaEntrada,
            TimeSpan horaSalida, int kmSalida, int CombuSalida) 
        {
            this.Id_GrillaDelDia = idGrilla;
            this.Id_Frecuencias = idFrecuencia;
            this.Id_Empleados = idEmpleado;
            this.Id_Unidad = idUnidad;
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
            this.KmSalida = kmSalida;
            this.CombustibleSalida = CombuSalida;
        }

        public PlanillaLab(int idFrecuencia, int idEmpleado, int idUnidad, TimeSpan horaSalida, TimeSpan horaEntrada)
        {
            this.Id_Frecuencias = idFrecuencia;
            this.Id_Empleados = idEmpleado;
            this.Id_Unidad = idUnidad;
            this.HoraSalida = horaSalida;
            this.HoraEntrada = horaEntrada;
        }

        public PlanillaLab(int id, int kmSalida, int CombuSalida, TimeSpan horaLabo)
        {
            this.Id = id;
            this.HoraLaboral = horaLabo;
            this.KmSalida = kmSalida;
            this.CombustibleSalida = CombuSalida;
        }
    }
}
