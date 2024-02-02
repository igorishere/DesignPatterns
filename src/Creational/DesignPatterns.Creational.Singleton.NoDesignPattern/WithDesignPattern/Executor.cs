using DesignPatterns.Common;

namespace DesignPatterns.Creational.Singleton.WithDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Singleton - With design pattern";

        public void Execute()
        {
            var connection1 = DatabaseConection.Instance;

            connection1.CreateConnection();

            var connection2 = DatabaseConection.Instance;

            connection2.CreateConnection();
        }
    }
}
