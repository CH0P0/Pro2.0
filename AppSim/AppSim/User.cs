using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppSim
{
    public class User
    {
        /// <summary>
        /// Este atributo representa el nombre del usuario.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// Este atributo representa la contraseña del usuario.
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// Este atributo representa el email del usuario.
        /// </summary>
        private string Email { get; set; }
        /// <summary>
        /// Este atributo representa el codigo del usuario,
        /// para cada uno es único
        /// </summary>
        private int CodUser { get;}

        /// <summary>
        /// Este atributo distingue a los administradores.
        /// </summary>
        private bool IsAdmin { get; set; }
        
        public static int cod = 1;


        public User(string Name, string Password, string Email, bool IsAdmin = false)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.IsAdmin = IsAdmin;
            CodUser = cod++;
        }

        public User(int CodUser, string Name, string Password, string Email, bool IsAdmin = false)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.IsAdmin = IsAdmin;
            this.CodUser = CodUser;
        }

        public string GetName() => Name;

        public void SetName(string Name)
        {
            if (Name.Trim() != "")
                this.Name = Name.Trim();
        }

        /// <summary>
        /// Valida si una contraseña reune las características pera ser válida
        /// </summary>
        /// <param name="password">La contraseña a validar</param>
        /// <returns>Valor booleano que nos dice si es válida o no</returns>
        public static bool IsValidPassword(string password)
        {
            Regex rx = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
            return rx.IsMatch(password);
        }

        public string GetPassword() => Password;  

        public void SetPassword(string newPassword)
        {
            if (IsValidPassword(newPassword))
                Password = newPassword;
        }
        
        public string GetEmail() => Email;

        /// <summary>
        /// Valida si un email reune las características pera ser válido
        /// </summary>
        /// <param name="password">El email a validar</param>
        /// <returns>Valor booleano que nos dice si es válido o no</returns>
        public static bool IsValidEmail(string email)
        {
            Regex rx = new Regex("^[a-zA-Z0-9]{1,}@gmail.com$");
            return rx.IsMatch(email);
        }


        public void SetEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
                Email = newEmail;
        }
        public int GetCodUser () => CodUser; 
        
        public bool GetIsAdmin() => IsAdmin;

        public void ChangeUserName()
        {
            string newName = Functions.ReadString("Introduzca el nuevo nombre de usuario: ", 1);
            SetName(newName);
        }

        /// <summary>
        /// Método que permite al usuario cambiar su contraseña
        /// </summary>
        public void ChangePassword()
        {
            string newPassword, againNewPassword;
            do
            {

                Console.WriteLine("Introduzca una contraseña entre 8 y 16 caracteres con minúsculas, mayúsculas y dígitos");
                do
                {
                    newPassword = Functions.ReadString("Introduzca la nueva contraseña: ", 8, 16);
                    againNewPassword = Functions.ReadString("Introduzca de nuevo la contraseña: ", 8, 16);

                } while (newPassword != againNewPassword);
            } while (!IsValidPassword(newPassword));
            SetPassword(newPassword);
        }

        /// <summary>
        /// Método que cifra la contraseña del usuario antes
        /// de guardarla en la base de datos para evitar 
        /// filtraciones
        /// </summary>
        /// <param name="movement">
        /// número importante para esta función, por
        /// seguridad no se dara más especificaciones
        /// </param>
        /// <returns>La contraseña cifrada</returns>
        public string Cipher(int movement)
        {
                string cipherPassword = "";
                foreach (char c in GetPassword())
                    if (char.IsLetter(c)) // Si el caracter es una letra, se cifra mediante el desplazamiento
                        cipherPassword += (char)(((int)c + movement - 65) % 26 + 65); // Agregar la letra cifrada al resultado
                    else if (char.IsDigit(c)) // Si el caracter es un número, se cifra mediante el desplazamiento
                        cipherPassword += (char)(((int)c + movement - 48) % 10 + 48); // Agregar el número cifrado al resultado
                    else // Si el caracter no es una letra ni un número, se agrega tal cual al resultado
                        cipherPassword += c;
            cipherPassword += movement;
                return cipherPassword; // Devolver el resultado del cifrado
        }

        /// <summary>
        /// Método que descifra la contraseña del usuario antes
        /// de iniciar iniciar el programa
        /// </summary>
        /// <param name="movement">
        /// número importante para esta función, por
        /// seguridad no se dara más especificaciones
        /// </param>
        /// <returns>La contraseña descifrada</returns>
        public string UnCipher(int movement)
        {
            string uncipherPassword = ""; // Variable para almacenar el resultado

            foreach (char c in GetPassword())
                if (char.IsLetter(c)) // Si el caracter es una letra, se descifra mediante el desplazamiento
                    uncipherPassword += (char)(((int)c - movement - 65 + 26) % 26 + 65); // Agregar la letra descifrada al resultado
                else if (char.IsDigit(c)) // Si el caracter es un número, se descifra mediante el desplazamiento
                    uncipherPassword += (char)(((int)c - movement - 48 + 10) % 10 + 48); // Agregar el número descifrado al resultado
                else // Si el caracter no es una letra ni un número, se agrega tal cual al resultado
                    uncipherPassword += c;
            uncipherPassword.Remove(uncipherPassword.Length - 1, 1);
            return uncipherPassword; // Devolver el resultado del descifrado
        }




        /// <summary>
        /// Método que permite al usuario cambiar su email
        /// </summary>
        public void ChangeEmail()
        {
            string newEmail = Functions.ReadString("Introduzca el nuevo email: ", 1);

            while (!IsValidEmail(newEmail))
            {
                Console.WriteLine("Formato incorrecto, por favor introduzca un email válido");
                newEmail = Functions.ReadString("Introduzca el nuevo email: ", 1);
            }
                SetEmail(newEmail);
        }

        public override string ToString() => $"\n\tCodigo de usuario:{GetCodUser()}\t\tNombre: {GetName()}";

    }
}
