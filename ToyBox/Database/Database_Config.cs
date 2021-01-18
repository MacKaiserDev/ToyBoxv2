using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toybox
{
    class Database_Config
    {
        private string Database_Server = "itskk.de";
        private string Database_Name = "ToyBox";
        private string Database_User = "tbadmin";
        private string Database_Password = "T35455(4k_39009!";

        public string Get_Database_Server()
        {

            return Database_Server;
        }
        public string Get_Database_Name()
        {

            return Database_Name;
        }
        public string Get_Database_User()
        {

            return Database_User;
        }
        public string Get_Database_Password()
        {

            return Database_Password;
        }
    }
}
