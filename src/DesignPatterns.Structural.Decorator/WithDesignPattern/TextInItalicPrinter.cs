namespace DesignPatterns.Structural.Decorator.WithDesignPattern
{
    public class TextInItalicPrinter : PrinterWrapper
    { 
        public TextInItalicPrinter(IPrinter printer) : base(printer)
        {
        }

        public override void Print(string content)
        {
            base.Print(ToItalic(content));
        }

        private string ToItalic(string content) => $"Italic({content})";
    }
}
