using DesignPatterns.Behavioral.Visitor.Common.Data;

namespace DesignPatterns.Behavioral.Visitor.Common.Importer
{
    public class ApiDataImporter : IDataImporter
    {
        public void Import(IData data)
        {
            Console.WriteLine("Executing logic to import data from api");
        }
    }
}
