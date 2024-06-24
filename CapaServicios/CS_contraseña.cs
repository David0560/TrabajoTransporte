using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaServicios
{
    public class CS_contraseña
    {
        private const string Minusculas = "abcdefghijklmnopqrstuvwxyz";
        private const string Mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Numeros = "0123456789";
        private const string CaracteresEspeciales = "!@#$%^&*()_+-=[]{}|;:,.<>?";

       
        public string crearContraseña(ConfiguracionPassword configure)
        {
            Random random = new Random();
            string passwordCharacters = Minusculas;

            if (configure.Mayuscula)
            {
                passwordCharacters += Mayusculas;
            }

            if (configure.Especial)
            {
                passwordCharacters += CaracteresEspeciales;
            }

            if (configure.Numero)
            {
                passwordCharacters += Numeros;
            }

            int passwordLargo = random.Next(configure.Minimo, configure.Maximo + 1);

            char[] password = new char[passwordLargo];
            for (int i = 0; i < passwordLargo; i++)
            {
                password[i] = passwordCharacters[random.Next(passwordCharacters.Length)];
            }

            return new string(password);
        }
        public string crearContraseñaRandom(int minimo, int maximo, bool mayusculas, bool numero, bool caracteresEspeciales)
            {
                Random random = new Random();
                string passwordCharacters = Minusculas;

                if (mayusculas)
                {
                    passwordCharacters += Mayusculas;
                }

                if (caracteresEspeciales)
                {
                    passwordCharacters += CaracteresEspeciales;
                }

                if (numero)
                {
                    passwordCharacters += Numeros;
                }

                int passwordLargo = random.Next(minimo, maximo + 1);

                char[] password = new char[passwordLargo];
                for (int i = 0; i < passwordLargo; i++)
                {
                    password[i] = passwordCharacters[random.Next(passwordCharacters.Length)];
                }

                return new string(password);
            }
        public string crearSHA256(string str1, string str2)
             {
                string valor = str1 + str2;
                 using (SHA256 sha256Hash = SHA256.Create())
                 {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(valor));
                     StringBuilder builder = new StringBuilder();
                     for (int i = 0; i < bytes.Length; i++)
                     {
                         builder.Append(bytes[i].ToString("x2"));
                     }
                     return builder.ToString();
                 }
             }
        public int crearCodigoVerificador(string str1, string str2)
            {
                string concatenacion = str1 + str2;

                string hex = "";
                foreach (char c in concatenacion)
                {
                    hex += String.Format("{0:X}", (int)c);
                }

                Console.WriteLine("Cadena en hexadecimal: " + hex);

                int sum = 0;
                bool second = false;
                for (int i = hex.Length - 1; i >= 0; i--)
                {
                    int num = int.Parse(hex[i].ToString(), System.Globalization.NumberStyles.HexNumber);

                    if (second)
                    {
                        num *= 2;
                        if (num > 9)
                        {
                            num = num - 9;
                        }
                    }

                    sum += num;
                    second = !second;
                }

                int luhn = 10 - (sum % 10);

                return luhn;

            }
        public bool validarPassword(string password, int minimo, int maximo, bool mayusculas, bool numeros, bool carateresEspeciales)
        {
            int minLength = minimo;
            int maxLength = maximo;
            
            if (password.Length < minLength || password.Length > maxLength)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    mayusculas = true;
                }
                else if (char.IsDigit(c))
                {
                    numeros = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    carateresEspeciales = true;
                }
            }

            return mayusculas && numeros && carateresEspeciales;
        }

       
    }
}
