using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace Exchange_Test_eMailsender
{
    class PowershellController
    {

        public static List<string> SendToPowershell(string Argument)
        {
            //Gibt bei Aufruf eine Liste mit der Ausgabe des Powertshell Aufrufes zurück. 
            //Link zum Artikel https://gist.github.com/miteshsureja/f9cbc2f09264a01277a6555a7425debc
            List<string> Ergebnisse = new List<string>();

            PowerShell PowershellInst = PowerShell.Create();
            PowershellInst.AddScript(Argument);
            
            Collection<PSObject> PSOutput = PowershellInst.Invoke();
           
            foreach (var item in PSOutput)
            {
                Ergebnisse.Add(item.ToString());
            }

            return Ergebnisse;
        }
    }
}
