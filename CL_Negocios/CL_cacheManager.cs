using System;
using System.Collections.Generic;
using CD_ConexionDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    internal class CL_cacheManager
    {
        private List<cachePermisosAlta> listaRoles;

        public CL_cacheManager() //constructor
        {
            listaRoles = new List<cachePermisosAlta>(); // creo una lista de roles
        }

        public void agregarRoles (cachePermisosAlta roles)
        {
            listaRoles.Add(roles); // metodo que cargar un nuevo rol a la lista
        }

        public List<cachePermisosAlta> ObtenerRoles()
        {
            return listaRoles;
        }
        public void limpiarCache()// limpio la lista de roles
        {
            listaRoles.Clear();
        }
        


    }
}
