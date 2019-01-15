using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    class ChatMessage : ServerMessage
    {

        public ChatMessage(ServerUser client, string message) : base(client, message) { }

        public override bool Valid()
        {
            return (_message.StartsWith("M:") && !_message.StartsWith("M:/"));
        }

        protected override void Process()
        {
            string actualMessage = _message;
           // if(actualMessage.StartsWith(" "))
           // {
           //     actualMessage = actualMessage.Substring(1);
            //}

            _client.SendMessage(actualMessage);
        }

    }
}
