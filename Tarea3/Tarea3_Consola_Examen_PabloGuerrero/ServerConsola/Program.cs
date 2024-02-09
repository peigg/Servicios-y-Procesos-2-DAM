using System;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Collections;

class ServerConsola
{
    public static Hashtable lista_clientes = new Hashtable();
    public static int gan = new int();
    static void Main()
    {
        string jugadores;
        int numJugadores;

        //Menú de la aplicación servidor para el juego Piedra papel tijeras
        Console.WriteLine("______________________________________________");
        Console.WriteLine("  ");
        Console.WriteLine("\u001b[36m           Piedra, Papel, Tijeras             \u001b[0m");
        Console.WriteLine("______________________________________________");
        Console.WriteLine("         \u001b[33m____      \u001b[32m____       \u001b[35m           \u001b[0m");
        Console.WriteLine("        \u001b[33m/    \\    \u001b[32m|    |    \u001b[35m   \\/          \u001b[0m");
        Console.WriteLine("        \u001b[33m|     |  \u001b[32m |    |    \u001b[35m  _/\\_    \u001b[0m");
        Console.WriteLine("        \u001b[33m\\____/    \u001b[32m|____|    \u001b[35m|_|  |_|         \u001b[0m");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Elije la cantidad de jugadores, el mínimo es 1 y el máximo son 3: ");

        /*Definimos el número de jugadores(clientes), que se pueden conectar, en este caso son 3
          pero podría ampliarse.
         */
        jugadores = Console.ReadLine();
        numJugadores = int.Parse(jugadores);
        while (numJugadores < 1 || numJugadores > 3)
        {
            Console.WriteLine("No es una opcion valida, introduce una opción válida: ");
            jugadores = Console.ReadLine();
            numJugadores = int.Parse(jugadores);
        }
        Console.WriteLine("________________________________________________");
        Console.WriteLine("");
        Console.WriteLine("");

        // Parseamos la dirección IP 127.0.0.1 y le asignamos la variable 'ip'
        System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");

        // Creamos un objeto TcpListener que escuchará en la dirección IP 'ip' y el puerto 8888
        TcpListener serverSocket = new TcpListener(ip, 8888);

        // Inicializamos un objeto TcpClient con el valor predeterminado
        TcpClient clientSocket = default(TcpClient);

        int contador = 0;

        // Obtiene la dirección IP local del host
        IPAddress[] aryLocalAddr = null;
        String localhost = "";
        localhost = Dns.GetHostName();
        IPHostEntry ipEntry = Dns.GetHostEntry(localhost);
        aryLocalAddr = ipEntry.AddressList;

        // Inicia la escucha de conexiones en el objeto TcpListener
        serverSocket.Start();

        // Muestra un mensaje indicando que el servidor ha iniciado y está escuchando en la dirección IP y puerto especificados
        Console.WriteLine("Se ha iniciado el servidor, los clientes ya pueden conectarse");

        contador = 0;
        try
        {
            // Bucle para aceptar conexiones de clientes mientras el contador sea menor que 4 (límite de clientes)
                while (contador < 3)
            {
                string nombre;
                contador += 1;
                string nameClient = null;
                try
                {
                    // Acepta la conexión de un cliente y obtiene el flujo de red
                    clientSocket = serverSocket.AcceptTcpClient();
                    byte[] bytesFrom = new byte[1024];

                    // Obtiene el flujo de red del cliente y lee los datos enviados
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);

                    // Decodifica los datos recibidos en formato ASCII y extrae la cadena antes del delimitador "$"
                    nameClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    nameClient = nameClient.Substring(0, nameClient.IndexOf("$"));
                }
                 // Maneja cualquier excepción que pueda ocurrir al aceptar una conexión o leer datos
                 catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Source);
                }

                // Agregamos el nuevo cliente y su socket a la lista de clientes
                lista_clientes.Add(nameClient, clientSocket);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(nameClient + " Se ha conectado");
                

                // Crea una instancia de la clase handleClient para manejar las interacciones con el cliente actual
                handleClient client = new handleClient();

                //Iniciamos el cliente 
                client.startClient(clientSocket, nameClient, lista_clientes);
                nombre = nameClient;
                //Informamos de que se ha unido un cliente
                intercambio_datos(nameClient + " se ha unido", nameClient , false);
                
                System.Threading.Thread.Sleep(3000);

