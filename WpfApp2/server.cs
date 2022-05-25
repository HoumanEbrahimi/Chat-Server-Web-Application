using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;



namespace WpfApp2
{


    public class serverHelper
    {
        TcpClient client;

        public serverHelper()
        {
            client = new TcpClient();
        }

        public void ConnectToServerC(string username)
        {
            

            if (!client.Connected)
            {
                client.Connect("127.0.0.1", 7891);
                var connectPacket = new SendMessages();
                connectPacket.Message(username);
                client.Client.Send(connectPacket.getBytes());


            }
        }


    }




}
