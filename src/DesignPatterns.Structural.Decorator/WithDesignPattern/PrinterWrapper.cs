namespace DesignPatterns.Structural.Decorator.WithDesignPattern
{
    //This is the decorator
    public abstract class PrinterWrapper : IPrinter
    {
        private readonly IPrinter? _printer;

        public PrinterWrapper() : this(null)
        {
        }

        public PrinterWrapper(IPrinter printer)
        {
            _printer = printer;
        }
        public virtual void Print(string content)
        {
            if (_printer != null)
                _printer.Print(content);
        }
    }
}
