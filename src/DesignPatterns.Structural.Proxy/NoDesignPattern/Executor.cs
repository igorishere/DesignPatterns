using DesignPatterns.Common;

namespace DesignPatterns.Structural.Proxy.NoDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Proxy - No design pattern";

        public void Execute()
        {
            var driver = new HumanDriver();

            var car = new Car(driver);
            car.StartCruise();
        }
    }
}
