using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    class ServerConnection
    {

        public ServerUser Client { get; private set; }

        public ServerConnection(ServerUser client)
        {
            Client = client;
        }

        public void HandleMessages()
        {
            StreamReader reader = new StreamReader(Client.TcpClient.GetStream());
            while(true)
            {
                string line = null;

                try
                {
                    line = reader.ReadLine();
                }
                catch
                {
                    line = null;
                }
            }
        }

    }
}
