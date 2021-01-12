using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ToyBox
{
    class Win32ServiceTools
    {
        //Funktion überprüft ob ein übergebener Windows Dienst installiert ist. 
        public static bool GetServiceInstallVerification(string ServiceName)
        {
            bool bDienstVorhanden = false;

            ServiceController[] ScServices = ServiceController.GetServices();

            foreach (ServiceController srvTarget in ScServices)
            {
                if(srvTarget.ServiceName == ServiceName)
                {
                    bDienstVorhanden = true;
                }
            }
            return bDienstVorhanden;
        }
    }
}
