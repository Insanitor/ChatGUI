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
        int connectedPort;
        public ChatForm()
        {
            InitializeComponent();
            ChatTextBox.Text = "";
            AcceptButton = SendButton;
            me = this;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ChatTextBox.Text += "Trying to Connect...\n";
            if (ServerPortBox.Value != 88901)
                client = new AsyncClient(ServerIpBox.Text, int.Parse(ServerPortBox.Value.ToString()));
            else
                client = new AsyncClient(ServerIpBox.Text, int.Parse("8890"));

            if (client.Client.Connected)
            {
                ChatTextBox.Text += "Connected to: " + ServerIpBox.Text + "\n";
                if (ServerPortBox.Value == 8889)
                {
                    connectedPort = 8889;
                    Thread listener = new Thread(delegate () { while (true) SetChatBox(client.Recieve()); })
                    {
                        IsBackground = true
                    };
                    listener.Start();
                }
                else if (ServerPortBox.Value == 8890)
                {
                    connectedPort = 8890;
                    Thread listener = new Thread(delegate () { while (true) SetChatBox(client.RecieveEncrypted()); })
                    {
                        IsBackground = true
                    };
                    listener.Start();
                }
                else if (ServerPortBox.Value == 88901)
                {
                    connectedPort = 88901;
                    Thread listener = new Thread(delegate () { while (true) SetChatBox(client.RecieveDeepEncrypted()); })
                    {
                        IsBackground = true
                    };
                    listener.Start();
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Text != "")
                if (client != null && connectedPort == 8889)
                {
                    client.Send(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                }
                else if (client != null && connectedPort == 8890)
                {
                    client.SendEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                }
                else if (client != null && connectedPort == 88901)
                {
                    client.SendDeepEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                }
            MessageBox.Text = "";
        }

        public void SetChatBox(string message)
        {
            //Checks the method requires Controls
            //from the current thread
            if (InvokeRequired)
            {
                //Invokes a MethodInvoker-Delegate
                //that can automagically call the method
                this.Invoke((MethodInvoker)delegate () { me.SetChatBox(message); });
                return;
            }
            if (message != null && message != "")
                me.ChatTextBox.Text += message + "\n";
        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            //e.Handled = true;
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SendButton_Click(this, new EventArgs());
            //}
        }
    }
}
