namespace DesignPatterns.Structural.Decorator.NoDesignPattern
{
    public class TextInBoldPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(ToBold(content));
        }

        private string ToBold(string content) => $"Bold({content})";
    }
}