using DesignPattern.Behavioral.Observer.Common;
using DesignPatterns.Common;

namespace DesignPattern.Behavioral.Observer.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var product1Name = "Rice";
            var product2Name = "Banana";
            var product3Name = "Beans";

            var products = new List<IProduct>()
            {
                new Product(product1Name, 4.99, isAvailable: false),
                new Product(product2Name, 3.99, isAvailable: true),
                new Product(product3Name, 2.00, isAvailable: true)
            };

            var observers = new List<ProductObserver>()
            {
                new ProductObserver(1.99, product1Name),
                new ProductObserver(5, product2Name),
                new ProductObserver(0.8, product3Name)
            };

            foreach (var product in products)
                foreach (var observer in observers)
                    observer.CheckIfNeedToBuy(product);
        }

        public override string GetName() => "Observer";
    }
}