namespace DesignPatterns.Structural.Proxy.WithDesignPattern
{
    public class AutoPilotDriver : IDriver
    {

        private readonly IDriver _driver;
        public AutoPilotDriver(IDriver driver)
        {
            _driver = driver;
        }

        public int GetDesiredSpeed()
        {
            return _driver.GetDesiredSpeed();
        }

        public void PressAcceletor()
        {
            Console.WriteLine("Auto pilot is pressing accelerator...");
        }

        public void PressBreak()
        {
            Console.WriteLine("Auto pilot is pressing break pedal...");
        }
    }
}
