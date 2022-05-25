using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp2
{
    internal class SendMessages
    {

        MemoryStream stream;

        public SendMessages()
        {
            stream= new MemoryStream();
        }

        public void Message(string message)
        {
            var length=message.Length;
            stream.Write(BitConverter.GetBytes(length));
            stream.Write(ASCIIEncoding.ASCII.GetBytes(message));


        }

        public byte[] getBytes()
        {
            return stream.ToArray();
        }
    }
}
