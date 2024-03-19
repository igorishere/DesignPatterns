using DesignPatterns.Common;

namespace DesignPatterns.Creational.Singleton.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override string GetName() => "Singleton";

        public override void Execute()
        {
            var connection1 = DatabaseConection.Instance;

            connection1.CreateConnection();

            var connection2 = DatabaseConection.Instance;

            connection2.CreateConnection();
        }
    }
}
