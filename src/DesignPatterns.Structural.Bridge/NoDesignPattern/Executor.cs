using DesignPatterns.Common;

namespace DesignPatterns.Structural.Bridge.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Bridge";

        public override void Execute()
        {
            var user = new User("user@mail.com", "mysecretpassword");

            var regularAuth = new RegularAuthentication(user);
            var facialAuthentication = new FacialRegocnitionAuthentication(user);
            var twoFactorAuth = new TwoFactorAuthentication(user);

            if (regularAuth.IsValid())
                Console.WriteLine("User is authtenticated in regular authentication");

            if (facialAuthentication.IsUserValid())
                Console.WriteLine("User is authtenticated in facial authentication");

            if (twoFactorAuth.IsValid())
                Console.WriteLine("User is authtenticated in two factor authentication");

        }
    }
}
