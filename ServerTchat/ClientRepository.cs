using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    class ClientRepository
    {
        public static ClientRepository Instance { get; } = new ClientRepository();
        private List<ServerUser> _clients = new List<ServerUser>();
        private object _lock = new object();

        private ClientRepository() { }

        public ServerUser Find(TcpClient tcpClient)
        {
            lock (_lock)
            {
                return _clients.FirstOrDefault(client => Equals(client.TcpClient, tcpClient));
            }
        }

        public IReadOnlyCollection<ServerUser> Find(ServerChannel channel)
        {
            lock (_lock)
            {
                return _clients.FindAll(client => Equals(client.Channel, channel));
            }
        }

    }
}
