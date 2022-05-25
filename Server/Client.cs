using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;


namespace Server
{
    class Client
    {
        static string Username { get; set; }

        ReadMessages reader;

        static Guid ID { get; set; }

        public TcpClient ClientSocket { get; set; }

        public Client(TcpClient client)
        {

            ClientSocket = client;

            //Username=username;
             reader = new ReadMessages(ClientSocket.GetStream());

            
            Username = reader.readM();

            
            ID = Guid.NewGuid();
            Console.WriteLine($"[{DateTime.Now}]: {Username} Connected very nice");



        }
    }
}
