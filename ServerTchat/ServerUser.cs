using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    class ServerUser
    {

        public TcpClient TcpClient { get; set; }

        public ServerChannel Channel { get; private set; }

        public ServerUser(TcpClient client)
        {
            TcpClient = client;
        }

        public void SendMessage(string message)
        {
            SendRawMessage("M:" + message);
        }

        public void SendRawMessage(string message)
        {
            try
            {
                StreamWriter writer = new StreamWriter(TcpClient.GetStream());
                writer.WriteLine(message);
                writer.Flush();
            } catch
            {
                //todo
            }
        }
    }
}
