using System.IO.Pipes;

namespace PipeSinCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                using (PipeStream pipeClient =
                    new AnonymousPipeClientStream(PipeDirection.In, args[0]))
                {
                    Console.WriteLine("[SERVIDOR] Modo de transmisión: {0}.",
                       pipeClient.TransmissionMode);

                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                        // Muestra el texto en consola
                        string temp;

                        // Espera por 'sync message' desde el servidor.
                        do
                        {
                            Console.WriteLine("[SERVIDOR] Esperando por sincronización...");
                            temp = sr.ReadLine();
                        }
                        while (!temp.StartsWith("SYNC"));

                        // Lee los datos del servidor y los muestra en consola.
                        while ((temp = sr.ReadLine()) != null)
                        {
                            Console.WriteLine("[SERVIDOR] Echo: " + temp);
                        }
                    }
                }
            }
            Console.Write("[SERVIDOR] Presione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}