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
        private List<string> LsTableHead = new List<string>();
        private int CurrentID = 0;

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

        //Liest die aktuell höchste ID aus
        private int GetMaxID(string ConnectionString, string Table)
        {
            int iID = 0;

            MySqlConnection MeineCon = new MySqlConnection(ConnectionString);
            MeineCon.Open();
            

            //Definiert das Komando und bereitet es für die ausführung vor. 
            string sGetHeadCommand = "SELECT ID FROM " + Table +" WHERE ID=(SELECT MAX(ID) FROM "+Table+")";
            MySqlCommand cmd = new MySqlCommand(sGetHeadCommand, MeineCon);

            //Führt das Kommando aus
            MySqlDataReader HeaderReader = cmd.ExecuteReader();

            //Konvertiert die Rückgabewerte in den Kopf
            while (HeaderReader.Read())
            {
                //LsTableHead.Add(Convert.ToString(HeaderReader.GetString(0)));
                //ID=Convert.ToString(HeaderReader.GetString(0));
                iID = Convert.ToInt32(HeaderReader.GetString(0));
                iID++;
            }
            MeineCon.Close();
            return iID;
        }

        //Ruft die aktuelle Systemzeit ab
        private string GetSystemTime()
        {
            string sZeit = "";
            //ToDo
            //Funktion schrieben, welche die aktuelle Systemzeit wieder zurückgibt
            sZeit = DateTime.Now.ToString();
            return sZeit;
        }

        //Mehtode dient dazu, übergebene Werte in die Datenbank zu schreiben.
        public void InsertIntoMySQL(string ConnectionString, string MyTable, int Funktion, string OS_Version)
        {
            //Variables
            int iID = 0;
            string sZeit = "";

            //Ruft Methode aus Zeile 14 auf, welches den Tabellenkopf abruft und in die Liste LsTableHead schriebt
            SetTableHead(ConnectionString,MyTable);
            
            //Ruft die aktuell höchste ID aus der Datenbank +1 ab
            iID=GetMaxID(ConnectionString, MyTable);

            //Ruft die aktuelle Systemzeit ab
            sZeit = GetSystemTime();

            //Aus Spalten Command zusammebauen
            string sCOMMANDTEXT = "INSERT INTO `"+MyTable+"`(`"+LsTableHead[0]+ "`, `" + LsTableHead[1] + "`, `" + LsTableHead[2] + "`, `" + LsTableHead[3] + "`) VALUES('"+iID+"', '"+Funktion+"', '"+sZeit+"', '"+OS_Version+"')";

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
