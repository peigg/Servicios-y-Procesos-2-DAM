using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiciosWin
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {
                // Mostrar propiedades para los servicios del sistema
                Console.WriteLine("Servicio: " + scTemp.DisplayName);
                Console.WriteLine("Status = " + scTemp.Status);
                Console.WriteLine("Can Pause and Continue = " + scTemp.CanPauseAndContinue);
                Console.WriteLine("Can ShutDown = " + scTemp.CanShutdown);
                Console.WriteLine("Can Stop = " + scTemp.CanStop);
                Console.WriteLine();

                if (scTemp.ServiceName == "QHActiveDefense") // "wuauserv")
                {
                    // Mostrar propiedades para el ejemplo de Simple Service
                    // del ejemplo de ServiceBase.
                    ServiceController sc = new ServiceController("QHActiveDefense"); //("wuauserv");// Poner el nombre del servicio a controlar
                    Console.WriteLine("Servicio: " + sc.DisplayName);
                    Console.WriteLine("Status = " + sc.Status);
                    Console.WriteLine("Can Pause and Continue = " + sc.CanPauseAndContinue);
                    Console.WriteLine("Can ShutDown = " + sc.CanShutdown);
                    Console.WriteLine("Can Stop = " + sc.CanStop);
                    Console.WriteLine();

                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        sc.Start();
                    }

                    while (sc.Status == ServiceControllerStatus.Running)
                    {
                        Thread.Sleep(1000);
                        sc.Refresh();
                        Console.WriteLine("Status = " + sc.Status);
                    }
     
                    while (sc.Status == ServiceControllerStatus.Paused)
                    {
                        Thread.Sleep(1000);
                        sc.Refresh();
                        Console.WriteLine("Status = " + sc.Status);
                    }

                    while (sc.Status == ServiceControllerStatus.StopPending)
                    {
                        Thread.Sleep(1000);
                        sc.Refresh();
                        Console.WriteLine("Status = " + sc.Status);
                    }

                    while (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        Thread.Sleep(1000);
                        sc.Refresh();
                        Console.WriteLine("Status = " + sc.Status);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


