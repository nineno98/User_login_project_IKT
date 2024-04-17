using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace User_login
{
    class ConnectToDatabase
    {
        string sqlStatement, connstring;
        public ConnectToDatabase()
        {
            Initialize();
        }

        private void Initialize()
        {
            MySqlConnectionStringBuilder strBuild = new MySqlConnectionStringBuilder();
            strBuild.Server = "localhost";
            strBuild.UserID = 

        }
    }
}
