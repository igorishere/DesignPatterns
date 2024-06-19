using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Command.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            Console.WriteLine("No available example");
        } 

        public override string GetName() => "Command";
    }
};