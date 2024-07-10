using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public  class CS_ConfiguracionPassword
    {
          public  int valor_minimo_caracteres { get; set; }
          public  int cantidad_intentos_fallidos { get; set; }
          public  bool  combinacion_mayusculas_minusculas{ get; set; }
          public  bool  requerir_combinaciones_numeros_letras{ get; set; }
          public  bool  uno_o_mas_caracteres_especiales{ get; set; }
          public  bool  autenticacion_dos_pasos{ get; set; }
          public  bool  repetir_contrasena_anterior{ get; set; }
          public  bool  no_incluir_datos_personales{ get; set; }
          public  bool  realizar_pregunta_seguridad{ get; set; }
          public  bool  cargar_nuevas_preguntas { get; set; }
          public  bool  bloqueo_usuario_automatico{ get; set; }
          public  int  dias_para_bloqueo{ get; set; }
          public  int  valor_maximo_caracteres{ get; set; }

    }
}
