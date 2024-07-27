namespace DesignPatterns.Behavioral.Template.WithDesignPattern.Report
{
    public class CompleteReport: BaseReport
    {
        protected override void ShowContent()
        {
            Console.WriteLine("This is the content in the complete mode");
        }

        protected override void ShowFooter()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ending report - complete view");
        }

        protected override void ShowHeader()
        {
            Console.WriteLine("Complete report");
            Console.WriteLine("-------------------------");
        }
    }
}
