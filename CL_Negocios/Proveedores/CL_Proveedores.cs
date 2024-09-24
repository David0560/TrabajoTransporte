﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Servicios.Entidades;
using CL_Negocios.Entidades;
using CD_ConexionDatos;
using CapaServicios.Entidades;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace CL_Negocios
{
    public class CL_Proveedores
    {
        
        private CD_Proveedores cdProveedores;
        private Proveedores proveedores;

        public CL_Proveedores()
        {
            cdProveedores = new CD_Proveedores();
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

                cdProveedores.GuardarProveedor(
                proveedores.NombreEmpresa,
                    proveedores.Contacto,
                    proveedores.Telefono,
                    proveedores.Email,
                    proveedores.Ciudad,
                    proveedores.Pais,
                    proveedores.Calle,
                    proveedores.Numero,
                    proveedores.CP);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el proveedor: " + ex.Message);
            }
        }
          public void  ModificarProveedores (int id, string nombreempresa, string Contacto,string telefono, string Email, string Ciudad, string Pais, string Calle, string Numero, int CP)
        { 
                try
                {

                    cdProveedores.ModificoProveedor(
                        id,
                    nombreempresa,
                        Contacto,
                        telefono,
                        Email,
                       Ciudad,
                        Pais,
                      Calle,
                       Numero,
                        CP);
                }
                catch (Exception ex)
                {
                throw new ApplicationException("Ocurrió un error al guardar el proveedor: " + ex.Message);
                }
            }
        //public List<Proveedores> BuscarProveedores(string nombreEmpresa, string contacto, string telefono, string email, string ciudad, string pais, string calle, string numero, int cp)
        //{
        //    return proveedores.BuscarProveedores(nombreEmpresa, contacto, telefono, email, ciudad, pais, calle, numero, cp);
        //}
    }
}
