using DesignPatterns.Behavioral.Visitor.Common.Data;

namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor
{
    public interface IVisitor
    {
        void Visit(IData data);

        void Visit(CSVData data);

        void Visit(XMLData data);

        void Visit(APIData data);
    }
}