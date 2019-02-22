using System.Collections.Generic;

namespace ChatGUI.MessageItems
{
    public class Message
    {
        public To To { get; set; }
        public From From { get; set; }
        public Mb Mb { get; set; }
        public List<User> Users { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public Message()
        {
            To = new To();
            From = new From();
            Mb = new Mb();
            Users = new List<User>();
            StatusMessage = new StatusMessage();
        }


        public Message(string toName, string toIp, string fromName, string fromIp, string messageBody)
        {
            To = new To(toName, toIp);
            From = new From(fromName, fromIp);
            Mb = new Mb(messageBody);
            Users = new List<User>();
        }

        public Message(string toName, string toIp,string fromName,string fromIp,string messageBody, string statusMessage,string statusCode)
        {
            To = new To(toName,toIp);
            From = new From(fromName,fromIp);
            Mb = new Mb(messageBody);
            StatusMessage = new StatusMessage(statusMessage,statusCode);
        }
    }
}
