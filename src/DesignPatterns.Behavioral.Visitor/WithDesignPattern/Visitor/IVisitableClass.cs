namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor
{
    public interface IVisitable
    {
        public void Visit(IVisitor visitor);
    }
}