using DesignPatterns.Behavioral.Visitor.Common.Data;
using DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor;

namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern.Data
{
    public class CSVDataVisitable : CSVData, IVisitable
    {
        public void Visit(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}