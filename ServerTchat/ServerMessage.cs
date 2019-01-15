using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    abstract class ServerMessage
    {
        protected ServerUser _client;
        protected string _message;

        protected ServerMessage(ServerUser client, string message)
        {
            _client = client;
            _message = message;
        }

        public abstract bool Valid();

        public void Handle()
        {
            Process();
        }

        protected abstract void Process();
    }
}
