namespace ChatGUI.Models.MessageItems
{
    public class From
    {
        public From()
        {
            Ip = Ip;
            Name = Name;
            Name = Name;
            PublicKey = PublicKey;
        }

        public From(string name, string ip)
        {
            Name = name;
            Ip = ip;
            PublicKey = PublicKey;
        }

        public From(string name, string ip, string key)
        {
            Name = name;
            Ip = ip;
            PublicKey = key;
        }

        public string Name { get; set; }
        public string Ip { get; set; }
        public string PublicKey { get; set; }
    }
}
