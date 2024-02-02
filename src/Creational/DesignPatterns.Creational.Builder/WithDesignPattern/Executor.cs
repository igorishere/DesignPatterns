using DesignPatterns.Common;

namespace DesignPatterns.Creational.Builder.WithDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Builder - With design pattern";

        public void Execute()
        {
            var people = new PersonBuilder()
            .Add("Jesus", 30, Guid.NewGuid())
            .Add("Maria", 20)
            .Add("Joseph", 40, Guid.NewGuid())
            .Add("Joan", 12, Guid.NewGuid())
            .Add("Peter", 29)
            .Add("Marcus", 18, Guid.NewGuid())
            .Add("Eleonor", 25)
            .Build();

            foreach (var person in people)
            {
                Console.WriteLine($"ID: {person.Id} | Name: {person.Name} | Age: {person.Age}");
            }
        }
    }
}
