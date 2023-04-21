using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ejemplo_Socket_Servidor {
    internal class SokcetServidor {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;

        public void IniciarServidor() {
            IPEndPoint direccionIP = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socketServidor.Bind(direccionIP);
            socketServidor.Listen();
            Console.WriteLine("Servidor listo para recibir conexiones.");
            try {
                Console.OutputEncoding = Encoding.UTF8;
                Socket socketClienteRemoto = socketServidor.Accept();
                string mensaje = "";

                Console.WriteLine("Cliente conectado correctamente.");
                do {
                    byte[] BytesEntrada = new byte[1024];
                    int numeroBytesEntrada = socketClienteRemoto.Receive(BytesEntrada, 0, BytesEntrada.Length, 0);
                    mensaje = Encoding.UTF8.GetString(BytesEntrada);

                    Console.WriteLine("El mensaje del cliente es: " + mensaje);
                    Console.Write("Escribe un mensaje al cliente: ");
                    String mensajeRespuesta = Console.ReadLine();
                    byte[] bytesMensajeRespuesta = Encoding.UTF8.GetBytes(mensajeRespuesta);
                    socketClienteRemoto.Send(bytesMensajeRespuesta);
                }while( !mensaje.ToLower().Equals("salir") || socketClienteRemoto.Connected);
                socketServidor.Close();
            }catch(Exception ex) {
                Console.WriteLine("Conexión cerrada.");
            }
            Console.WriteLine("Fin de la ejecución del servidor.");
        }
    }
}