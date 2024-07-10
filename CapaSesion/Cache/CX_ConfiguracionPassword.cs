using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class CX_ConfiguracionPassword
    {
          public static int valor_minimo_caracteres { get; set; }
          public static int cantidad_intentos_fallidos { get; set; }
          public static bool  combinacion_mayusculas_minusculas{ get; set; }
          public static bool  requerir_combinaciones_numeros_letras{ get; set; }
          public static bool  uno_o_mas_caracteres_especiales{ get; set; }
          public static bool  autenticacion_dos_pasos{ get; set; }
          public static bool  repetir_contrasena_anterior{ get; set; }
          public static bool  no_incluir_datos_personales{ get; set; }
          public static bool  realizar_pregunta_seguridad{ get; set; }
          public static bool  cargar_nuevas_preguntas { get; set; }
          public static bool  bloqueo_usuario_automatico{ get; set; }
          public static int  dias_para_bloqueo{ get; set; }
          public static int  valor_maximo_caracteres{ get; set; }

    }
}
