using System.Diagnostics;

namespace _3_Monitorizacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Process proceso1 = Process.Start("notepad");
            //string datos = "Proceso: " + proceso1.ProcessName + "\n" +
            //                "PID: " + proceso1.Id + "\n" +
            //                "Prioridad: " + proceso1.PriorityClass + "\n" +
            //                "Uso de memoria: " + proceso1.WorkingSet64 + " bytes" + "\n" +
            //                "Tiempo de CPU: " + proceso1.TotalProcessorTime + "\n" +
            //                "Hora de inicio: " + proceso1.StartTime + "\n";
            //Console.WriteLine(datos);
            //proceso1.Close();
            //Console.ReadKey();


            ////OBTENER PROCESO
            //Process proceso2 = new Process();
            //proceso2.StartInfo.FileName = "notepad";
            //proceso2.Start();
            //Console.WriteLine("El proceso2_bloc de notas se ha lanzado su PID es: {0} y su Nombre: {1}", proceso2.Id, proceso2.ProcessName);
            //string nombre = proceso2.ProcessName.ToString();
            //proceso2.Close();
            //Console.WriteLine("El proceso2_se ha cerrado, abriendo el proceso3. Pulsa una tecla.....");
            //Console.ReadKey();

            //Process proceso3 = new Process();
            //proceso3.StartInfo.FileName = nombre;
            //proceso3.Start();
            //Console.WriteLine("el proceso 3 es:{0} _ {1} ", proceso3.Id, proceso3.ProcessName);
            //Console.ReadKey();

            //Process proceso4 = new Process();
            //proceso4.StartInfo.FileName = nombre;
            //proceso4.Start();
            //Console.WriteLine("el proceso 4 es:{0} _ {1} ", proceso4.Id, proceso4.ProcessName);
            //Console.ReadKey();

            ////OBTENER PROCESOS DEL SISTEMA
            //Console.WriteLine("MOSTRAR LOS PROCESOS DEL SISTEMA....PULSA UNA TECLA ");
            //Console.ReadKey();
            //foreach (Process proceso in Process.GetProcesses())
            //{
            //    Console.WriteLine("NOMBRE: {0} -- PID: {1}", proceso.ProcessName, proceso.Id);            //   
            //}
            //Console.ReadKey();


            ///OBTENER PROCESOS DEL SISTEMA
            Console.WriteLine("Mostrando los procesos del sistema: ");
            Console.ReadKey();
            //conseguir los procesos del sistema
            var procesos = from objeto in Process.GetProcesses() orderby objeto.Id select objeto;
            //Recorremos los procesos
            foreach (var proceso in procesos)
            {
                //Sacamos por pantalla los procesos
                Console.WriteLine("PID: {0}, Nombre proceso: {1}", proceso.Id, proceso.ProcessName);
            }
            Console.ReadKey();

        }
    }
}