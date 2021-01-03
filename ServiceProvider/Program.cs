using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace ServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController SC = new ServiceController();

            ServiceController[] ScServices;
            ScServices = ServiceController.GetServices();

            foreach (ServiceController sctemp in ScServices)
            {
                if (sctemp.ServiceName == "Spooler")
                {
                    Console.WriteLine(sctemp.ServiceName + " - " + sctemp.DisplayName);
                }
               
            }

            Console.ReadLine();
        }
    }
}
