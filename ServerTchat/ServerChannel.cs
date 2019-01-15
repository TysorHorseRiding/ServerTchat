using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    abstract class ServerChannel
    {
        public string Name = "test";

        protected ServerChannel(string name)
        {
            Name = name;
        }

        public void BroadcastMessage(string message)
        {
            foreach (ServerUser client in ClientRepository.Instance.Find(this))
            {
                client.SendMessage(message);
            }
        }
    }
}
