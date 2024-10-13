using System.Data;
using CD_ConexionDatos.Taller;

namespace CL_Negocios.Taller
{
    public class CL_Articulo
    {
        private CD_Articulo articuloData;
        public CL_Articulo()
        {
            articuloData = new CD_Articulo();
        }

        public DataTable ObtenerArticulosPorNombre(string nombreArticulo)
        {
            return articuloData.ObtenerArticulosPorNombre(nombreArticulo);
        }
    }
}
