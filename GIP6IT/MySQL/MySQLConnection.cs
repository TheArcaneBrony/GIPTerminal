using MySql.Data.MySqlClient;

namespace Database.MySQL
{
    class MySQLConnection
    {
        private MySqlConnection connection;
        private static string server = "thisisit.cc";
        private static string database = "thisisit-workshops";
        private static string uid="ThisIsIt";
        private static string password = "FunnyMoments420";
        public bool Connected = false;
        public static MySQLConnection Connect()
        {
            MySQLConnection conn = new MySQLConnection();
            try
            {
                conn.connection = new MySqlConnection($"SERVER={server};UID={uid};PASSWORD={password};DATABASE={database}");
                conn.connection.Open();
                conn.Connected = true;
            }
            catch
            {
                throw;
            }
            return conn;
        }
        public int GetNumWorkshop(int WorkshopNumber, string Code)
        {
            MySqlCommand cmd = new MySqlCommand($"select * from inschrijvingen where workshop{WorkshopNumber} = '{Code}'", connection);
            int i = 0;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) i++;
            return i;
        }
    }
}
