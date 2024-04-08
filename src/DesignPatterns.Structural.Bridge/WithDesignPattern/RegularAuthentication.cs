namespace DesignPatterns.Structural.Bridge.WithDesignPattern
{
    public class RegularAuthentication : Authentication
    {
        public RegularAuthentication(IUser user) : base(user)
        {
        }

        private bool PasswordMatches()
        {
            //internal logic to validade user
            return _user is not null;
        }

        public override bool CanAuthtenticateUser() => PasswordMatches();

        public override string Description() => "Regular authentication";
    }
}