                if (lista_clientes.Count >= 1)
                {
                   

                    intercambio_datos(" El juego se iniciará en 3 segundos", nameClient, false);
                    System.Threading.Thread.Sleep(3000); // Espera 3 segundos
                    intercambio_datos("Comienza el Juego", nameClient, false);
                    juego();
                    intercambio_datos("El juego ha finalizado, gracias por Participar ", nameClient, false);
                    intercambio_datos("0", nameClient, false);
                    //Salimos del bucle
                    contador = 4;
                }
            }
        }
        // Manejo de excepciones con mensaje y tiempo de espera antes de cerrar los sockets
        catch (Exception e)
        {
            Console.WriteLine("NO hay usuarios conectados");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Source);
            System.Threading.Thread.Sleep(5000);
            clientSocket.Close();
            serverSocket.Stop();
        }
    }
    // Envío de mensajes a los clientes
    public static void intercambio_datos(string mensaje, string nombreCliente, bool esAccionEspecial)
    {
        try
        {
            // Itera a través de todos los clientes conectados
            foreach (DictionaryEntry item in lista_clientes)
            {
                // Obtiene el socket de red del cliente actual
                TcpClient clienteActual = (TcpClient)item.Value;

                // Obtiene el flujo de red del cliente
                NetworkStream streamCliente = clienteActual.GetStream();

                // Inicializa un array de bytes para almacenar el mensaje a ser transmitido
                byte[] bytesMensaje = null;

                // Verifica si se trata de una acción especial (esAccionEspecial == true)
                if (esAccionEspecial)
                {
                    // Aquí puedes definir lógica específica para acciones especiales si es necesario

                    // En este ejemplo, simplemente envía un mensaje indicando la acción especial
                    bytesMensaje = Encoding.ASCII.GetBytes("Acción especial: " + mensaje);
                }
                // Si esAccionEspecial es falso, simplemente transmite el mensaje normal
                else
                {
                    // En este caso, el mensaje sería el resultado del juego (piedra, papel, tijeras)
                    bytesMensaje = Encoding.ASCII.GetBytes(nombreCliente + ": " + mensaje + "$"); // Añadido "$" al final
                }

                // Escribe el mensaje en el flujo de red del cliente actual
                streamCliente.Write(bytesMensaje, 0, bytesMensaje.Length);

                // Limpia el flujo de red
                streamCliente.Flush();
            }
        }
        catch (Exception ex)
        {
            // Maneja cualquier excepción que pueda ocurrir durante la transmisión de mensajes
            Console.WriteLine($"Error en la función intercambio_datos: {ex.Message}");
            Console.WriteLine($"Origen: {ex.Source}");
        }
    }


    //Definimos las opciones
    private static string[] opciones = { "piedra", "papel", "tijeras" };
    //Instanciamos la clase Random
    private static Random random = new Random();
    public static void juego()
    {
        try
        {
            // Pide a cada cliente que elija entre piedra, papel o tijeras
            Dictionary<string, string> elecciones = new Dictionary<string, string>();

            foreach (DictionaryEntry item in lista_clientes)
            {
                TcpClient clientSocket = (TcpClient)item.Value;
                string nombreCliente = (string)item.Key;

                // Pide al cliente que elija y almacena su elección
                intercambio_datos("Elige tu opción (piedra, papel, tijeras): ", nombreCliente, false);
                string eleccionCliente = LeerEleccion(clientSocket);
                elecciones.Add(nombreCliente, eleccionCliente);
            }

            // Pide al servidor que elija aleatoriamente entre piedra, papel o tijeras
            string eleccionServidor = opciones[random.Next(opciones.Length)];

            // Muestra la elección del servidor a todos los clientes
            intercambio_datos("El servidor ha elegido: " + eleccionServidor, "", false);

            // Construye el mensaje de resultado utilizando la función DeterminarResultado
            StringBuilder resultado = new StringBuilder();

            foreach (var kvp in elecciones)
            {
                string nombreCliente = kvp.Key;
                string eleccionCliente = kvp.Value;

                // Determina el resultado de la partida entre el servidor y el cliente actual
                string resultadoPartida = DeterminarResultado(eleccionServidor, eleccionCliente);

                // Agrega el resultado al mensaje general
                resultado.AppendLine($"{nombreCliente}: {resultadoPartida}");
            }

            // Anuncia el resultado a todos los clientes
            intercambio_datos("Resultado: " + resultado.ToString(), "", false);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en la función juego: {ex.Message}");
            Console.WriteLine($"Origen: {ex.Source}");
        }
    }
    private static string LeerEleccion(TcpClient clientSocket)
    {
        try
        {
            // Obtiene el flujo de red del cliente
            NetworkStream networkStream = clientSocket.GetStream();

            // Crea un búfer para almacenar los bytes recibidos
            byte[] bytesFrom = new byte[1024];

            // Lee los bytes del flujo de red
            networkStream.Read(bytesFrom, 0, 1024);

            // Convierte los bytes a una cadena que representa la elección del cliente
            string eleccion = Encoding.ASCII.GetString(bytesFrom).Trim().ToLower();

            return eleccion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer la elección del cliente: {ex.Message}");
            Console.WriteLine($"Origen: {ex.Source}");
            return ""; // Puedes manejar el error de la forma que consideres más apropiada
        }
    }

    // Añade esta función al servidor para determinar el resultado de una partida
    private static string DeterminarResultado(string eleccionServidor, string eleccionCliente)
    {
        if (eleccionServidor == eleccionCliente)
        {
            return "Empate";
        }
        else if ((eleccionServidor == "piedra" && eleccionCliente == "tijeras") ||
                 (eleccionServidor == "papel" && eleccionCliente == "piedra") ||
                 (eleccionServidor == "tijeras" && eleccionCliente == "papel"))
        {
            return "El servidor ha ganado";
        }
        else
        {
            return "El cliente ha ganado";
        }
    }

    // La clase handleClient gestiona la comunicación con un cliente Tcp. Cada cliente se maneja en un hilo separado.
    public class handleClient
    {
        // El cliente Tcp asociado a esta instancia de handleClient
        TcpClient clientSocket;
        // Identificador único del cliente
        string nombreCliente;
        // Lista de clientes conectados al servidor
        Hashtable lista_clientes;
        
        // Inicia el cliente Tcp y su hilo asociado
        public void startClient(TcpClient inClientSocket, string nombreCliente, Hashtable clienteLista)
        {
            this.clientSocket = inClientSocket;
            this.nombreCliente = nombreCliente;
            this.lista_clientes = clienteLista;

            // Crea un nuevo hilo para manejar la comunicación con el cliente
            Thread ctThread = new Thread(para_chat);
            ctThread.Start();
        }

        // Método que se ejecuta en el hilo del cliente para gestionar la comunicación
        private void para_chat()
        {
            // Contador de solicitudes del cliente
            int requestCount = 0;
            // Buffer para almacenar los bytes recibidos
            byte[] bytesFrom = new byte[1024];
            // Almacena el mensaje del cliente
            string datos_cliente = null;
            // Bytes para enviar respuestas al cliente
            Byte[] sendBytes = null;
            // Respuesta del servidor
            string serverResponse = null;
            // Contador de solicitudes convertido a cadena
            string rCount = null;

            try
            {
                while (true)
                {
                    // Incrementa el contador de solicitudes
                    requestCount = requestCount + 1;
                    // Obtiene el flujo de red del cliente
                    NetworkStream networkStream = clientSocket.GetStream();
                    // Lee los bytes del flujo de red
                    networkStream.Read(bytesFrom, 0, 1024);
                    // Convierte los bytes a una cadena que representa el mensaje del cliente
                    datos_cliente = System.Text.Encoding.ASCII.GetString(bytesFrom).Trim().ToLower();

                    // Extrae la parte del mensaje antes del delimitador "$"
                    datos_cliente = datos_cliente.Substring(0, datos_cliente.IndexOf("$"));

                    // Convierte el contador de solicitudes a cadena
                    rCount = Convert.ToString(requestCount);

                    // Llama a la función en el servidor para intercambiar datos con los demás clientes
                    ServerConsola.intercambio_datos(datos_cliente, nombreCliente, true);
                }
            }
            catch
            {
                // En caso de excepción, indica que el cliente ya no está jugando
                ServerConsola.intercambio_datos(" ya no juego", nombreCliente, true);
                Console.WriteLine(  nombreCliente + " se ha desconectado");
                // Elimina al cliente de la lista de clientes conectados
                lista_clientes.Remove(nombreCliente);
                // Si queda un solo cliente, avisa que quedó jugando solo
                if (lista_clientes.Count == 1)
                {
                    ServerConsola.intercambio_datos("Te quedaste Jugando Solo!!!", "", false);
                }

                // Si no quedan clientes, muestra un mensaje en la consola y cierra el programa
                if (lista_clientes.Count == 0)
                {
                    Console.WriteLine("NO hay usuarios conectados");
                    
                }
            }
        }
    }
}


