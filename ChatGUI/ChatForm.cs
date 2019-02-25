using ChatGUI.Models;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ChatGUI
{
    public partial class ChatForm : Form
    {
        public static string chatMessage;
        ChatForm chatForm;
        static AsyncClient client;
        int connectedPort;

        bool clientConnected = false;

        public ChatForm()
        {
            InitializeComponent();
            ChatTextBox.Text = "";
            chatForm = this;
            chatForm.MaximizeBox = false;
            chatForm.MinimizeBox = false;
            this.KeyPreview = true;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!clientConnected)
                {
                    ChatTextBox.Text += "Trying to Connect...\n";
                    if (ServerPortBox.Value != 88901 && ServerPortBox.Value != 8891)
                        client = new AsyncClient(ServerIpBox.Text, int.Parse(ServerPortBox.Value.ToString()));
                    else if (ServerPortBox.Value == 8891)
                        client = new AsyncClient(ServerIpBox.Text, int.Parse(ServerPortBox.Value.ToString()), true);
                    else
                        client = new AsyncClient(ServerIpBox.Text, int.Parse("8890"));

                    if (client.Connected)
                    {
                        clientConnected = true;
                        ChatTextBox.Text += "Connected to: " + ServerIpBox.Text + "\n";
                        if (ServerPortBox.Value == 8889)
                        {
                            connectedPort = 8889;
                            Thread listener = new Thread(delegate () { while (clientConnected) SetChatBox(client.Recieve()); })
                            {
                                IsBackground = true
                            };
                            listener.Start();
                        }
                        else if (ServerPortBox.Value == 8890)
                        {
                            connectedPort = 8890;
                            Thread listener = new Thread(delegate () { while (clientConnected) SetChatBox(client.RecieveEncrypted()); })
                            {
                                IsBackground = true
                            };
                            listener.Start();
                        }
                        else if (ServerPortBox.Value == 88901)
                        {
                            connectedPort = 88901;
                            Thread listener = new Thread(delegate () { while (clientConnected) SetChatBox(client.RecieveDeepEncrypted()); })
                            {
                                IsBackground = true
                            };
                            listener.Start();
                        }
                        else if (ServerPortBox.Value == 8891)
                        {
                            connectedPort = 8891;
                            Thread listener = new Thread(delegate () { while (clientConnected) SetChatBox(client.RecieveEncryptedWithRsa()); })
                            {
                                IsBackground = true
                            };
                            listener.Start();
                        }
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                }
                else
                {
                    ChatTextBox.Text += "Already Connected.\n";
                }
            }
            catch
            {
                ChatTextBox.Text += "Connection Failed.\n";
            }
        }



        private void SendButton_Click(object sender, EventArgs e)
        {
            if (clientConnected)
            {
                if (MessageBox.Text != "")
                    if (client != null && connectedPort == 8889)
                    {
                        ChatTextBox.Text += "You Said: " + MessageBox.Text + "\n";
                        client.Send(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                    }
                    else if (client != null && connectedPort == 8890)
                    {
                        ChatTextBox.Text += "You Said: " + MessageBox.Text + "\n";
                        client.SendEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                    }
                    else if (client != null && connectedPort == 88901)
                    {
                        ChatTextBox.Text += "You Said: " + MessageBox.Text + "\n";
                        client.SendDeepEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                    }
                    else if (client != null && connectedPort == 8891)
                    {
                        ChatTextBox.Text += "You Said: " + MessageBox.Text + "\n";
                        client.SendEncrypted(new Models.MessageItems.Message(ToNameBox.Text, ToIpBox.Text, FromNameBox.Text, FromIpBox.Text, MessageBox.Text));
                    }
            }
            else
            {
                ChatTextBox.Text += "Must be Connected to a Server to send messages.\n";
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
                this.Invoke((MethodInvoker)delegate () { chatForm.SetChatBox(message); });
                return;
            }
            if (message != null && message != "")
                chatForm.ChatTextBox.Text += message + "\n";
        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Right)
            {
                ((TextBox)sender).SelectionStart += 1;
            }
            else if (e.KeyCode == Keys.Left && MessageBox.SelectionStart > 0)
            {
                ((TextBox)sender).SelectionStart -= 1;
            }
            ((TextBox)sender).SelectionLength = 0;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void NextTap_KeyPress(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                ((TextBox)sender).SelectionStart += 1;
            }
            else if (e.KeyCode == Keys.Left && ((TextBox)sender).SelectionStart > 0)
            {
                ((TextBox)sender).SelectionStart -= 1;
            }
            ((TextBox)sender).SelectionLength = 0;
        }

        private void NextTapNumeric_KeyPress(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ChatTextBox_TextChanged(object sender, EventArgs e)
        {
            ChatTextBox.SelectionStart = ChatTextBox.TextLength;

            ChatTextBox.ScrollToCaret();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientConnected)
                {
                    clientConnected = false;
                    client.Close();
                    ChatTextBox.Text += "Connection Closed.\n";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client != null)
            {

                ChatTextBox.Text += "client isn't null!";
                if (client.Users != null)
                {

                    ChatTextBox.Text += "Client.Users isn't null";
                    for (int i = 0; i < client.Users.Count; i++)
                    {
                        ChatTextBox.Text += "User#" + i + ": " + client.Users + "\n";
                    }
                }
            }
        }
    }
}
