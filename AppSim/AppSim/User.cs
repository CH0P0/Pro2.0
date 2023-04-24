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
        private string Name { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private int CodUser { get;}
        static int cod = 1;


        public User(string Name, string Password, string Email)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            CodUser = cod++;
        }

        public string GetName() => Name;

        public void SetName(string Name)
        {
            if (Name.Trim() != "")
                this.Name = Name.Trim();
        }

        public string GetPassword() => Password;

        public void SetPassword(string newPassword)
        {
            Regex rx = new Regex("^([a-zA-Z0-9]{8,16})$");
            if (rx.IsMatch(newPassword))
                Password = newPassword;
        }
        
        public string GetEmail() => Email;
        public void SetEmail(string newEmail)
        {
            Regex rx = new Regex("^[a-zA-Z0-9]{1,}@gmail.com$");
            if (rx.IsMatch(newEmail))
                Email = newEmail;
        }

        public void ChangeUserName()
        {
            string newName = Functions.ReadString("Introduzca el nuevo nombre de usuario: ", 1);
            SetName(newName);
        }

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
            } while (Regex.IsMatch(newPassword, "^([a-zA-Z0-9]{8,16})$"));
            SetPassword(newPassword);
        }

        public void ChangeEmail()
        {
            string newEmail = Functions.ReadString("Introduzca el nuevo email: ", 1);

            while (Regex.IsMatch(newEmail, "^[a-zA-Z0-9]{1,}@gmail.com$"))
            {
                Console.WriteLine("Formato incorrecto, por favor introduzca un email válido");
                newEmail = Functions.ReadString("Introduzca el nuevo email: ", 1);
            }
             SetEmail(newEmail);
        }

    }
}
