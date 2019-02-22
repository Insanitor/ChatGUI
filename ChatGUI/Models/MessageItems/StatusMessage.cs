namespace ChatGUI.Models.MessageItems
{
    public class StatusMessage
    {
        public StatusMessage()
        {
            Message = Message;
            Code = Code;
        }

        public StatusMessage(string message, string code)
        {
            Message = message;
            Code = code;
        }

        public string Message { get; set; }
        public string Code { get; set; }
    }
}
