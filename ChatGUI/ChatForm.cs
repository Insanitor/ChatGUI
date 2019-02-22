using ChatGUI.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ChatGUI
{
    public partial class ChatForm : Form
    {
        public static string chatMessage;
        ChatForm me;
        AsyncClient client;
        public ChatForm()
        {
            InitializeComponent();
            me = this;
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
                client.SendEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
            }
        }

        public void SetChatBox(string message)
        {
            //If the method requires Controls from
            //the current thread, this thread will
            //execute it instead of the outside caller
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate () { me.SetChatBox(message); });
                return;
            }
            if (message != null && message != "")
                me.ChatTextBox.Text += message + "\n";
        }

        private void ServerPortBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
