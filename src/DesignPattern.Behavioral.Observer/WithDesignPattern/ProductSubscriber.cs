using DesignPattern.Behavioral.Observer.Common;

namespace DesignPattern.Behavioral.Observer.WithDesignPattern
{
    public class ProductSubscriber : ISubscriber<IProduct>
    {
        private List<ISubject<IProduct>> _listeners;
        private IProduct _currentProduct;

        public ProductSubscriber()
        {
            _listeners = new List<ISubject<IProduct>>();
        }

        public void Notify(IProduct product)
        {
            _currentProduct = product;
            this.Notify();
        }

        public void Notify()
        {
            var listeners = _listeners.ToList();
            foreach (var listener in listeners)
                listener.Update(_currentProduct, this);
        }

        public void Subscribe(ISubject<IProduct> subject) => _listeners.Add(subject);

        public void Unsubscribe(ISubject<IProduct> subject) => _listeners.Remove(subject);
    }
}