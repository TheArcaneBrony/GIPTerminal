using Database.MySQL;
using System;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQLConnection conn;
            Console.WriteLine($"Connecting to MySQL server: {(conn = MySQLConnection.Connect()).Connected}");

            Console.WriteLine($"Amount of people in workshop 1 doing PC Building: {conn.GetNumWorkshop(1, "PC")}");
            Console.ReadLine();
        }
    }
}
