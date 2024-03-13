namespace DesignPatterns.Structural.Proxy
{
    public class HumanDriver : IDriver
    {
        public int GetDesiredSpeed()
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 120);

            return randomNumber;
        }

        public void PressAcceletor()
        {
            Console.WriteLine("Humam driver is pressing accelerator...");
        }

        public void PressBreak()
        {
            Console.WriteLine("Humam driver is pressing break pedal...");
        }
    }
}
