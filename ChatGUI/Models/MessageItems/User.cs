namespace ChatGUI.Models.MessageItems
{
    public class User
    {
        public User()
        {
            Name = Name;
            Ip = Ip;
        }

        public User(string name, string ip)
        {
            Name = name;
            Ip = ip;
        }

        public string Name { get; set; }
        public string Ip { get; set; }
    }
}
