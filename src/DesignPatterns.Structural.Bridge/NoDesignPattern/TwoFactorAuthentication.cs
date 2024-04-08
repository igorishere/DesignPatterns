namespace DesignPatterns.Structural.Bridge.NoDesignPattern
{
    public class TwoFactorAuthentication
    {
        private readonly IUser _user;
        public TwoFactorAuthentication(IUser user)
        {
            _user = user;
        }

        public bool IsValid() => CanAuthtenticate();

        private bool CanAuthtenticate()
        {
            //internal logic to validade user
            return _user is not null;
        }
    }
}
