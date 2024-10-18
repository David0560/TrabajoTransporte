using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    public static class ValidarObjeto
    {
        public static bool TieneRegistros<T>(List<T> lista)
        {
            return lista != null && lista.Count > 0;
        }
        public static bool TienePropiedadesConDatos<T>(T objeto)
        {
            // Obtiene las propiedades de la clase
            PropertyInfo[] propiedades = typeof(T).GetProperties();

            foreach (var propiedad in propiedades)
            {
                var valor = propiedad.GetValue(objeto);

                // Verifica si la propiedad tiene un valor (no es null y no es un valor predeterminado)
                if (valor != null && !valor.Equals(GetValorPredeterminado(propiedad.PropertyType)))
                {
                    return true; // Encontró una propiedad con datos
                }
            }

            return false; // No encontró propiedades con datos
        }

        private static object GetValorPredeterminado(Type tipo)
        {
            return tipo.IsValueType ? Activator.CreateInstance(tipo) : null;
        }
    }
}
