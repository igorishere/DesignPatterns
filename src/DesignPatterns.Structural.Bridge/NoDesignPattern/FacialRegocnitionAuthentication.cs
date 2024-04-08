namespace DesignPatterns.Structural.Bridge.NoDesignPattern
{
    public class FacialRegocnitionAuthentication
    {
        private readonly IUser _user;
        public FacialRegocnitionAuthentication(IUser user)
        {
            _user = user;
        }

        public bool IsUserValid() => FaceMatchesWithRegisteredPassword();

        private bool FaceMatchesWithRegisteredPassword()
        {
            //internal logic to validade user
            return _user is not null;
        }
    }
}