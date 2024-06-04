namespace DesignPatterns.Behavioral.Mediator.WithDesignPattern
{
    public static class CarFactory
    {
        public static Car[] Fabricate(TrafficLightMediator trafficLightMediator, int quantity = 1)
        {
            var cars = new Car[quantity];

            for (int i = 0; i < quantity; i++)
            {
                cars[i] = new Car(trafficLightMediator);
            }

            return cars;
        }
    }
};
