using DesignPatterns.Behavioral.Template.WithDesignPattern.Report;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Template.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var complete = new CompleteReport();
            var simplified = new SimplifiedReport();

            Console.WriteLine("Report complete");
            RunReport(complete);

            Console.WriteLine("Report simplified");
            RunReport(simplified);
        }

        private void RunReport(BaseReport report) => report.Show();

        public override string GetName() => "Template method";
    }
};
