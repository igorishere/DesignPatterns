namespace DesignPattern.Behavioral.Observer.Common
{
    public interface IProduct
    {
        public string Name {get;set;}
        public double Price {get;set;}
        public bool IsAvailable {get;}
    }
}