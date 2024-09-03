using DesignPatterns.Behavioral.Visitor.WithDesignPattern.Data;
using DesignPatterns.Behavioral.Visitor.WithDesignPattern.Visitor;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Visitor.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var dataToImport = new List<IVisitable>()
             {
                new CSVDataVisitable(),
                new XMLDataVisitable(),
                new ApiDataVisitable(),
             };

            var importer = new ImporterVisitor();

            foreach (var data in dataToImport)
                data.Visit(importer);
        }

        public override string GetName() => "Visitor";
    }
};
