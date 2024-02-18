using DesignPatterns.Creational.Builder.NoDesignPattern;

namespace DesignPatterns.Creational.Builder.WithDesignPattern
{
    public class PersonBuilder
    {
        private List<Person> _people { get; set; }

        public PersonBuilder()
        {
            _people = new List<Person>();
        }

        public PersonBuilder Add(string name, int age)
        {
            Add(name, age, Guid.NewGuid());

            return this;
        }

        public PersonBuilder Add(string name, int age, Guid id)
        {
            _people.Add(new Person(name, age, id));

            return this;
        }

        public IEnumerable<Person> Build()
        {
            return _people;
        }
    }
}
