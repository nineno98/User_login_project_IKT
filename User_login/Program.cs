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
            ConnectToDatabase connectToDatabase = new ConnectToDatabase();
            bool isUserValid = connectToDatabase.FindUsername("tester");
            Console.ReadKey();
        }
    }
}
