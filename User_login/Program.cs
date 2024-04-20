using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace User_login
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectToDatabase connectToDatabase = new ConnectToDatabase();/*
            bool isUserValid = connectToDatabase.FindUsername("tester");
            Console.ReadKey();*/

            bool loggedIn = false;
            while (!loggedIn)
            {
                Console.WriteLine("***Sziper-szuper bejelentkező program 4000***");

                Console.Write("Felhasználónév: ");
                string username = Console.ReadLine();

                Console.Write("Jelszó: ");
                string password = Console.ReadLine();

                if (!connectToDatabase.FindUsername(username))
                {
                    Console.WriteLine("Hibás felhasználónév.");
                    continue;
                }

                if (!connectToDatabase.CheckPasswdForUser(username, password))
                {
                    Console.WriteLine("Hibás jelszó.");
                    continue;
                }

                loggedIn = true;
                Console.WriteLine("Sikeres bejelentkezés.");
            }

            // Bejelentkezés utáni menü
            while (loggedIn)
            {
                Console.WriteLine("\nVálassz a menüből: lista | kilepes");

                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "lista":
                        ListAllUsers(connectToDatabase);
                        break;
                    case "kilepes":
                        loggedIn = false;
                        break;
                    default:
                        Console.WriteLine("Érvénytelen parancs.");
                        break;
                }
            }

        }

        private static void ListAllUsers(ConnectToDatabase db)
        {
            Console.WriteLine("\nAz adatbázisban tárolt felhasználónevek:");

            List<User> users = db.SelectUsers();
            users.Sort((u1, u2) => u1.Unsername_.CompareTo(u2.Unsername_));

            foreach (User user in users)
            {
                Console.WriteLine($"- {user.Unsername_}");
            }
        }
    }
}
