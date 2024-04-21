namespace DesignPatterns.Structural.Decorator.NoDesignPattern
{
    public class BasePrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}
