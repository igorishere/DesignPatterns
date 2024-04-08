namespace DesignPatterns.Structural.Bridge.WithDesignPattern
{
    public class FacialRecognitionAuthentication : Authentication
    {
        public FacialRecognitionAuthentication(IUser user) : base(user)
        {
        }

        public override bool CanAuthtenticateUser() => FaceMatchesWithRegisteredPassword();

        public override string Description() => "Facial recognition";


        private bool FaceMatchesWithRegisteredPassword()
        {
            //internal logic to validade user
            return _user is not null;
        }
    }
}
