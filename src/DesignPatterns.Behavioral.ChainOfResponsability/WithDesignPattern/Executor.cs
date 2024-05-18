using DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern.Validations;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.ChainOfResponsability.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var users = new User[]
            {
                new User("name of the user", "ashduh2123"),
                new User("name of the user", "888")
            };

            var validator = new UserValidator();
            foreach (var user in users)
            {
                var userIsValid = validator.IsValid(user);

               var message = userIsValid
                ? "User is valid!"
                : "User is not valid"; 

                Console.WriteLine(message);
            }
        }

        public override string GetName() => "ChainOfResponsability";
    }
}


