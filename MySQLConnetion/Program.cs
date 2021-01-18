using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MySQLConnetion1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string DatabaseConnect = "server="+Database_Config.Get_Database_Server()+
                                     ";user id="+Database_Config.Get_Database_User()+
                                     ";password="+Database_Config.Get_Database_Password()+
                                     ";port=3306"+
                                     ";database="+Database_Config.Get_Database_Name();

            MySqlConnection MeineCon = new MySqlConnection(DatabaseConnect);
            MySqlDataReader Reader = null;

            

            //sMyCommand.CommandText = "Select * FROM Aufrufe";

            MySQLOperations Anfrage = new MySQLOperations();

           



            try
            {
                Anfrage.InsertIntoMySQL(DatabaseConnect, "Aufrufe", 6, 5, "Zeit", "1.565");   
                
                ////Inhalt auslesen.
                //MeineCon.Open();
                //string ReadCommand = "SELECT * FROM  Aufrufe";
                //cmd = new MySqlCommand(ReadCommand, MeineCon);
                //MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    Console.Write(Convert.ToString(reader.GetString(0)) + " ");
                //    Console.Write(Convert.ToString(reader.GetString(1)) + " ");
                //    Console.Write(Convert.ToString(reader.GetString(2)) + " ");
                //    Console.WriteLine(Convert.ToString(reader.GetString(3)));
                //}
                //MeineCon.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            MeineCon.Close();
            Console.ReadKey();
            
        }
    }
}
