using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.ChainOfResponsability.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var users = new User[]
            {
                new User("name of the user", "ashduh2123"),
                new User("name of the user", "888")
            };

            foreach (var user in users)
            {
                var userIsValid = IsUserValid(user);

                var message = userIsValid
                ? "User is valid!"
                : "User is not valid";

                Console.WriteLine(message);
            }
        }

        private bool IsUserValid(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
                return false;

            if (string.IsNullOrWhiteSpace(user.Password))
                return false;

            if (user.Password.Length > 8)
                return false;

            return true;
        }

        public override string GetName() => "ChainOfResponsability";
    }
};
