namespace DesignPatterns.Structural.Decorator.WithDesignPattern
{
    public class TextInBoldPrinter : PrinterWrapper
    {
        public TextInBoldPrinter(IPrinter printer) : base(printer)
        {
        }

        public override void Print(string content)
        {
            base.Print(ToBold(content));
        }

        private string ToBold(string content) => $"Bold({content})";
    }
}