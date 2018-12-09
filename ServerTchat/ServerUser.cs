﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTchat
{
    class ServerUser
    {

        public TcpClient TcpClient { get; set; }

        public ServerUser(TcpClient client)
        {
            TcpClient = client;
        }
    }
}
