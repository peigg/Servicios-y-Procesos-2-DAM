// Program.cs en el proyecto Server
using System;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia de Form1 (servidor)
            Form1 serverForm = new Form1();
            Application.Run(serverForm); // Mostrar el formulario del servidor

            // Iniciar el servidor en un hilo separado
            Thread serverThread = new Thread(() =>
            {
                serverForm.StartServer();
            });

            serverThread.Start();

            
        }
    }
}
