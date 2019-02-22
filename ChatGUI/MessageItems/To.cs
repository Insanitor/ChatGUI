namespace ChatGUI.MessageItems
{
    public class To
    {
        public To()
        {
            Name = Name;
            Ip = Ip;
        }

        public To(string name, string ip)
        {
            Name = name;
            Ip = ip;
        }

        public string Name { get; set; }
        public string Ip { get; set; }
    }
}
