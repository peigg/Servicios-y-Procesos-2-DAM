using System.Diagnostics;

namespace _4_Terminacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process proceso = new Process();
            ProcessStartInfo info = new ProcessStartInfo("cmd", "/c dir && notepad");

            //info.UseShellExecute = false;       //Ocultamos la consola
            info.UseShellExecute = true;

            proceso.StartInfo = info;
            proceso.Start();

            //proceso.Close();
            //proceso.Kill();

            // proceso.WaitForExit(10000);// 10 segundos de timeout

            if (!proceso.HasExited)
            {
                Console.WriteLine("......PROCESO NO TERMINADO");
                proceso.Kill();           // Finalizamos el proceso
            }
            else
            {
                Console.WriteLine(":):):):):)PROCESO TERMINADO");
            }
            Console.ReadKey();



            /// OBTENER PROCESOS DEL SISTEMA
            Process notas = Process.Start("notepad.exe");
            int pid = notas.Id;
            Console.WriteLine("Bloc de notas->PID: {0}", pid);
            Console.WriteLine("Mostrar los procesos del sistema y finalizar bloc de notas....PULSA UNA TECLA ");
            Console.ReadKey();

            //foreach (Process proceso in Process.GetProcesses())
            //{
            //    Console.WriteLine("NOMBRE: {0} -- PID: {1}", proceso.ProcessName, proceso.Id);
            //    if (proceso.ProcessName == "Notepad")
            //    {
            //        proceso.Kill();
            //    }
            //    //if (proceso.Id == pid)
            //    //{
            //    //    proceso.Kill();
            //    //}

            //}
            //Console.ReadKey();

        }
    }
}