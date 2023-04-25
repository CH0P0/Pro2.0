using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppSim
{
    internal class User
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
        
        static int cod = 1;


        public User(string Name, string Password, string Email, bool IsAdmin = false)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.IsAdmin = IsAdmin;
            CodUser = cod++;
        }

        public string GetName() => Name;

        public void SetName(string Name)
        {
            if (Name.Trim() != "")
                this.Name = Name.Trim();
        }

        public string GetPassword() => Password;

        /// <summary>
        /// Valida si una contraseña reune las características pera ser válida
        /// </summary>
        /// <param name="password">La contraseña a validar</param>
        /// <returns>Valor booleano que nos dice si es válida o no</returns>
        public static bool IsValidPassword(string password)
        {
            Regex rx = new Regex("^([a-zA-Z0-9]{8,16})$");
            return rx.IsMatch(password);
        }

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

        public int GetCodUser () => CodUser;    

        public void SetEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
                Email = newEmail;
        }

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

        public override string ToString() => $"\n\tCodigo de usuario:{GetCodUser()}\t\tNombre: {GetName}";

    }
}
