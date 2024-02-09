// Program.cs en el proyecto Client
using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia de Form1 (cliente)
            Form1 clientForm = new Form1();

            // Iniciar el cliente en un hilo separado
            Thread clientThread = new Thread(() =>
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 8888))
                {
                    clientForm.ConnectToServer(client);
                    Application.Run(clientForm); // Mostrar el formulario del cliente
                }
            });

            clientThread.Start();
        }
    }
}
