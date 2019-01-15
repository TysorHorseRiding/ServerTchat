using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientTchat
{
    class ServerConnection
    {
        public string Host = "127.0.0.1";
        public int Port = 4096;
        public string Username { get; set; }
        public TcpClient Client { get; private set; }
        public StreamReader Reader { get; private set; }
        public StreamWriter Writer { get; private set; }

        private static ServerConnection currentConnection { get; set; }
        private static object _lock = new object();
        
        public ServerConnection(string host, int port, string username)
        {
            Host = host;
            Port = port;
            Username = username;
            currentConnection = this;

            try
            {
                Client = new TcpClient(Host, Port);
                Reader = new StreamReader(Client.GetStream());
                Writer = new StreamWriter(Client.GetStream());

                Writer.Flush();
            }
            catch
            {
                Client = null;
            }
        }

        public static ServerConnection GetCurrentConnection()
        {
            lock (_lock)
            {
                return currentConnection;
            }
        }

    }
}
