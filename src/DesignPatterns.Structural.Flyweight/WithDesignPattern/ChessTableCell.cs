namespace DesignPatterns.Structural.Flyweight.WithDesignPattern
{
    public class ChessTableCell
    {
        public readonly double X;
        public readonly double Y;

        public ChessTableCellFlyweight SharedData;

        public double Width => SharedData.Width;
        public double Height => SharedData.Height;


        public ChessTableCell(double x, double y, ChessTableCellFlyweight sharedData)
        {
            this.SharedData = sharedData;
            this.X = x;
            this.Y = y;
        }
    }
};


