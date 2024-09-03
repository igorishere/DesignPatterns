using DesignPatterns.Behavioral.Visitor.Common.Data;
using DesignPatterns.Behavioral.Visitor.Common.Importer;

namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor
{
    public class ImporterVisitor : IVisitor
    {
        public void Visit(IData data)
        {

        }

        public void Visit(CSVData data)
        {
            new CSVDataImporter().Import(data);
        }

        public void Visit(XMLData data)
        {
            new XMLDataImporter().Import(data);
        }

        public void Visit(APIData data)
        {
            new ApiDataImporter().Import(data);
        }
    }
}
