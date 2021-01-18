using System;

namespace MySQLConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Database_Config.Get_Database_Server());


            Console.ReadKey();

        }
    }
}
