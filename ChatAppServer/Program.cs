using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatAppServer
{
    class Program
    {
        static System.Net.Sockets.Socket socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 100));
            socket.Listen(50);
            Socket client =  socket.Accept();
            byte[] buffer = new byte[1024];
            client.Receive(buffer);
        }
    }
}
