namespace DesignPatterns.Structural.Bridge.WithDesignPattern
{
    public class TwoFactorAuthentication : Authentication
    {
        public TwoFactorAuthentication(IUser user) : base(user)
        {

        }
        private bool CanAuthtenticate()
        {
            //internal logic to validade user
            return false;
        }

        public override bool CanAuthtenticateUser() => CanAuthtenticate();

        public override string Description() => "Two factor authentication";
    }
}
