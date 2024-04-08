using DesignPatterns.Common;

namespace DesignPatterns.Structural.Bridge.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override string GetName() => "Bridge";
        public override void Execute()
        {
            var user = new User("mymail@mail.com", "mypassword");

            var authMethods = new List<Authentication>()
            {
                new RegularAuthentication(user),
                new FacialRecognitionAuthentication(user),
                new TwoFactorAuthentication(user)
            };

            foreach (var authmethod in authMethods)
                Auth(authmethod);
        }

        public void Auth(Authentication authentication)
        {
            var message = authentication.CanAuthtenticateUser()
                ? $"User is authenticated by {authentication.Description()}"
                : $"Acess denied by {authentication.Description()}";

            Console.WriteLine(message);
        }
    }
}
