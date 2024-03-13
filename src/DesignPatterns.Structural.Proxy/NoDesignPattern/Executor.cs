using DesignPatterns.Common;

namespace DesignPatterns.Structural.Proxy.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Proxy";

        public override void Execute()
        {
            var driver = new HumanDriver();

            var car = new Car(driver);
            car.StartCruise();
        }
    }
}
