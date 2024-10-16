using CD_ConexionDatos.Taller;
using System;
using System.Windows.Forms;

namespace CL_Negocios.Taller
{
    public class CL_RInsumos
    {
        private CD_RInsumos cdRInsumos = new CD_RInsumos();

        // Método para guardar registros de insumos
        public void GuardarRegistroInsumos(int idUsuario, int idProveedor, DataGridView dtListaArticulos, DateTime fechaEntrada)
        {
            // Se pasa la referencia del DataGridView a la capa de datos
            cdRInsumos.GuardarRegistroInsumos(idUsuario, idProveedor, dtListaArticulos, fechaEntrada);
        }
    }
}