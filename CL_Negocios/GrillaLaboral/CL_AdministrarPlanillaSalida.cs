using CapaServicios.Entidades.Diaria;
using CD_ConexionDatos.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarPlanillaSalida
    {
        CD_PlanillaLaboral planilla = new CD_PlanillaLaboral();
        CL_AdministrarGrilla grilla = new CL_AdministrarGrilla();
        public CL_AdministrarPlanillaSalida() { }

        public DataTable ListaSalida(DateTime fecha)
        {
            return planilla.ListaDeRegistros(fecha);
        }
        public DataTable VerRegistro(int id)
        {
            return planilla.ObtenerRegistro(id);
        }
        public DataTable SelecinarChoferes(DateTime fecha, int turno)
        {
            DataTable ChoferesM = grilla.filtradoDeChoferes(grilla.ChoferesQueTrabajan(fecha, turno), fecha); // turno mañana
            //DataTable ChoferesT = filtradoDeChoferes(ChoferesQueTrabajan(fecha, 2), fecha); // turno Tarde
            return ChoferesM;
        }
        public DataTable SeleccionarUnidades (DateTime fecha)
        {
            DataTable Unidades = grilla.UnidadesLibres(grilla.UnidadesActivas(fecha), fecha);
            return Unidades;
        }
        public bool CambiarRegistro(int id, int idE, int idU)
        {
            // puedo tener idE y idU para cambiar
            // solo idE o solo idU; --- 3 opiciones

            if (idE > 0 && idU > 0)
            {
                planilla.CambiarRecursos(idE, idU, id);
                return true;
            }
            else if (idE == 0 && idU  > 0) 
            {
                planilla.CambiarRecursosUnidad(idU, id);
                return true;
            }
            else if (idE > 0 && idU == 0)
            {
                planilla.CambiarRecursosChofer(idE, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        // guardar
        public bool guardarPlanilla(PlanillaLab pla)
        {
            if (planilla.CompletarPlanilla(pla))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
