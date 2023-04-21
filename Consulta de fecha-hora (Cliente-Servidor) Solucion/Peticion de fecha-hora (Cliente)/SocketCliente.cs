using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Peticion_de_fecha_hora__Cliente_ {
    internal class SocketCliente {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;

        public void iniciarSocketCliente() {
            //IPEndPoint direccionServidor = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try {
                socketCliente.Connect(new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO));
                string mensaje = "";
                Console.WriteLine("Conexión al servidor exitosa.");
                do {
                    byte[] bytesEntrada = new byte[30];
                    Console.Clear();
                    Console.WriteLine("1. Consultar fecha");
                    Console.WriteLine("2. Consultar hora");
                    Console.WriteLine("3. Consultar fecha y hora");
                    Console.WriteLine("4. Cancelar");
                    Console.Write("Escribe el número de la opción del menú: ");
                    mensaje = Console.ReadLine();
                    
                    switch (mensaje) {
                        case "1":
                        case "2":
                        case "3":
                            byte[] mensajeAServidor = Encoding.ASCII.GetBytes(mensaje);

                            socketCliente.Send(mensajeAServidor);
                            socketCliente.Receive(bytesEntrada);
                            string respuestaServidor = Encoding.ASCII.GetString(bytesEntrada, 0, bytesEntrada.Length);
                            Console.WriteLine("Respuesta del servidor: " + respuestaServidor + "\n");
                            Console.Write("Presiona cualquier tecla para continuar...");
                            Console.Read();
                            Console.ReadLine(); break;
                        case "4":
                            Console.WriteLine("Hasta pronto."); break;
                        default:
                            Console.Write("Solicitud incorrecta...");
                            System.Threading.Thread.Sleep(2000); break;
                    }
                }while (!mensaje.Equals("4"));
                socketCliente.Shutdown(SocketShutdown.Both);
                socketCliente.Close();
                Console.WriteLine("Conexión con el servidor cerrada.");
            } catch(Exception ex) {
                Console.WriteLine("Error con la conexión al servidor: " + ex.Message);
            }
        }
    }
}