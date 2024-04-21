namespace DesignPatterns.Structural.Decorator.NoDesignPattern
{
    public class TextInItalicPrinter : IPrinter
    {
        public void Print(string content)
        {
            ToItalic(content);
        }

        private string ToItalic(string content) => $"Italic({content})";
    }
}
