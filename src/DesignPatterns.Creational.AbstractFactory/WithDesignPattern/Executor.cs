using DesignPatterns.Common;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Concrete;

namespace DesignPatterns.Creational.AbstractFactory.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override string GetName() => "Abstract Factory";

        public override void Execute()
        {
            Console.WriteLine("Choose a brand to see the devices:");
            Console.WriteLine("1.Apple");
            Console.WriteLine("2.Samsung");

            string userInput = Console.ReadLine();

            int result;
            var userInputAsInteger = int.TryParse(userInput, out result);

            IEcosystemAbstractFactory ecossystem = result == 1
                ? new AppleEcossystemFactory()
                : new SamsungEcossystemFactory();

            ShowEcossystemInformation(ecossystem);

            void ShowEcossystemInformation(IEcosystemAbstractFactory factory)
            {
                Console.WriteLine($"List of {factory.BrandName} devices");
                Console.WriteLine($"Phone: {factory.CreateCellPhone().Name}");
                Console.WriteLine($"Laptop: {factory.CreateLaptop().Name}");
                Console.WriteLine($"Tablet: {factory.CreateTablet().Name}");
            }
        }


    }
}
