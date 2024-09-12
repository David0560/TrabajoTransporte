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
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarGrilla
    {
        DataTable dt = new DataTable();

        CD_GrillaDiaria cargar = new CD_GrillaDiaria();
        CS_servicios servicio = new CS_servicios();
        CD_listarTablas tabla = new CD_listarTablas();
        CD_Choferes chofer = new CD_Choferes();
        public CL_AdministrarGrilla() { }

        public bool CrearNuevaRegistro(GrillaDiaria grilla)
        {
           cargar.guardarNuevaGrilla(grilla);
           return true;
        }
         
        public DataTable GrillaPorRamal(int id, DateTime fecha)
        {
            return chofer.GrillaPorRamal(id);
            return (chofer.obtenerTablaChoferesConLicencia(fecha)); // 
        }

        public DataTable ChoferesQueTrabajan(DataTable chof, DateTime fechaLicencia)
        {
            DataTable TablaTrabajan = new DataTable();
            TablaTrabajan.Columns.Add("legajo", typeof(int));
            TablaTrabajan.Columns.Add("Chofer", typeof(string));

            foreach (DataRow fila in chofer.obtenerTablaChoferesConLicencia(fechaLicencia).Rows)
            {
                int id = Convert.ToInt32(fila["id"]);
                DateTime fechainicia = chofer.TrabajaEsteDia(id);
                if (Trabaja(fechaLicencia, fechainicia))
                {
                    TablaTrabajan.Rows.Add(fila["id"], fila["Apellido_Nombre"]);
                }
            }
             return TablaTrabajan;

        }

        public bool Trabaja(DateTime fecha, DateTime fechai)
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
    }
}
