using DesignPattern.Behavioral.Observer.Common;
using DesignPatterns.Common;

namespace DesignPattern.Behavioral.Observer.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var product1Name = "Rice";
            var product2Name = "Banana";
            var product3Name = "Beans";

            var products = new List<Product>()
            {
                new Product(product1Name, 4.99, isAvailable: false),
                new Product(product2Name, 3.99, isAvailable: true),
                new Product(product3Name, 2.00, isAvailable: true)
            };

            var subjects = new List<ISubject<IProduct>>()
            {
                new ProductListener(1.99,unsubscribeIfNotAvailable: true, product1Name),
                new ProductListener(5,unsubscribeIfNotAvailable: true, product2Name),
                new ProductListener(0.8,unsubscribeIfNotAvailable: true, product3Name)
            };

            var subscriber = new ProductSubscriber();
            foreach (var subject in subjects)
                subscriber.Subscribe(subject);

            foreach (var product in products)
                subscriber.Notify(product);
        }

        public override string GetName() => "Observer";
    }
}