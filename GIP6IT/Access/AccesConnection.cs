using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Diagnostics;

namespace Database.Acces
{
    public class AccesConnection
    {
        OleDbConnection conn = new OleDbConnection();
        bool Connected = false;

        public static AccesConnection Connect()
        {
            AccesConnection Bruh = new AccesConnection();
            Bruh.conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data source=access\Database_GIP.accdb";
            try
            {
                Bruh.conn.Open();
                Bruh.Connected = true;
            }
            catch
            {
                throw;
            }
            
            return Bruh;
        }

        public bool Insert(string Naam, string Email, string Workshop1, string Workshop2)
        {
            //conn.Open();
            String my_query = $"INSERT INTO Inschrijvingen (Naam, Email, Workshop1, Workshop2) VALUES ('{Naam}','{Email}','{Workshop1}','{Workshop2}')";
            Debug.WriteLine(my_query);
            OleDbCommand cmd = new OleDbCommand(my_query, conn);
            cmd.ExecuteNonQuery();
            //    conn.Close();

            return true;
        }

        public void Get(string Naam)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select * from Inschrijvingen where Naam = {Naam}";
            OleDbDataReader Reader = cmd.ExecuteReader();

        }

    }
}
