namespace DesignPattern.Behavioral.Observer.WithDesignPattern
{
    public interface ISubscriber<T>
    {
        public void Subscribe(ISubject<T> subject);
        public void Unsubscribe(ISubject<T> subject);
        public void Notify();
    }
}