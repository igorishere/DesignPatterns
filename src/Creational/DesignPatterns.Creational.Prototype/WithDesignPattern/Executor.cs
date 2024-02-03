using DesignPatterns.Common;
using DesignPatterns.Creational.Prototype.NoDesignPattern;

namespace DesignPatterns.Creational.Prototype.WithDesignPattern
{
    internal class Executor : IExecutor
    {
        public string Description => "Prototy - With design pattern";

        public void Execute()
        {
            Console.WriteLine("Creating a cell...");

            var motherCell = new Cell();

            Console.WriteLine("Starting mitosis...");

            var sonCell = new Cell(motherCell.ID, motherCell.Cromossomes);

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
