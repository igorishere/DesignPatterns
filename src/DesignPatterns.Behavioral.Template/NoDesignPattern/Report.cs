namespace DesignPatterns.Behavioral.Template.NoDesignPattern
{
    public class Report
    {
        public void Show(eReportType type)
        {
            ShowHeader(type);
            ShowContent(type);
            ShowFooter(type);
        }

        public void ShowHeader(eReportType type)
        {
            var header = string.Empty;
            if (type == eReportType.COMPLETE)
                header = "Report complete";
            if (type == eReportType.SIMPLIFIED)
                header = "Report simplified";

            Console.WriteLine(header);
            Console.WriteLine("-------------------------");
        }

        public void ShowContent(eReportType type)
        {
            var content = string.Empty;
            if (type == eReportType.COMPLETE)
                content = "This is the content in the complete mode";
            if (type == eReportType.SIMPLIFIED)
                content = "Content in simplified view";

            Console.WriteLine(content);
        }

        public void ShowFooter(eReportType type)
        {
            var footer = string.Empty;
            if (type == eReportType.COMPLETE)
                footer = "Ending report - complete view";
            if (type == eReportType.SIMPLIFIED)
                footer = "Ending report - Simplified view";

            Console.WriteLine("-------------------------");
            Console.WriteLine(footer);
        }
    }
}