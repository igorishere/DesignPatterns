namespace DesignPatterns.Behavioral.Mediator.WithDesignPattern
{
    public class Car
    {
        public readonly Guid Id;

        public Car(TrafficLightMediator trafficLightMediator)
        {
            Id = Guid.NewGuid();
        }
        public void Go()
        {
            Console.WriteLine($"The car with ID" + Id + " is departuring!");
        }

        public void Stop()
        {
            Console.WriteLine($"The car with ID" + Id + " is stopping!");
        }
    }
};
