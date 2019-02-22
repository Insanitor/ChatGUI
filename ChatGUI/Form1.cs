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
using ChatGUI.MessageItems;

namespace ChatGUI
{
    public partial class Form1 : Form
    {
        public static string chatMessage;
        Form1 me;
        AsyncClient client;
        public Form1()
        {
            InitializeComponent();
            me = this;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new AsyncClient(ServerIpBox.Text, int.Parse(ServerPortBox.Value.ToString()));
            if (ServerPortBox.Value == 8888 || ServerPortBox.Value == 8889)
            {
                Thread listener = new Thread(delegate () { while (true) SetChatBox(client.Recieve()); })
                {
                    IsBackground = true
                };
                listener.Start();
            }
            else if (ServerPortBox.Value == 8890)
            {
                Thread listener = new Thread(delegate () { while (true) SetChatBox(client.RecieveEncrypted()); })
                {
                    IsBackground = true
                };
                listener.Start();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.SendEncrypted(new MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
            }
        }

        public void SetChatBox(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate () { me.SetChatBox(message); });
                return;
            }
            me.ChatTextBox.Text += message + "\n";
        }

        private void ServerPortBox_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
