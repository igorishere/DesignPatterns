using DesignPatterns.Behavioral.Visitor.Common.Data;
using DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor;

namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern.Data
{
    public class ApiDataVisitable : APIData, IVisitable
    {
        public void Visit(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}