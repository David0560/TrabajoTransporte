using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CapaServicios.Entidades
{
    public class CorreoElectronico
    {
        private string smtpServer;
        private int smtpPort;
        private string smtpUser;
        private string smtpPass;

        public CorreoElectronico(string smtpServer, int smtpPort, string smtpUser, string smtpPass)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.smtpUser = smtpUser;
            this.smtpPass = smtpPass;
        }

        public void EnviarCuerpoMail(string toEmail, string username, string temporaryPassword)
        {
            string subject = "Bienvenido al sistema";
            string body = $"Te damos la bienvenida al sistema.\n" +
                          $"Tu usuario es: {username}\n" +
                          $"Tu password temporal es: {temporaryPassword}\n" +
                          $"Tienes 24 horas, una vez recibido el correo, para cambiar tu password.\n" +
                          $"De lo contrario, deberás solicitar uno nuevamente.";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(smtpUser);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false; // Cambia a true si quieres enviar HTML

                using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                {
                    smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
                    smtp.EnableSsl = true; // Cambia a false si tu servidor no requiere SSL
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (SmtpException smtpEx)
                    {
                        MessageBox.Show($"Error SMTP: {smtpEx.Message}");
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"Error de E/S: {ioEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
