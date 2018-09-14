using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace einfache_ABC_Analyse
{
    class Datenbankzugriff
    {
        public static DataTable Server_zum_verbinden(DataTable Daten)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=stueckliste;userid=root;password=''");
            Anweisung_zum_ausführen(connection, Daten);
            return Daten;
        }

        private static DataTable Anweisung_zum_ausführen(MySqlConnection connection, DataTable Daten)
        {
            MySqlCommand Anweisung = connection.CreateCommand();
            Anweisung.CommandText = "SELECT * FROM stueckliste";
            Datenbank_auslesen(connection, Anweisung, Daten);
            return Daten;
        }

        public static DataTable Datenbank_auslesen(MySqlConnection connection, MySqlCommand Anweisung, DataTable Daten)
        {
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Anweisung);

            connection.Open();
            Adapter.Fill(Daten);
            connection.Close();

            return Daten;
        }
    }
}
