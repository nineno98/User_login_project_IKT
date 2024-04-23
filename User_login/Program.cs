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
            loginProgram.Menu();
            Console.ReadKey();
        }
    }
}
