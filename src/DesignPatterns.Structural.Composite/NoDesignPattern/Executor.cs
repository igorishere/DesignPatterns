using DesignPatterns.Common;

namespace DesignPatterns.Structural.Composite.NoDesignPattern
{
    internal class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            Console.WriteLine("Unfortunaly, no one example without using the design pattern could be created," +
                "take a look into example WITH design pattern applyed, thank you!");
        }

        public override string GetName() => "Composite";
    }
}
