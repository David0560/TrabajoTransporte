using System;
using System.Data;
using CapaServicios.Entidades.Taller;
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

    // Método para guardar un nuevo artículo
    public void GuardarNuevoArticulo(Articulo articulo)
    {
        try
        {
            articuloData.GuardarArticulo(articulo); 
        }
        catch (Exception ex)
        {
            throw new Exception("Error al guardar el artículo: " + ex.Message);
        }
    }

    public DataTable ObtenerArticulosPorNombre(string nombreArticulo)
    {
        return articuloData.ObtenerArticulosPorNombre(nombreArticulo);
    }
}

}
