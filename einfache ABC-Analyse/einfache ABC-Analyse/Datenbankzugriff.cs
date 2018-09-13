using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Domain;
using Domain.Access;

namespace einfache_ABC_Analyse
{
    class Datenbankzugriff
    {
        public static void Server_zum_verbinden()
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=stueckliste;userid=root;password=''");
            Anweisung_zum_ausführen(connection);
        }

        private static void Anweisung_zum_ausführen(MySqlConnection connection)
        {
            MySqlCommand Anweisung = connection.CreateCommand();
            Anweisung.CommandText = "SELECT * FROM stueckliste";
            Datenbank_auslesen(connection, Anweisung);
        }

        private static void Datenbank_auslesen(MySqlConnection connection, MySqlCommand Anweisung)
        {
            MySqlDataReader Reader;
            connection.Open();
            Reader = Anweisung.ExecuteReader();

            

            while (Reader.Read())
            {
                Daten dat = new Daten();
                dat.ID = (int)Reader.GetValue(0);
                dat.Bezeichnung = (string)Reader.GetValue(1);
                dat.Menge = (double)Reader.GetValue(2);
                dat.Wert = (double)Reader.GetValue(3);
                Access.Daten.Add(dat);
            }

            connection.Close();
        }
    }
}
