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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        //Guardar Adicionales al Cierre.
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
        public bool GuardarRecorrida(List<CorteViaPublica> corte, List<Accidente> accidente, List<Lesionados> lesionado, List<Testigo> testigo, int id)
        {
            if (id != 0)
            {
                GuardarCortes(corte, id);
                GuardarAccidente(accidente, id);
                GuardarLesionados(lesionado, id);
                GuardarTestigo(testigo, id);
                return true;
            }
            else
            {
                return false;
            }
            
        }
       
        private void GuardarCortes(List<CorteViaPublica> corte, int id)
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
        private void GuardarAccidente(List<Accidente> accidente, int id)
        {
            if (ValidarObjeto.TieneRegistros(accidente))
            {
                foreach (var objeto in accidente) // corregir el metodo si no tiene registro.
                {
                    if (ValidarObjeto.TienePropiedadesConDatos(objeto))
                    {
                        planillaC.GuardarAccidente(objeto, id);
                    }
                    else
                    {
                    }
                }

            }
        }
        private void GuardarLesionados(List<Lesionados> lesionado, int id)
        {
            if (ValidarObjeto.TieneRegistros(lesionado))
            {
                foreach (var objeto in lesionado) // corregir el metodo si no tiene registro.
                {
                    if (ValidarObjeto.TienePropiedadesConDatos(objeto))
                    {
                        planillaC.GuardarLesionados(objeto, id);
                    }
                    else
                    {
                    }
                }
            }
        }
        private void GuardarTestigo(List<Testigo> testigo, int id)
        {
            if (ValidarObjeto.TieneRegistros(testigo))
            {
                foreach (var objeto in testigo) // corregir el metodo si no tiene registro.
                {
                    if (ValidarObjeto.TienePropiedadesConDatos(objeto))
                    {
                        planillaC.GuardarTestigo(objeto, id);
                    }
                    else  
                    {
                    }
                }
            }
        }







    }
}
