namespace DesignPatterns.Structural.Bridge
{
    public class User : IUser
    {

        private readonly string _password;
        private readonly string _email;

        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public string Email => _email;

        public string Password => _password;
    }
}
