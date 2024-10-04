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
        public DataTable ObtenerProveedores()
        {
            return cdProveedores.ObtenerProveedores();
        }
        public DataTable ObtenerProveedoresPorEmpresa()
        {
            return cdProveedores.ObtenerProveedoresPorEmpresa();
        }
        public DataTable ObtenerProveedoresPorNombre()
        {
            return cdProveedores.ObtenerProveedoresPorNombre();
        }
        public  DataTable TraerProovedoresIdEmpresa(int id)
        {
            return cdProveedores.ObtenerProveedoresPorIdEmpresa(id);
        }
        public DataTable TraerProovedoresIdContacto(int id)
        {
            return cdProveedores.ObtenerProveedoresPorIdContacto(id);
        }
        public void GuardarProveedores(Proveedores proveedores)
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

    }
      
    }

