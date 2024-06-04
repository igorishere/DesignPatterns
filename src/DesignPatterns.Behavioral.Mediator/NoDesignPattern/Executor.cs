using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Mediator.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            Console.WriteLine("Sorry, no example could be written");
        }

        public override string GetName() => "Mediator";
    }
};
