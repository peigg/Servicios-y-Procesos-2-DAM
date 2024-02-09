using System.IO.Pipes;

namespace PipeConServidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine);

            using (NamedPipeServerStream servidorPipe = new NamedPipeServerStream("servidor", PipeDirection.Out))
            {
                Console.WriteLine("Se ha creado un objeto `NamedPipeServerStream`.");

                // Inicia la escucha de conexiones: 
                Console.WriteLine("A espera de conexiones de clientes...");
                servidorPipe.WaitForConnection();

                Console.WriteLine("Se ha conectado un cliente.");

                try
                {
                    // Lectura de datos y envío de estos al cliente: 
                    using (StreamWriter sw = new StreamWriter(servidorPipe))
                    {
                        sw.AutoFlush = true;
                        Console.WriteLine("Escriba mensaje para ser enviado al cliente: ");
                        sw.WriteLine(Console.ReadLine());
                    }
                }
                // En caso de se haya perdido la conexión con el cliente: 
                catch (IOException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
}