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
        private List<User> users;
        GenerateHash hashing;


        public LoginProgram()
        {
            is_authenticated = false;
            ConnectToDatabase = new ConnectToDatabase();
            hashing = new GenerateHash();
            users = new List<User> ();
            
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
                        users = ConnectToDatabase.SelectUsers();
                        logged_user = users.Where(x => x.Username_ == username).ToList().First();
                        Console.WriteLine(logged_user);

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

        public void Menu()
        {
            if (is_authenticated == true)
            {
                while (true)
                {
                    Console.WriteLine("\nVálassz a menüből: lista | kilepes");

                    string command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case "lista":
                            foreach (User item in users)
                            {
                                Console.WriteLine(item);
                            }
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
        }

        public void CreateNewUser()
        {
            Console.WriteLine("Új felhasználó hozzáadása");

            Console.WriteLine("Add meg a felhasználó nevét:");
            string username = GetInput();
            Console.WriteLine("Add meg a felhasználó email címét:");
            string email = GetInput();
            Console.WriteLine("Add meg a felhasználó jelszavát");
            string passwd = GetInput();
            byte[] salt = hashing.GenerateSaltValue(12);
            byte[] passwdbyte = hashing.GenerateHashValue(Encoding.ASCII.GetBytes(passwd), salt);

            ConnectToDatabase.InsertUser(username, email, passwdbyte, salt);
            //(string, string) hashed_res = hashing.GenerateHashValue(passwd, salt);
            //Console.WriteLine(hashed_res.Item1);
            //ConnectToDatabase.InsertUser(username, email, hashed_res.Item1, hashed_res.Item2);

        }
    }
}