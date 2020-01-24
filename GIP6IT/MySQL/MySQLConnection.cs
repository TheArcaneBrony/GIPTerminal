using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security.Cryptography;

namespace Database.MySQL
{
    class MySQLConnection
    {
        private MySqlConnection connection;
        private static string server = "thisisit.cc";
        private static string database = "thisisit-workshops";
        private static string uid="thisisit";
        private static string password = "FunnyMoments420";
        public bool Connected = false;
        public static MySQLConnection Connect()
        {
            MySQLConnection conn = new MySQLConnection();
            try
            {
                conn.connection = new MySqlConnection($"SERVER={server};UID={uid};PASSWORD={password};DATABASE={database}");
                conn.Connected = true;
            }
            catch
            {
                throw;
                return conn;
            }
            return conn;
        }
        public bool Insert()
        {
            return false;
        }
        public void Get(string query, string table)
        {
            MySqlCommand cmd = new MySqlCommand($"select {query} from {table}");
        }
        public int GetNum()
        {

            return 0;
        }
    }
}
