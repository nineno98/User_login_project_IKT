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
        private ConnectToDatabase ConnectToDatabase;
        private User logged_user;


        public LoginProgram()
        {
            is_authenticated = false;
            ConnectToDatabase = new ConnectToDatabase();
            
        }

        public void Login()
        {
            Console.WriteLine("***Sziper-szuper bejelentkező program 4000***");

            while (true)
            {
                Console.Write("Felhasználónév: ");
                string username = GetInput();

                if (ConnectToDatabase.FindUsername(username))
                {
                    Console.Write("Jelszó: ");
                    string password = GetInput();

                    if (ConnectToDatabase.CheckPasswdForUser(username, password))
                    {
                        is_authenticated = true;
                        logged_user = new User(1, username);
                        Console.WriteLine("Sikeres bejelentkezés.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hibás jelszó.");
                    }
                }
                else
                {
                    Console.WriteLine("Hibás felhasználónév.");
                }
            }


            /*Console.Write("Felhasználónév: ");
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
            return true;*/
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