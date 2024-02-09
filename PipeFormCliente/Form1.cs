using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeFromCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteEnvio = new NamedPipeClientStream(".", "clientPipe", PipeDirection.Out);

                clienteEnvio.Connect();

                // Creamos un buffer y le paso el valor de nuestro textbox
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(txtMensaje.Text);

                // Lo enviamos
                clienteEnvio.Write(buffer, 0, buffer.Length);

                clienteEnvio.Close();
            }
            catch(Exception ex) 
            {
                // Maneja las excepciones, por ejemplo, muestra un mensaje de error
                txtSistema.AppendText("Error al enviar el mensaje");
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {

            // Muestra un mensaje indicando que el servidor está activado
            txtSistema.AppendText("El cliente está listo para recibir mensajes\n");
            var ServerPipe = new NamedPipeServerStream("clientPipe", PipeDirection.In);

            // Bucle para esperar respuestas
            ServerPipe.WaitForConnection();

            byte[] buffer = new byte[255];
            ServerPipe.Read(buffer, 0, 255);

            // Se asigna el valor
            txtMensajes.Text = ASCIIEncoding.ASCII.GetString(buffer);

            // Refresca los datos
            Refresh();

            ServerPipe.Close();

        }
    }
}
