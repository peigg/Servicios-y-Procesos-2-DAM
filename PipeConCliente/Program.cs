using System.IO.Pipes;

namespace PipeConCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine);

            using (NamedPipeClientStream clientePipe = new NamedPipeClientStream(".", "servidor", PipeDirection.In))
            {
                Console.WriteLine("Se ha creado un objeto `NamedPipeClientStream`.");
                // Conexión a named pipe hasta que haya uno disponible: 
                Console.WriteLine("Intentando conectar a un named pipe...");
                clientePipe.Connect();

                Console.WriteLine("Se ha conectado a un servidor named pipe.");
                Console.WriteLine("Actualmente existen {0} named pipe en modo servidor abiertas.\n", clientePipe.NumberOfServerInstances.ToString());

                // Lectura de datos y envío de estos al cliente: 
                using (StreamReader sr = new StreamReader(clientePipe))
                {
                    // Lee el mensaje enviado desde el servidor: 
                    string mensajeServidorPipe;

                    while ((mensajeServidorPipe = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Mensaje recibido desde el servidor pipe: {0}", mensajeServidorPipe);
                    }
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
}