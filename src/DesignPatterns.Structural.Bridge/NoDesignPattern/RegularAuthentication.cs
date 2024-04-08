
namespace DesignPatterns.Structural.Bridge.NoDesignPattern
{
    public class RegularAuthentication
    {
        private readonly IUser _user;
        public RegularAuthentication(IUser user)
        {
            _user = user;
        }

        public bool IsValid() => PasswordMatches();

        private bool PasswordMatches()
        {
            //internal logic to validade user
            return _user is not null;
        }
    }
}
