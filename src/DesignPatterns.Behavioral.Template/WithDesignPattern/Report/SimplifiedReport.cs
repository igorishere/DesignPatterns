namespace DesignPatterns.Behavioral.Template.WithDesignPattern.Report
{
    public class SimplifiedReport : BaseReport
    {
        protected override void ShowContent()
        {
            Console.WriteLine("Content in simplified view");
        }

        protected override void ShowFooter()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ending report - Simplified view");
        }

        protected override void ShowHeader()
        {
            Console.WriteLine("Simplified report");
            Console.WriteLine("-------------------------");
        }
    }
}
