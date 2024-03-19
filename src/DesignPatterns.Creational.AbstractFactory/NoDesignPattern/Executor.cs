using DesignPatterns.Common;
using DesignPatterns.Creational.AbstractFactory.NoDesignPattern.Devices;

namespace DesignPatterns.Creational.AbstractFactory.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Abstract factory";

        public override void Execute()
        {
            Console.WriteLine("Choose a brand to see the devices:");
            Console.WriteLine("1.Apple");
            Console.WriteLine("2.Samsung");

            string userInput = Console.ReadLine();

            int result;
            var userInputAsInteger = int.TryParse(userInput, out result);

            if (result == 1)
            {
                Console.WriteLine($"List of Apple devices");
                Console.WriteLine($"Phone:{new ApplePhone().Name}");
                Console.WriteLine($"Phone:{new AppleTablet().Name}");
                Console.WriteLine($"Phone:{new AppleLaptop().Name}");
            }
            else
            {
                Console.WriteLine($"List of Samsung devices");
                Console.WriteLine($"Phone:{new SamsungPhone().Name}");
                Console.WriteLine($"Phone:{new SamsungTablet().Name}");
                Console.WriteLine($"Phone:{new SamsungLaptop().Name}");
            }
        }
    }
}
