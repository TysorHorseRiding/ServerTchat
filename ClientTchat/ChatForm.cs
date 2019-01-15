using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTchat
{
    public partial class ChatForm : Form
    {

        ServerConnection _connect { get; set; }
        private Thread _listenThread { get; set; }

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Shown(object sender, EventArgs e)
        {
            ServerConnection connect = ServerConnection.GetCurrentConnection();

            _connect = connect;

            _listenThread = new Thread(new ThreadStart(Listen));
            _listenThread.Start();
        }

        private void Listen()
        {
            string line = null;

            while (true)
            {
                try
                {
                    line = _connect.Reader.ReadLine();
                } catch
                {
                    break;
                }

                if(line.StartsWith("M:"))
                {
                    //ChatMessage theMessage = new ChatMessage(line.Substring(2));
                    richTextBox1.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(line + Environment.NewLine);
                    });
                    _connect.Writer.Flush();

                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string message = richTextBox2.Text;

            _connect.Writer.WriteLine("M:" + message);
            _connect.Writer.Flush();

            richTextBox2.Text = "";
        }

    }
}
