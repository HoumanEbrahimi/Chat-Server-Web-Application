using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;




namespace Server
{
    class Server
    {

        static List<Client> user;
        static void Main()
        {
            user = new List<Client>();
            TcpListener listener;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7891);
            listener.Start();

            Console.WriteLine("Listening for connections");
            while (true)
            {
                var client = new Client(listener.AcceptTcpClient());
                user.Add(client);
            }




        }
    }
}
