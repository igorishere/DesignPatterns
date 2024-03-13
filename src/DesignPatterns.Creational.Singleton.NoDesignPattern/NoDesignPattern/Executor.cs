using DesignPatterns.Common;

namespace DesignPatterns.Creational.Singleton.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Singleton";

        public override void Execute()
        {
            var connection1 = new DatabaseConection();

            connection1.CreateConnection();

            var connection2 = new DatabaseConection();

            connection2.CreateConnection();
        }
    }
}
