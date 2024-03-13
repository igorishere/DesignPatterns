namespace DesignPatterns.Structural.Proxy
{
    public class Car
    {
        private int _speed;

        private readonly IDriver _driver;
        public Car(IDriver driver)
        {
            _driver = driver;
        }

        public void StartCruise()
        {
            Console.WriteLine("Starting car");

            _speed = _driver.GetDesiredSpeed();
            
            var currentSpeed = 0;
            while (currentSpeed < _speed)
            {
                _driver.PressAcceletor();
                currentSpeed++;
                Console.WriteLine($"Increasing speed: {currentSpeed} km/h");
            }

            Console.WriteLine($"Cruising at {currentSpeed} km/h");
            Console.WriteLine($"Time to stop");
            Console.WriteLine($"Starting to break...");

            while (currentSpeed > 0)
            {
                _driver.PressBreak();
                currentSpeed--;
                Console.WriteLine($"Stoping: {currentSpeed} km/h");
            }

            Console.WriteLine("Parking car");
        }
    }
}