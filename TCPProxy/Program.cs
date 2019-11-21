using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPProxy
{
    class Program
    {
        static void Main(string[] args)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 80);

            listener.Start();
            while (true)
            {
                if (listener.Pending())
                {
                    
                    using(Socket socket = listener.AcceptSocket())
                    {
                        if (socket.Connected)
                        {
                            byte[] httpRequest = ReadToEnd(socket);
                            string str = Encoding.ASCII.GetString(httpRequest);
                            Console.WriteLine($"{str}");
                            using (FileStream fs = new FileStream("d:/headers.txt", FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                fs.Write(httpRequest, 0, httpRequest.Length);
                            }
                        }
                    }
                    break;
                }
            }
        }
        private static byte[] ReadToEnd(Socket mySocket)
        {
            byte[] b = new byte[mySocket.ReceiveBufferSize];
            int len = 0;
            using (MemoryStream m = new MemoryStream())
            {
                while (mySocket.Poll(1000000, SelectMode.SelectRead) && (len = mySocket.Receive(b, mySocket.ReceiveBufferSize, SocketFlags.None)) > 0)
                {
                    m.Write(b, 0, len);
                }
                return m.ToArray();
            }
        }
    }
}
