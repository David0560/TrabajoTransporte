using CD_ConexionDatos.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarPlanillaCierre
    {
        CD_PlanillaCierre planillaC = new CD_PlanillaCierre();
        public DataTable ListaSalida(DateTime fecha)
        {
            return planillaC.ListaDeRegistrosCierre(fecha);
        }
    }
}
