namespace DesignPatterns.Structural.Decorator.NoDesignPattern
{
    public class BoldAndItalicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(ToItalic(ToBold(content)));
        }

        private string ToBold(string content) => $"Bold({content})";
        private string ToItalic(string content) => $"Italic({content})";
    }
}