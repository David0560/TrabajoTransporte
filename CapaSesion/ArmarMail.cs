using CapaServicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public static class ArmarMail
    {
        public static string DireccionCorreo { get; set; }
        public static string Asunto { get; set; }
        public static string NuevaContraseña { get; set; }
        public static string NombreUsuario { get; set; }

        public static void Preparar()
        {
            string body = @"
<!DOCTYPE html>
<html lang='es'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
            text-align: center;
        }
        .container {
            background: white;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            display: inline-block;
        }
        h1 {
            color: dodgerblue;
            font-size: 24px;
            margin: 0;
        }
        h2 {
            color: darkorange;
            font-size: 20px;
            margin: 10px 0 20px;
        }
        p {
            font-size: 16px;
            color: #555;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h1>BusManager</h1>
        <h2>Usuario: " + NombreUsuario + @"</h2>
        <p>Por cuestiones de seguridad, le hacemos llegar su nuevo password:</p>
        <h2>" + NuevaContraseña + @"</h2>
        <p>Recuerde que debe cambiar su contraseña dentro de las 24hs posteriores al recibir el mensaje.</p>
        <p>Pasado el tiempo mencionado quedará inactiva y tendra que generar una nueva.</p>
        <p>Le informamos que este correo no debe ser contestado.</p>
        <p>Saludos Cordiales,<br>Equipo de BusManager</p>
    </div>
</body>
</html>";
            CorreoElectronico.sendMail(DireccionCorreo, Asunto, body);
        }
    }
}
