using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class CD_ConfiguracionPassword
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public CD_ConfiguracionPassword() { }

        public void GuardarConfiguracion(int minimo, int maximo, int intentos, bool mayusMinus, bool numerosLetras, bool especial, bool dosPasos, bool repetir, bool datosPersonales, bool preguntaSeguridad, bool nuevasPreguntas, bool bloqueoAuto, int diasBloqueo)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                string query = @"UPDATE Configuracion_password SET 
                                valor_minimo_caracteres = @Minimo,
                                valor_maximo_caracteres = @Maximo,
                                cantidad_intentos_fallidos = @Intentos,
                                combinacion_mayusculas_minusculas = @MayusMinus,
                                requerir_combinaciones_numeros_letras = @NumerosLetras,
                                uno_o_mas_caracteres_especiales = @Especial,
                                autenticacion_dos_pasos = @DosPasos,
                                repetir_contrasena_anterior = @Repetir,
                                no_incluir_datos_personales = @DatosPersonales,
                                realizar_pregunta_seguridad = @PreguntaSeguridad,
                                cargar_nuevas_preguntas = @NuevasPreguntas,
                                bloqueo_usuario_automatico = @BloqueoAuto,
                                dias_para_bloqueo = @DiasBloqueo
                                WHERE id = 1"; // Suponiendo que hay un único registro en la tabla

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Minimo", minimo);
                command.Parameters.AddWithValue("@Maximo", maximo);
                command.Parameters.AddWithValue("@Intentos", intentos);
                command.Parameters.AddWithValue("@MayusMinus", mayusMinus);
                command.Parameters.AddWithValue("@NumerosLetras", numerosLetras);
                command.Parameters.AddWithValue("@Especial", especial);
                command.Parameters.AddWithValue("@DosPasos", dosPasos);
                command.Parameters.AddWithValue("@Repetir", repetir);
                command.Parameters.AddWithValue("@DatosPersonales", datosPersonales);
                command.Parameters.AddWithValue("@PreguntaSeguridad", preguntaSeguridad);
                command.Parameters.AddWithValue("@NuevasPreguntas", nuevasPreguntas);
                command.Parameters.AddWithValue("@BloqueoAuto", bloqueoAuto);
                command.Parameters.AddWithValue("@DiasBloqueo", diasBloqueo);

                con.Open();
                command.ExecuteNonQuery();
                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
