using DesignPattern.Behavioral.Observer.Common;

namespace DesignPattern.Behavioral.Observer.NoDesignPattern
{
    public class ProductObserver
    {
        private readonly double _value;

        private readonly string _productName;

        public ProductObserver(double targetPrice, string product)
        {
            _value = targetPrice;
            _productName = product;
        }

        public void CheckIfNeedToBuy(IProduct product)
        {
            if (!product.Name.Equals(_productName)) return;

            if (product.Price <= _value)
                Console.WriteLine($"The product {product.Name} has been bought!");
        }
    }
}