namespace DesignPatterns.Structural.Bridge.WithDesignPattern
{
    public abstract class Authentication
    {
        protected readonly IUser _user;
        public Authentication(IUser user)
        {
            _user = user;
        }

        public abstract string Description();
        public abstract bool CanAuthtenticateUser();
    }
}
