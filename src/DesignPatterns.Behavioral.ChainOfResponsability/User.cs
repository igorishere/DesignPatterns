namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class User
    {
        public readonly string Name;
        public readonly string Password;

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}

