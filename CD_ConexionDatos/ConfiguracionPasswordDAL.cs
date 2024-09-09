using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class ConfiguracionPasswordDAL
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion


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

                SqlCommand comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@Minimo", minimo);
                comando.Parameters.AddWithValue("@Maximo", maximo);
                comando.Parameters.AddWithValue("@Intentos", intentos);
                comando.Parameters.AddWithValue("@MayusMinus", mayusMinus);
                comando.Parameters.AddWithValue("@NumerosLetras", numerosLetras);
                comando.Parameters.AddWithValue("@Especial", especial);
                comando.Parameters.AddWithValue("@DosPasos", dosPasos);
                comando.Parameters.AddWithValue("@Repetir", repetir);
                comando.Parameters.AddWithValue("@DatosPersonales", datosPersonales);
                comando.Parameters.AddWithValue("@PreguntaSeguridad", preguntaSeguridad);
                comando.Parameters.AddWithValue("@NuevasPreguntas", nuevasPreguntas);
                comando.Parameters.AddWithValue("@BloqueoAuto", bloqueoAuto);
                comando.Parameters.AddWithValue("@DiasBloqueo", diasBloqueo);

                con.Open();
                comando.ExecuteNonQuery();
                int rowsAffected = comando.ExecuteNonQuery();
            }
        }
    }
    }
