using DesignPatterns.Common;

namespace DesignPatterns.Creational.Builder.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Builder";

        public override void Execute()
        {
            var people = new List<Person>();

            var person1 = new Person("Jesus", 30, Guid.NewGuid());
            var person2 = new Person("Maria", 20, Guid.NewGuid());
            var person3 = new Person("Joseph", 40, Guid.NewGuid());
            var person4 = new Person("Joan", 12, Guid.NewGuid());
            var person5 = new Person("Peter", 29, Guid.NewGuid());
            var person6 = new Person("Marcus", 18, Guid.NewGuid());
            var person7 = new Person("Eleonor", 25, Guid.NewGuid());

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);

            foreach (var person in people)
            {
                Console.WriteLine($"ID: {person.Id} | Name: {person.Name} | Age: {person.Age}");
            }
        }
    }
}
