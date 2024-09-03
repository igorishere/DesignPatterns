using DesignPatterns.Behavioral.Visitor.Common.Data;
using DesignPatterns.Behavioral.Visitor.Common.Importer;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Visitor.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var dataToImport = new List<IData>()
             {
                new CSVData(),
                new XMLData(),
                new APIData(),
             };

            var csvDataImporter = new CSVDataImporter();
            var xmlDataImporter = new XMLDataImporter();
            var apiDataImporter = new ApiDataImporter();

            foreach (var data in dataToImport)
            {
                if (data is CSVData)
                    csvDataImporter.Import(data);

                if (data is XMLData)
                    xmlDataImporter.Import(data);

                if (data is APIData)
                    apiDataImporter.Import(data);
            }
        }

        public override string GetName() => "Visitor";
    }
 
}
