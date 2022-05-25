using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;


namespace Server
{
    internal class ReadMessages:BinaryReader
    {

        private NetworkStream _stream;
        public ReadMessages(NetworkStream network): base(network)
        {
            _stream = network;


        }

        public string readM()
        {
            byte[] buffer = new byte[1024];
            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            var msg=Encoding.ASCII.GetString(buffer);
            return msg;
        }
    }
}
