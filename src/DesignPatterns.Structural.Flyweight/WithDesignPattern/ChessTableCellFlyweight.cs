namespace DesignPatterns.Structural.Flyweight.WithDesignPattern
{
    public class ChessTableCellFlyweight
    {
        public readonly string RGBColor;
        public readonly double Width;
        public readonly double Height;


        public ChessTableCellFlyweight(string color, double width, double height)
        {
            RGBColor = color;
            Width = width;
            Height = height;
        }
    }
}


