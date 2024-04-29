﻿using System;
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
            //strBuild.UserID = "root";
            strBuild.Password = "almaeper";
            //strBuild.Password = "";
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
            sqlStatement = $"SELECT passwd, salt FROM `userdata` " +
                $"WHERE username = '{user}';";
            try
            {
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;
                int counter = 0;

                byte[] buffer_pass = new byte[255];
                byte[] buffer_salt = new byte[255];
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                    reader.GetBytes(0,0,buffer_pass,0,255);
                    reader.GetBytes(1, 0, buffer_salt, 0, 255);

                }
                dbconn.Close();
                if (counter == 1)
                {
                    GenerateHash hash = new GenerateHash();

                    if (hash.CompareHashValues(buffer_pass, hash.GenerateHashValue(Encoding.ASCII.GetBytes(password), buffer_salt)))
                    {
                        return true;
                    }
                        
                    
                    else
                    {
                        Console.WriteLine("comapre values failed.");
                        //Console.WriteLine(hashedpass);
                        //Console.WriteLine(Convert.ToBase64String(hash.GenerateHashValue(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(salt))));
                        return false;
                    }
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
        
        public User SelectCustomUser(string username, string password)
        {

            try
            {
                User user;
                sqlStatement = $"SELECT userid, username, email FROM `userdata`" +
                    $"WHERE username = '{username} and passwd = '{password}';";
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                reader = command.ExecuteReader();



                user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));



                dbconn.Close();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine("SelectCustomUser: " + e);
                return null;
            }
            
        }

        public void InsertUser(string username, string email, string passwd, string salt)
        {
            try
            {
                sqlStatement = $"INSERT INTO `userdata`( `username`, `email`, `passwd`, `salt`) "+
                    $"VALUES ('{username}','{email}','{passwd}','{salt}');";
                dbconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                command.ExecuteNonQuery();
                Console.WriteLine("Sikeresen hozzáadva.");


                dbconn.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("InsertUser: " + e);
            }
        }


    }
}
