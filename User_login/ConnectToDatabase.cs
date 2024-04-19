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
        private string sqlStatement;
        List<User> userList = new List<User>();
        MySqlConnection dbconn;
        MySqlDataReader reader;
        User user;

        public ConnectToDatabase()
        {
          
            Initialize();
            
        }

        private void Initialize()
        {
            MySqlConnectionStringBuilder strBuild = new MySqlConnectionStringBuilder();
            strBuild.Server = "localhost";
            strBuild.UserID = "userloginclient";
            strBuild.Password = "almaeper";
            strBuild.Database = "userloginapp";

            
            dbconn = new MySqlConnection(strBuild.ToString());
            
        }

        public string GetVerison()
        {
            string response;
            sqlStatement = "SELECT version();";
            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                response = command.ExecuteScalar().ToString();
                dbconn.Close();
            }
            catch (Exception e)
            {
                response = e.Message;
                return response;
            }
            return response;
        }

        public bool ConnectionTest()
        {
            try
            {
                dbconn.Open();
                dbconn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public (int, int) Login(string username, string password)
        {
            sqlStatement = $"SELECT userid, username, email, passwd FROM `userdata` " +
                    $"WHERE username = '{username}' and passwd = '{password}';";
            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;



                



                dbconn.Close();
            }
            catch (Exception)
            {

                return (0,0);
            }
        }



    }
}
