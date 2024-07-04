namespace DesignPatterns.Behavioral.Memento.WithDesignPattern.Memento
{
    public interface IMemento
    {
        public string createdAt { get; }
        public string createdBy { get; }
    }
}
