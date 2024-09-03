using DesignPatterns.Behavioral.Visitor.Common.Data;

namespace DesignPatterns.Behavioral.Visitor.Common.Importer
{
    public class XMLDataImporter : IDataImporter
    {
        public void Import(IData data)
        {
            Console.WriteLine("Executing logic to import data from xml");
        }
    }
}
