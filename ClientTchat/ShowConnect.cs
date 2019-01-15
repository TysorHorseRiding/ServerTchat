using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTchat
{
    public partial class ShowConnect : Form
    {
        public ShowConnect()
        {
            InitializeComponent();
        }

        private void buttonconnect_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == null)
                usernamebox.Text = "Default";

            ServerConnection connection = new ServerConnection("127.0.0.1", 4096, usernamebox.Text);
            new ChatForm().Show();
            Hide();
        }
    }
}
