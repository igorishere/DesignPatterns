using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Mediator.WithDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var random = new Random();
            const int minValue = 1;
            const int maxValue = 20;

            var trafficLightMediator = new TrafficLightMediator();

            var carsFirstStreet = CarFactory.Fabricate(trafficLightMediator, random.Next(minValue, maxValue));
            var carsSecondStreet = CarFactory.Fabricate(trafficLightMediator, random.Next(minValue, maxValue));

            trafficLightMediator.RegisterStreet(carsFirstStreet);
            trafficLightMediator.RegisterStreet(carsSecondStreet);
            trafficLightMediator.ManageCarFlow();
        }

        public override string GetName() => "Mediator";
    }
};
