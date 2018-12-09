using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTchat
{
    public partial class ConnectForm : Form
    {
        protected const string AdresseIP = "127.0.0.1";
        protected const int PORT = 4096;

        public ConnectForm()
        {
            InitializeComponent();
            IPAdressShow.Text = AdresseIP;
            PortAdressShow.Text = PORT.ToString();
        }

        private static void StartServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, PORT);
            listener.Start();

            TcpClient tcpClient = listener.AcceptTcpClient();
            ServerUser serverUser = new ServerUser(tcpClient);

            Thread clientThread = new Thread(new ThreadStart(new ServerConnection(serverUser).HandleMessages));
            clientThread.Start();
        }

        private void buttonONOFF_Click(object sender, EventArgs e)
        {
            try
            {
                StartServer();
            }
            catch
            {
               
            }
        }
    }
}
