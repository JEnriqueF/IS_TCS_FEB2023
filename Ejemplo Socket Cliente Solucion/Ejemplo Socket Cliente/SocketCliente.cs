using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ejemplo_Socket_Cliente {
    internal class SocketCliente {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;
        byte[] BytesEntrada = new byte[1024];

        public void IniciarSocketCliente(){
            IPEndPoint direccionServidor = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try {
                socketCliente.Connect(direccionServidor);
                string mensaje = "";
                Console.WriteLine("Conexión al servidor exitosa.\n");
                do {
                    Console.Write("Escribe el mensaje para enviarse al servidor: ");
                    mensaje = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(mensaje)) {
                        continue; // Volver a solicitar un mensaje
                    }
                    byte[] byteMensaje = Encoding.UTF8.GetBytes(mensaje);
                    socketCliente.Send(byteMensaje);
                    int numeroBytesRecibidos = socketCliente.Receive(BytesEntrada);
                    string respuestaServidor = Encoding.UTF8.GetString(BytesEntrada, 0, numeroBytesRecibidos); //BytesEntrada.Length
                    Console.WriteLine("Respuesta del servidor: " + respuestaServidor+"\n");
                }while (!mensaje.ToLower().Equals("salir"));
                socketCliente.Shutdown(SocketShutdown.Both);
                socketCliente.Close();
                Console.WriteLine("Conexión con el servidor cerrada.");
            }catch(Exception ex) {
                Console.WriteLine("Error en la conexión con el servidor: " + ex.Message);
            }
        }
    }
}