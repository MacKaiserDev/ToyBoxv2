using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLConnetion1
{
    class MySQLOperations
    {
        public List<string> LsTableHead = new List<string>();

        //Diese Methode schriebt die Spaltennamen in die Liste LsTableHead
        private void SetTableHead(string ConnectionString, string Table)
        {
            MySqlConnection MeineCon = new MySqlConnection(ConnectionString);
            MeineCon.Open();

            //Definiert das Komando und bereitet es für die ausführung vor. 
            string sGetHeadCommand = "SHOW COLUMNS FROM "+Table;
            MySqlCommand cmd = new MySqlCommand(sGetHeadCommand, MeineCon);

            //Führt das Kommando aus
            MySqlDataReader HeaderReader = cmd.ExecuteReader();

            //Konvertiert die Rückgabewerte in den Kopf
            while (HeaderReader.Read())
            {
                LsTableHead.Add(Convert.ToString(HeaderReader.GetString(0)));
            }
            MeineCon.Close();
        }

        public void InsertIntoMySQL(string ConnectionString, string MyTable,int ID, int Funktion, string Zeit, string OS_Version)
        {
            //Variables
            string TableHead = "";

            //Ruft Methode aus Zeile 14 auf, welches den Tabellenkopf abruft
            SetTableHead(ConnectionString,MyTable);


            //Aus Spalten Command zusammebauen
            string sCOMMANDTEXT = "INSERT INTO `"+MyTable+"`(`"+LsTableHead[0]+ "`, `" + LsTableHead[1] + "`, `" + LsTableHead[2] + "`, `" + LsTableHead[3] + "`) VALUES('"+ID+"', '"+Funktion+"', '"+Zeit+"', '"+OS_Version+"')";

            //Verbindung vorbereiten
            MySqlConnection MeineCon = new MySqlConnection(ConnectionString);
            MeineCon.Open();

            //Bereitet Command vor
            MySqlCommand cmd = new MySqlCommand(sCOMMANDTEXT, MeineCon);
            //excute Command
            cmd.ExecuteNonQuery();     
         }

        public void GetMySqlData( string ConnectionString)
        {
            //SetTableHead(ConnectionString,);
        }
    }
}
