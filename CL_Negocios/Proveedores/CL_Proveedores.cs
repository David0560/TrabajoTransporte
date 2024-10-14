using System;
using CapaServicios.Entidades;
using System.Data;
using CD_ConexionDatos;
using System.Security.Cryptography.X509Certificates;
namespace CL_Negocios
{
    public class CL_Proveedores
    {

        private CD_Proveedores cdProveedores = new CD_Proveedores();
      

        public CL_Proveedores()
        {

        }
        public void ModificarProveedor(Proveedores proveedores) //EDITAR
        {

            try
            {

                cdProveedores.ModificoProveedor(proveedores);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocurrió un error al guardar el proveedor: " + ex.Message);
            }
        }
            public void GuardarProveedores(Proveedores proveedores) // ALTA
        {

            try
            {

                cdProveedores.GuardarProveedor(proveedores);
           
            }
            catch (Exception ex)
            {
             
              Console.WriteLine("Ocurrió un error al guardar el proveedor: " + ex.Message);
            }
        }
        public DataTable ObtenerProveedoresPorEmpresa(string nombreEmpresa)
        {
            return cdProveedores.ObtenerProveedoresPorEmpresa(nombreEmpresa);
        }

        public DataTable ObtenerProveedoresPorContacto(string contacto)
        {
            return cdProveedores.ObtenerProveedoresPorContacto(contacto);
        }
        public void ELiminarProveedores(int proveedoresid) //ELIMINAR
        {

            try
            {

                cdProveedores.EliminarProveedor(proveedoresid);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocurrió un error al eliminar el proveedor: " + ex.Message);
            }
        }
    }
      
    }

