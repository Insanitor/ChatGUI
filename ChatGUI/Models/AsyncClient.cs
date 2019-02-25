using ChatGUI.Models.MessageItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace ChatGUI.Models
{
    public class AsyncClient
    {
        public TcpClient Client { get; set; }

        protected IPAddress ServerIpAddress { get; set; }
        protected int ServerPort { get; set; }

        protected NetworkStream Stream { get; set; }

        public RSACryptoServiceProvider MyRSAKey { get; set; }
        public RSAParameters MyRSAKeyInfo { get; set; }

        public List<User> Users { get; set; }

        /// <summary>
        /// Constructor for an Async Client
        /// </summary>
        /// <param name="serverIp">The IP Address of the Server you wish to connect to</param>
        /// <param name="serverPort">The Port Number of the Server you wish to connect to</param>
        public AsyncClient(string hostname, int port, bool SendRSAKey = false)
        {
            try
            {
                Users = new List<User>();
                MyRSAKey = new RSACryptoServiceProvider(2048);
                ServerIpAddress = IPAddress.Parse(hostname);
                ServerPort = port;

                    
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deconstructor that makes sure the connection gets closed
        /// </summary>
        ~AsyncClient()
        {
            try
            {
                if (Client != null)
                    if (Client.Client != null)
                        if (Client.Client.Connected)
                            Client.Client.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Connect()
        {
            Client = new TcpClient(ServerIpAddress.ToString(), ServerPort);
            Stream = Client.GetStream();
            SendKey();
        }

        /// <summary>
        /// Close medthod for Async Client.
        /// </summary>
        public void Close()
        {
            try
            {
                Client.Client.Close();
                Users.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Used to Send the Clients Public RSA Key
        /// into the stream
        /// </summary>
        public void SendKey()
        {
            //Gets the clients current Public Parameters
            MyRSAKeyInfo = MyRSAKey.ExportParameters(false);

            //Checks if the Stream is ready to Write
            if (Stream.CanWrite)
            {
                //Encodes the RSA Keys Public Parameters as an XML-String
                byte[] buffer = Encoding.ASCII.GetBytes(MyRSAKey.ToXmlString(false));
                Stream.Write(buffer, 0, buffer.Length);
            }
        }

        /// <summary>
        /// Sends a Message as XML
        /// </summary>
        /// <param name="message">Message to Send</param>
        public void Send(Message message)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Stream);
                XmlSerializer ser = new XmlSerializer(typeof(Message));

                //Serialize the message
                ser.Serialize(Stream, message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Encrypts the Body of the Message and sends it as XML
        /// </summary>
        /// <param name="message">Message to Encrypt & Send</param>
        public void SendEncrypted(Message message)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Stream);
                XmlSerializer ser = new XmlSerializer(typeof(Message));
                //Encrypt the Message as Byte Arrays
                byte[] bodyData = CryptoTool.Encrypt(message.Mb.Body);

                //Converts the Byte Array into an Encrypted String
                message.Mb.Body = Convert.ToBase64String(bodyData);

                //Serialize the encrypted message
                ser.Serialize(Stream, message);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Encrypts the Body, To Name & From Name
        /// of the Message and sends it as XML
        /// </summary>
        /// <param name="message">Message to Encrypt & Send</param>
        public void SendDeepEncrypted(Message message)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Stream);
                XmlSerializer ser = new XmlSerializer(typeof(Message));

                //Encrypt the Messages as Byte Arrays
                byte[] bodyData = CryptoTool.Encrypt(message.Mb.Body);
                byte[] toData = CryptoTool.Encrypt(message.To.Name);
                byte[] fromData = CryptoTool.Encrypt(message.From.Name);

                //Converts the Byte Arrays into Encrypted Strings
                message.Mb.Body = Convert.ToBase64String(bodyData);
                message.To.Name = Convert.ToBase64String(toData);
                message.From.Name = Convert.ToBase64String(fromData);

                //Serialize the encrypted message
                ser.Serialize(Stream, message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Used for Recieving XML Streams
        /// </summary>
        public string Recieve()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Message));
                StreamReader reader = new StreamReader(Stream);

                //Creates a StringBuilder to build the message
                StringBuilder message = new StringBuilder();

                //Reads the Datastream into the Buffer
                //and adds it to the StringBuilder
                //and clears whitespace
                char[] buffer = new char[3000];
                reader.Read(buffer, 0, buffer.Length);
                foreach (char b in buffer)
                    message.Append(b);
                message = message.Remove(message.ToString().IndexOf("</Message>") + "</Message>".Length, "</Message>".Length);

                //Opens a String Reader to have a
                //stream to deserialize and feeds it
                //the string builder as a string
                using (StringReader sr = new StringReader(message.ToString()))
                {
                    var m = ser.Deserialize(sr) as Message;
                    if (m.Mb.Body != null && m.Mb.Body != "")
                        foreach (char c in m.Mb.Body)
                            if (c != ' ')
                            {
                                return (m.From.Name + ">>" + m.To.Name + ": " + m.Mb.Body);
                            }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        /// <summary>
        /// Used to Recieve encrypted XML Streams
        /// </summary>
        public string RecieveEncrypted()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Message));
                StreamReader reader = new StreamReader(Stream);

                //Creates a StringBuilder to build the message
                StringBuilder message = new StringBuilder();

                //Reads the Datastream into the Buffer
                //and adds it to the StringBuilder
                //and clears whitespace
                char[] buffer = new char[3000];
                reader.Read(buffer, 0, buffer.Length);
                foreach (char b in buffer)
                    message.Append(b);
                message = message.Remove(message.ToString().IndexOf("</Message>") + "</Message>".Length, "</Message>".Length);

                //Opens a String Reader to have a
                //stream to deserialize and feeds it
                //the string builder as a string
                using (StringReader sr = new StringReader(message.ToString()))
                {
                    var m = ser.Deserialize(sr) as Message;
                    if (m.Mb.Body != null || m.Mb.Body != "")
                    {
                        m.Mb.Body = CryptoTool.Decrypt(m.Mb.Body);
                        foreach (char c in m.Mb.Body)
                            if (c != ' ')
                            {
                                return (m.From.Name + ">>" + m.To.Name + ": " + m.Mb.Body);
                            }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        /// <summary>
        /// Used for Recieving RSAKeyValues 
        /// and XML Streams
        /// </summary>
        public string RecieveEncryptedWithRsa()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Message));
                StreamReader reader = new StreamReader(Stream);

                //Creates a StringBuilder to build the message
                StringBuilder message = new StringBuilder();

                //Reads the Datastream into the Buffer
                //and adds it to the StringBuilder
                //and clears whitespace
                char[] buffer = new char[3000];
                reader.Read(buffer, 0, buffer.Length);
                foreach (char b in buffer)
                    message.Append(b);
                message = message.Remove(message.ToString().IndexOf("</Message>") + "</Message>".Length, "</Message>".Length);

                if (message.ToString().Contains("RSAKeyValue"))
                {
                    using (StringReader sr = new StringReader(message.ToString()))
                    {
                        var m = ser.Deserialize(sr) as Message;
                        if (m.Users != null)
                        {
                            m.Users.ForEach(CheckUsersIp);
                        }
                    }
                }

                //Opens a String Reader to have a
                //stream to deserialize and feeds it
                //the string builder as a string
                using (StringReader sr = new StringReader(message.ToString()))
                {
                    var m = ser.Deserialize(sr) as Message;
                    if (m.Mb.Body != null || m.Mb.Body != "")
                    {
                        m.Mb.Body = CryptoTool.Decrypt(m.Mb.Body);
                        foreach (char c in m.Mb.Body)
                            if (c != ' ')
                            {
                                return (m.From.Name + ">>" + m.To.Name + ": " + m.Mb.Body);
                            }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public void CheckUsersIp(User u)
        {
            bool isNew = true;
            for (int i = 0; i < Users.Count; i++)
                if (u.Ip == Users[i].Ip)
                    isNew = false;
            if (isNew == true)
                Users.Add(u);
        }

        /// <summary>
        /// Used to Recieve Deep encrypted XML Streams
        /// </summary>
        public string RecieveDeepEncrypted()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Message));
                StreamReader reader = new StreamReader(Stream);

                //Creates a StringBuilder to build the message
                StringBuilder message = new StringBuilder();

                //Reads the Datastream into the Buffer
                //and adds it to the StringBuilder
                //and clears whitespace
                char[] buffer = new char[3000];
                reader.Read(buffer, 0, buffer.Length);
                foreach (char b in buffer)
                    message.Append(b);
                message = message.Remove(message.ToString().IndexOf("</Message>") + "</Message>".Length, "</Message>".Length);

                //Opens a String Reader to have a
                //stream to deserialize and feeds it
                //the string builder as a string
                using (StringReader sr = new StringReader(message.ToString()))
                {
                    var m = ser.Deserialize(sr) as Message;
                    if (m.Mb.Body != null || m.Mb.Body != "")
                    {
                        m.Mb.Body = CryptoTool.Decrypt(m.Mb.Body);
                        m.To.Name = CryptoTool.Decrypt(m.To.Name);
                        m.From.Name = CryptoTool.Decrypt(m.From.Name);
                        foreach (char c in m.Mb.Body)
                            if (c != ' ')
                            {
                                return (m.From.Name + ">>" + m.To.Name + ": " + m.Mb.Body);
                            }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
