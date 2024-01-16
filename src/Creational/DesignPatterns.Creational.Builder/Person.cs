namespace DesignPatterns.Creational.Builder.NoDesignPattern
{
    public class Person
    {

        public readonly string Name;
        public readonly int Age;
        public readonly Guid Id;

        public Person(string name, int aged, Guid id)
        {
            Name = name;
            Age = aged;
            Id = id;
        }
    }
}
