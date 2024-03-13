using DesignPatterns.Common;
using DesignPatterns.Creational.Prototype.WithDesignPattern;

namespace DesignPatterns.Creational.Prototype.WithDesignPattern
{
    internal class Executor : ExecutorWithExample
    {
        public override string GetName() => "Prototype";

        public override void Execute()
        {
            Console.WriteLine("Creating a cell...");

            var motherCell = new Cell();

            Console.WriteLine("Starting mitosis...");

            var sonCell = motherCell.Copy();

            Console.WriteLine("Mitosis completed, check the results:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Cell mother");
            Console.WriteLine($"Id: {motherCell.ID}");
            Console.WriteLine($"Cromossomes: ");

            foreach (var item in motherCell.Cromossomes)
                Console.WriteLine($"{item}");

            Console.WriteLine("Cell clone");
            Console.WriteLine($"Id: {sonCell.ID}");
            Console.WriteLine($"Cromossomes: ");

            foreach (var item in sonCell.Cromossomes)
                Console.WriteLine($"{item}");
        }
    }
}
