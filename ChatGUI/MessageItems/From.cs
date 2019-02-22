namespace ChatGUI.MessageItems
{
    public class From
    {
        public From()
        {
            Ip = Ip;
            Name = Name;
        }

        public From(string name, string ip)
        {
            Name = name;
            Ip = ip;
        }

        public string Name { get; set; }
        public string Ip { get; set; }
    }
}
