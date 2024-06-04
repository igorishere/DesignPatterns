namespace DesignPatterns.Behavioral.Mediator.WithDesignPattern
{
    public class TrafficLightMediator
    {
        private List<Car[]> streets { get; set; }

        public TrafficLightMediator()
        {
            streets = new List<Car[]>();
        }

        public void RegisterStreet(Car[] carsOnTheStreet)
        {
            streets.Add(carsOnTheStreet);
        }

        public void ManageCarFlow()
        {
            int times = 3;
            var firstStreet = streets.ToArray()[0];
            var secondStreet = streets.ToArray()[1];
            var firstStreetShouldGo = true;
            while (times > 0)
            {
                if (firstStreetShouldGo)
                {
                    Stop(secondStreet);
                    Go(firstStreet);
                }
                else
                {
                    Stop(firstStreet);
                    Go(secondStreet);
                }

                firstStreetShouldGo = !firstStreetShouldGo;
                times -= 1;
            }
        }

        private void Stop(Car[] cars)
        {
            foreach (var car in cars)
                car.Stop();
        }

        private void Go(Car[] cars)
        {
            foreach (var car in cars)
                car.Go();
        }
    }
};
