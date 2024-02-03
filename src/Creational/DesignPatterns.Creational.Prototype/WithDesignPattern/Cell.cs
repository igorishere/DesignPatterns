namespace DesignPatterns.Creational.Prototype.WithDesignPattern
{
    internal class Cell : IPrototype<Cell>
    {
        public readonly Guid ID;
        public readonly string[] Cromossomes;

        public Cell()
        {
            ID = Guid.NewGuid();

            var quantityOfCromossomes = new Random().Next(1, 10);
            var cromossomes = new List<string>();
            for (int i = 0; i < quantityOfCromossomes; i++)
                cromossomes.Add(Guid.NewGuid().ToString());

            Cromossomes = cromossomes.ToArray();
        }

        public Cell(Guid iD, string[] cromossomes)
        {
            ID = iD;
            Cromossomes = cromossomes;
        }

        public Cell Copy()
        {
           return new Cell(ID, Cromossomes);
        }
    }
}
