namespace DesignPattern.Behavioral.Observer.WithDesignPattern
{
    public interface ISubject<T>
    {
        public void Update(T subject, ISubscriber<T> item);
    }
}