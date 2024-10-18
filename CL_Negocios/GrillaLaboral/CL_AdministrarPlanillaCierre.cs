using CapaServicios.Entidades;
using CapaServicios.Entidades.Diaria;
using CapaServicios.Entidades.Diaria.CierrePlanilla;
using CD_ConexionDatos.Negocio;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarPlanillaCierre
    {
        CD_PlanillaCierre planillaC = new CD_PlanillaCierre();
        public DataTable ListaSalida(DateTime fecha)
        {
            return planillaC.ListaDeRegistrosCierre(fecha);
        }
        public DataTable verRegistro(int id)
        {
            return planillaC.registroCierre(id);
        }

        public bool GuardarCierre(CierrePlanillaLaboral objeto)
        {
            if (planillaC.GuardarRegitrosCierre(objeto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GuardarControlUnidad(ContolUnidad objeto, int id)
        {
            if (ValidarObjeto.TienePropiedadesConDatos(objeto))
            {
                // Guardar el objeto en la base de datos
                planillaC.GuardarContUni(objeto, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GuardarCortes(List<CorteViaPublica> corte, int id)
        {
            if (ValidarObjeto.TieneRegistros(corte))
            {
                foreach (var objeto in corte) // corregir el metodo si no tiene registro.
                {
                    if (ValidarObjeto.TienePropiedadesConDatos(objeto))
                    {
                        planillaC.GuardarCortes(objeto, id);
                        Console.WriteLine($"Nombre: {objeto.Lugar}, Valor: {objeto.Motivo}");
                    }
                    else
                    {
                        MessageBox.Show("el registro no tiene datos válidos.");
                    }
                }

            }
        }
    }
}
