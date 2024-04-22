using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public bool FindUsername(string username)
        {
            sqlStatement = $"SELECT passwd FROM `userdata` " +
                    $"WHERE username = '{username}';";
            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;
                int counter = 0;
                
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
                
                dbconn.Close();
                if (counter != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool CheckPasswdForUser(string user, string password)
        {
            sqlStatement = $"SELECT userid, username, email, passwd FROM `userdata` " +
                $"WHERE username = '{user}' and passwd = '{password}';";
            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;
                int counter = 0;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
                dbconn.Close();
                if (counter == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

               
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }

        public List<User> SelectUsers()
        {
            sqlStatement = "SELECT userid, username, email FROM `userdata`;";

            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    userList.Add(user);
                }

                dbconn.Close();
                return userList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return userList;
            }
        }
        


    }
}
