using CapaServicios;
using CD_ConexionDatos;
using CD_ConexionDatos.Empleados;
using CD_ConexionDatos.Entidades;
using CD_ConexionDatos.Negocio;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarGrilla
    {
        DataTable tb = new DataTable();

        CD_GrillaDiaria cargar = new CD_GrillaDiaria();
        CS_servicios servicio = new CS_servicios();
        CD_listarTablas tabla = new CD_listarTablas();
        CD_Choferes chofer = new CD_Choferes();
        CD_Ramal Ramal = new CD_Ramal();


        public CL_AdministrarGrilla() { }

        public bool CrearNuevaRegistro(GrillaDiaria grilla)
        {
           cargar.guardarNuevaGrilla(grilla);
           return true;
        }
         
        public DataTable Frecunacia(int ramal)
        {
            return Ramal.FrecuenciaPorRamal(ramal);// devuelve la frecuencia del ramal seleccionado
        }
        public DataTable UnidadesActivas(DateTime fecha)
        {
            return chofer.obteneUnidadesConVTV(fecha); // devuelve la frecuencia del ramal seleccionado
        }
        public DataTable ChoferesQueTrabajan( DateTime fechaLicencia, int turno)
        {
            DataTable TablaTrabajan = new DataTable();
            TablaTrabajan.Columns.Add("legajo", typeof(int));
            TablaTrabajan.Columns.Add("Chofer", typeof(string));

            foreach (DataRow fila in chofer.obtenerTablaChoferesConLicenciaTurno(fechaLicencia, turno).Rows)
            {
                int id = Convert.ToInt32(fila["id"]);
                DateTime fechainicia = chofer.TrabajaEsteDia(id);
                if (Trabaja(fechaLicencia, fechainicia))
                {
                    TablaTrabajan.Rows.Add(fila["id"], fila["Apellido_Nombre"]);
                }
            }
             return TablaTrabajan;

        } //tabla con los choferes trabajan el dia x y el turno x
        private bool Trabaja(DateTime fecha, DateTime fechai)
        {
            int Dt = 4;
            int Df = 2;

            TimeSpan dife = fecha-fechai;
            int diferencia = dife.Days;
            int Resto = diferencia & (Dt + Df);
            if (Resto >= 4)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        public DataTable GenerarGrilla(int ramal, DateTime fecha)
        {
            DataTable total = new DataTable();

            total.Columns.Add("Nombre", typeof(string));//frecuencia
            total.Columns.Add("Unidad", typeof(string));//unidad
            total.Columns.Add("HoraInicio", typeof(TimeSpan)); //frecuencia
            total.Columns.Add("legajo", typeof(int));//chofer
            total.Columns.Add("Chofer", typeof(string)); //chofer
            total.Columns.Add("HoraEntrada", typeof(TimeSpan));
            total.Columns.Add("HoraFinTurno", typeof(TimeSpan));

            DataTable Frec = Frecunacia(ramal);
            DataTable Unidades = UnidadesActivas(fecha);
            DataTable ChoferesM = ChoferesQueTrabajan(fecha,1);
            DataTable ChoferesT = ChoferesQueTrabajan(fecha, 2);

            int CantidadU = Ramal.CantidadUnidadesRequeridas(ramal);
            int totalTurno = Ramal.CantidadUnidadesRequeridas(ramal) * 2;

            for (int i = 0; i< CantidadU; i++)
            {
                DataRow fila = Frec.Rows[i];
                DataRow fila2 = Unidades.Rows[i];
                DataRow fila3 = ChoferesM.Rows[i];  


                DataRow filaDestino = total.NewRow();
                filaDestino["Nombre"] = fila["Nombre"];
                filaDestino["HoraInicio"]= fila["HoraInicio"];
                TimeSpan entrada = (TimeSpan)filaDestino["HoraInicio"];
                filaDestino["Unidad"] = fila2["Nombre"];
                filaDestino["legajo"] = fila3["legajo"];
                filaDestino["Chofer"] = fila3["Chofer"];
                filaDestino["HoraEntrada"] = entrada - (TimeSpan.FromMinutes(20));
                TimeSpan salida = (TimeSpan)filaDestino["HoraEntrada"];
                filaDestino["HoraFinTurno"] = salida + (TimeSpan.FromHours(8));

                total.Rows.Add(filaDestino);
            }

            for (int j = 0; j < CantidadU; j++)
            {
                DataRow fila = Frec.Rows[CantidadU+j];
                DataRow fila2 = Unidades.Rows[j];
                DataRow fila3 = ChoferesT.Rows[j];


                DataRow filaDestino = total.NewRow();
                filaDestino["Nombre"] = fila["Nombre"];
                filaDestino["HoraInicio"] = fila["HoraInicio"];
                TimeSpan entrada = (TimeSpan)filaDestino["HoraInicio"];
                filaDestino["Unidad"] = fila2["Nombre"];
                filaDestino["legajo"] = fila3["legajo"];
                filaDestino["Chofer"] = fila3["Chofer"];
                filaDestino["HoraEntrada"] = entrada - (TimeSpan.FromMinutes(20));
                TimeSpan salida = (TimeSpan)filaDestino["HoraEntrada"];
                filaDestino["HoraFinTurno"] = salida + (TimeSpan.FromHours(8));

                total.Rows.Add(filaDestino);
            }


            return total;
        }


    }
}

