using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Database.Acces
{
    public class AccesConnection
    {
        OleDbConnection conn = new OleDbConnection();
        bool Connected = false;

        public static AccesConnection Connect()
        {
            AccesConnection Bruh = new AccesConnection();
            Bruh.conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source=access\Database_GIP.accdb";
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
            String my_query = $"INSERT INTO Inschrijvingen(Naam,E-mail,Workshop1, Workshop2)VALUES({Naam},{Email},{Workshop1},{Workshop2})";
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

        public int Getnum()
        {
            return 0;
        }

    }
}
