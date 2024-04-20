using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_login
{
    internal class LoginProgram
    {
        private bool is_authenticated;
        public ConnectToDatabase ConnectToDatabase { get; private set; }

        public LoginProgram()
        {
            is_authenticated = false;
            ConnectToDatabase = new ConnectToDatabase();
        }

        public bool Login()
        {
            Console.WriteLine("***Sziper-szuper bejelentkező program 4000***");

            Console.Write("Felhasználónév: ");
            string username = GetInput();

            Console.Write("Jelszó: ");
            string password = GetInput();

            if (!ConnectToDatabase.FindUsername(username))
            {
                Console.WriteLine("Hibás felhasználónév.");
                return false;
            }

            if (!ConnectToDatabase.CheckPasswdForUser(username, password))
            {
                Console.WriteLine("Hibás jelszó.");
                return false;
            }

            is_authenticated = true;
            Console.WriteLine("Sikeres bejelentkezés.");
            return true;
        }

        private string GetInput()
        {
            string input;
            do
            {
                input = Console.ReadLine();
            } while (input == "");

            return input;
        }
    }
}