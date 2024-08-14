namespace DesignPattern.Behavioral.Observer.Common
{
    public class Product : IProduct
    {
        public Product(string name, double price, bool isAvailable)
        {
            Name = name;
            Price = price;
            IsAvailable = isAvailable;
        }

        private string _name;
        public string Name { get => _name; set => _name = value; }

        private double _price;
        public double Price { get => _price; set => _price = value; }

        private bool _isAvailable;
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }
    }
}