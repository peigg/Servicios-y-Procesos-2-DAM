using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        // Constructor predeterminado sin argumentos
        public Form1()
        {
            InitializeComponent();

            // Mostrar mensaje de inicio
            MessageBox.Show("La aplicación cliente está en ejecución.");
        }

        // Método adicional para establecer la conexión con el servidor
        public void ConnectToServer(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string mensajeBienvenida = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            // Mostrar mensaje de bienvenida en el hilo de la interfaz de usuario
            this.BeginInvoke(new Action(() =>
            {
                MessageBox.Show(mensajeBienvenida);
                this.Show(); // Mostrar el formulario del cliente
            }));

            // Asociar el evento FormClosing
            this.FormClosing += Form1_FormClosing;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (stream != null)
                {
                    string eleccion = txtEleccion.Text;

                    // Enviar elección al servidor
                    stream.Write(Encoding.ASCII.GetBytes(eleccion), 0, eleccion.Length);

                    // Recibir resultado del servidor
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string resultado = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Mostrar resultado en el hilo de la interfaz de usuario
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show(resultado);
                    }));
                }
                else
                {
                    // Mostrar mensaje en el hilo de la interfaz de usuario
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("No hay conexión al servidor.");
                    }));
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en el hilo de la interfaz de usuario
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Error al enviar o recibir datos: " + ex.Message);
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopClient();
        }

        private void StopClient()
        {
            if (stream != null)
                stream.Close();

            if (client != null)
                client.Close();
        }
    }
}
