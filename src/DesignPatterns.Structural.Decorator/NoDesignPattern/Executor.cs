using DesignPatterns.Common;

namespace DesignPatterns.Structural.Decorator.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            bool useBold = true;
            bool useItalic = true;

            IPrinter printer;
            string content = "This is a content";

            if (!useBold && !useItalic)
                printer = new BasePrinter();
            else if (useBold)
                printer = new TextInBoldPrinter();
            else if (useItalic)
                printer = new TextInItalicPrinter();
            else
                printer = new BoldAndItalicPrinter();

            Print(printer, content);
        }

        private void Print(IPrinter printer, string content)
        {
            printer.Print(content);
        }

        public override string GetName() => "Decorator";
    }
}
