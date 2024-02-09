using System.Diagnostics;
using System.IO.Pipes;

namespace PipeSinServidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process pipeClient = new Process();

            pipeClient.StartInfo.FileName = "D:\\Wrokspace\\Montecastelo23\\Modulos\\2DAM\\Servicios y Procesos\\Temario\\Bloque MultiProceso\\Temario\\Unidad 1Programacion de Procesos\\Codigos\\PipeSinCliente\\bin\\Debug\\net7.0\\PipeSinCliente.exe";

            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Console.WriteLine("[CLIENTE] Modo de transmisión actual: {0}.",
                    pipeServer.TransmissionMode);

                // Pasa al cliente un manejador para el servidor.
                pipeClient.StartInfo.Arguments =
                    pipeServer.GetClientHandleAsString();
                pipeClient.StartInfo.UseShellExecute = false;
                pipeClient.Start();

                pipeServer.DisposeLocalCopyOfClientHandle();

                try
                {
                    // Lee la entrada del usuario y los envía al proceso cliente.
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        // Envía un 'sync message' y espera a que lo reciba el cliente.
                        sw.WriteLine("SYNC");
                        pipeServer.WaitForPipeDrain();
                        // Envía la entrada de consola al proceso cliente.
                        Console.Write("[CLIENTE] Introduce mensaje: ");
                        sw.WriteLine(Console.ReadLine());
                    }
                }
                // Captura la IOException que se produce si la pipe se corrompe
                // o desconecta.
                catch (IOException e)
                {
                    Console.WriteLine("[CLIENTE] Error: {0}", e.Message);
                }
            }

            pipeClient.WaitForExit();
            pipeClient.Close();
            Console.WriteLine("[CLIENTE] Cliente saliendo. Servidor terminando.");
        }
    }
}