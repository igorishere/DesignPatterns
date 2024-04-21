using DesignPatterns.Common;

namespace DesignPatterns.Structural.Decorator.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            bool useBold = true;
            bool useItalic = true;

            IPrinter printer;
            string content = "This is a content";

            printer = new BasePrinter();

            if (useBold)
                printer = new TextInBoldPrinter(printer);

            if (useItalic)
                printer = new TextInItalicPrinter(printer);

            Print(printer, content);
        }

        private void Print(IPrinter printer, string content)
        {
            printer.Print(content);
        }
        public override string GetName() => "Decorator";
    }
}
