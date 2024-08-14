using DesignPattern.Behavioral.Observer.Common;

namespace DesignPattern.Behavioral.Observer.WithDesignPattern
{
    public class ProductListener : ISubject<IProduct>
    {
        private readonly double _value;
        private readonly bool _unsubscribeIfNotAvailable;

        private readonly string _productName;

        public ProductListener(double targetPrice, bool unsubscribeIfNotAvailable, string product)
        {
            _value = targetPrice;
            _unsubscribeIfNotAvailable = unsubscribeIfNotAvailable;
            _productName = product;
        }

        public void Update(IProduct product, ISubscriber<IProduct> subscriber)
        {
            if (!product.Name.Equals(_productName)) return;

            if (product.Price <= _value)
                Console.WriteLine($"The product {product.Name} has been bought!");

            if (!product.IsAvailable && _unsubscribeIfNotAvailable)
                subscriber.Unsubscribe(this);
        }
    }
}
