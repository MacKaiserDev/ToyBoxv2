using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ToyBox
{
    class CProcessStart
    {
        Process P = new Process();
        bool bShellExecute = true;

        //Übernimmt die Befehlszeilenargumente und führt diese aus. 
        public static void PStart(string sAnwendung, string sArgument1, string sArgument2, bool bShellExecute)
        {
            Process P = new Process();
            P.StartInfo.FileName = sAnwendung;
            P.StartInfo.CreateNoWindow = false;
            P.StartInfo.UseShellExecute = bShellExecute;
            P.StartInfo.Arguments = sArgument1 + sArgument2;
            //P.StartInfo.Verb = "runas /trustlevel:Administrator";
            P.Start();
        }
    }
}
