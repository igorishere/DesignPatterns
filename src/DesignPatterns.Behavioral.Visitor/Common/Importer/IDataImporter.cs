using DesignPatterns.Behavioral.Visitor.Common.Data;

namespace DesignPatterns.Behavioral.Visitor.Common.Importer
{
    public interface IDataImporter
    {
        void Import(IData data);
    }
}