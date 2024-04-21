namespace DesignPatterns.Structural.Decorator.WithDesignPattern
{
    public class BasePrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}