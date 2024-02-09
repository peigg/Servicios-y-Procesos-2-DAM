using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartServer()
        {
            server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            DisplayMessage("Servidor esperando conexiones...");

            // El servidor se quedará esperando conexiones entrantes
            Thread serverThread = new Thread(new ThreadStart(ListenForClients));
            serverThread.Start();
        }

        private void ListenForClients()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                DisplayMessage("Cliente conectado.");

                stream = client.GetStream();

                // Cada cliente nuevo se manejará en un hilo separado
                Thread clientThread = new Thread(new ThreadStart(HandleClientComm));
                clientThread.Start();

                // Mostrar el formulario del servidor
                this.BeginInvoke(new Action(() =>
                {
                    this.Show();
                }));
            }
        }

        private void HandleClientComm()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    DisplayMessage("Mensaje del cliente: " + message);

                    // Aquí puedes procesar el mensaje y enviar una respuesta al cliente si es necesario.

                    Array.Clear(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    DisplayMessage("Error al recibir datos, se ha desconectado el cliente del servidor: ");
                    break;
                }
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplayMessage), message);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
            Application.Exit(); // Cierra la aplicación después de detener el servidor
        }

        private void StopServer()
        {
            stream.Close();
            client.Close();
            server.Stop();
            DisplayMessage("Servidor detenido.");
        }
    }
}
