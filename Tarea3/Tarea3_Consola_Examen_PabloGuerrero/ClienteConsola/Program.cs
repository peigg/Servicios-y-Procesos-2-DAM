using System;
using System.Net.Sockets;
using System.Text;

class ClientConsola
{
    static void Jugar(NetworkStream stream)
    {
        try
        {
            // Espera a recibir la señal del servidor para comenzar el juego
            byte[] data = new Byte[1024];
            Int32 bytes = stream.Read(data, 0, data.Length);
            String senalInicio = Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine(senalInicio);

            if (senalInicio.Trim() == "Comienza el Juego")
            {
                // Pide al cliente que elija y envía la elección al servidor
                Console.Write("Elige tu opción (piedra, papel o tijeras): ");
                string eleccionCliente = Console.ReadLine();
                data = Encoding.ASCII.GetBytes(eleccionCliente + "$");
                stream.Write(data, 0, data.Length);

                // Lee y muestra el resultado del juego
                data = new Byte[1024];
                bytes = stream.Read(data, 0, data.Length);
                String resultado = Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Resultado: " + resultado);

                // Pide al cliente si desea jugar nuevamente
                Console.Write("¿Quieres volver a jugar? (s/n): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "s")
                {
                    // Llama recursivamente a la función Jugar
                    Jugar(stream);
                }
                else
                {
                    // Envía un mensaje al servidor indicando la desconexión
                    string mensajeDesconexion = "desconectar$";
                    data = Encoding.ASCII.GetBytes(mensajeDesconexion);
                    stream.Write(data, 0, data.Length);
                }
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine($"Error de socket: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en la función Jugar: {ex.Message}");
        }
    }

    static void Main()
    {
        try
        {
            // Crear un cliente Tcp que se conectará a un servidor que escucha en la dirección IP '127.0.0.1' y puerto '8888'
            using (TcpClient tcpclnt = new TcpClient())
            {
                tcpclnt.Connect("127.0.0.1", 8888);

                Console.WriteLine("Te has conectado al servidor");

                Console.Write("Ingresa tu nombre: ");
                string nombreCliente = Console.ReadLine();

                // Codifica el nombre del cliente y lo envía al servidor
                using (NetworkStream stream = tcpclnt.GetStream())
                {
                    Byte[] data = Encoding.ASCII.GetBytes(nombreCliente + "$");
                    stream.Write(data, 0, data.Length);

                    // Espera a recibir y mostrar la señal de inicio del servidor
                    data = new Byte[1024];
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    String mensajeInicio = Encoding.ASCII.GetString(data, 0, bytes);
                    Console.WriteLine(mensajeInicio);

                    // Ejecuta la función Jugar para participar en el juego
                    Jugar(stream);
                }
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine($"Error de socket: {ex.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
