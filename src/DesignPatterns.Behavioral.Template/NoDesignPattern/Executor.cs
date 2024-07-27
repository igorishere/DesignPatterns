using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Template.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var report = new Report();
            
            Console.WriteLine("Report complete");
            report.Show(eReportType.COMPLETE);

            Console.WriteLine("Report simplified");
            report.Show(eReportType.SIMPLIFIED);
        }

        public override string GetName() => "Template method";
    }
};
