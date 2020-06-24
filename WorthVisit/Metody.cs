using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Controls;


namespace WorthVisit
{
    class Metody
    {
        public void nowafunkcja(ComboBox item)
        {

        }
        
        private List<ciekaweMiejsca> Miejsce { get; set; }
        public static List<ciekaweMiejsca> FillCombobox(string kontynent)
        {
            var Miejsce = new List<ciekaweMiejsca>();
            SQLiteConnection sqliteConn;
            SQLiteCommand sqliteCom;
            SQLiteDataReader sqliteRead;
            sqliteConn = new SQLiteConnection("Data Source = ciekawemiejsca.db; Version=3;");
            sqliteConn.Open();
            sqliteCom = sqliteConn.CreateCommand();
            sqliteCom.CommandText =
                "Select * from @kontynent;";
            sqliteCom.Parameters.AddWithValue("@kontynent", kontynent);
            sqliteCom.ExecuteNonQuery();
            sqliteRead = sqliteCom.ExecuteReader();
            while (sqliteRead.Read())
            {
                Miejsce.Add(new ciekaweMiejsca(
                    (string)sqliteRead["Nazwamiejsca"],
                    (string)sqliteRead["Kraj"],
                    (string)sqliteRead["Opis"],
                    (byte[])sqliteRead["zdjecie"]
                    ));

            }
            return Miejsce;
        }
        
        
    }
}

