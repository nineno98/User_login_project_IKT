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

            LoginProgram loginProgram = new LoginProgram();
            loginProgram.Login();
            Console.ReadKey();

            /*
            LoginProgram loginProgram = new LoginProgram();

            if (!loginProgram.Login())
            {
                Console.WriteLine("Sikertelen bejelentkezés.");
                return;
            }

            // Bejelentkezés utáni menü
            while (true)
            {
                Console.WriteLine("\nVálassz a menüből: lista | kilepes");

                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "lista":
                        ListAllUsers(loginProgram.ConnectToDatabase);
                        break;
                    case "kilepes":
                        Console.WriteLine("Viszlát!");
                        Environment.Exit(0);
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
            }*/
        }
    }
}
