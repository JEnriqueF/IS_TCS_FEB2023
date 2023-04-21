using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Peticion_de_fecha__Servidor_ {
    internal class SocketServidor {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;

        public void iniciarServidor() {
            //IPEndPoint direccionIP = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socketServidor.Bind(new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO));
            socketServidor.Listen();
            Console.WriteLine("Servidor listo para recibir conexiones.");
            try {
                Socket socketClienteRemoto = socketServidor.Accept();
                string mensaje = "";

                Console.WriteLine("Cliente conectado correctamente.");
                do {
                    byte[] bytesEntrada = new byte[1];
                    int numeroBytesEntrada = socketClienteRemoto.Receive(bytesEntrada, 0, bytesEntrada.Length, 0);
                    mensaje = Encoding.ASCII.GetString(bytesEntrada);
                    DateTime dateTime = DateTime.Now;

                    switch (int.Parse(mensaje)) {
                        case 1:
                            string respuestaServidor = dateTime.ToString("d");
                            byte[] bytesRespuestaServidor = Encoding.Default.GetBytes(respuestaServidor);

                            Console.WriteLine("Respuesta del servidor enviada");
                            socketClienteRemoto.Send(bytesRespuestaServidor); break;
                        case 2:
                            respuestaServidor = dateTime.ToString("T");
                            bytesRespuestaServidor = Encoding.Default.GetBytes(respuestaServidor);

                            Console.WriteLine("Respuesta del servidor enviada");
                            socketClienteRemoto.Send(bytesRespuestaServidor); break;
                        case 3:
                            respuestaServidor = dateTime.ToString("G");
                            bytesRespuestaServidor = Encoding.Default.GetBytes(respuestaServidor);

                            Console.WriteLine("Respuesta del servidor enviada");
                            socketClienteRemoto.Send(bytesRespuestaServidor); break;
                    }
                } while (socketClienteRemoto.Connected);
                socketServidor.Close();
            } catch (Exception ex) {
                Console.WriteLine("Fin de la ejecución del servidor");
            };
        }
    }
}