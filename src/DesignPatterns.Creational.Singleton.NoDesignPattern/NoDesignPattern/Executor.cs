using DesignPatterns.Common;

namespace DesignPatterns.Creational.Singleton.NoDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Singleton - No design pattern";

        public void Execute()
        {
            var connection1 = new DatabaseConection();

            connection1.CreateConnection();

            var connection2 = new DatabaseConection();

            connection2.CreateConnection();
        }
    }
}
