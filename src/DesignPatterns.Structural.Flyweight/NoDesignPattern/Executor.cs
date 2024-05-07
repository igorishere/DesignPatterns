using DesignPatterns.Common;

namespace DesignPatterns.Structural.Flyweight.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var cells = new List<ChessTableCell>();
            var linesCount = 8;

            double initialX = 0;
            double initialY = 0;
            double width = 50;
            double height = width;
            var startsWithBlackCell = true;

            for (int i = 0; i < linesCount; i++)
            {
                var newCells = CreateHorizontalLane(initialX, initialY, width, height, startsWithBlackCell);
                startsWithBlackCell = !startsWithBlackCell;
                var firstCell = newCells[0];
                initialY += firstCell.Y + firstCell.Height;
                cells.AddRange(newCells);
            }

            DrawCells(cells);
        }

        public void DrawCells(IEnumerable<ChessTableCell> cells)
        {
            foreach (var cell in cells)
                Console.WriteLine($"Drawing a cell of {cell.Width} x {cell.Height} at position {cell.X} - {cell.Y}");
            
        }

        private ChessTableCell[] CreateHorizontalLane(double initialX, double initialY, double width, double height, bool startsWithBlackCell)
        {
            var columnsCount = 8;
            var cells = new ChessTableCell[columnsCount];

            var blackRGBCode = "#000";
            var whiteRGBCOde = "#FFFFFF";
            var currentColor = startsWithBlackCell ? blackRGBCode : whiteRGBCOde;
            var currentXposition = initialX;

            for (int i = 0; i < columnsCount; i++)
            {
                var newCell = new ChessTableCell(currentXposition, initialY, width, height, currentColor);
                cells[i] = newCell;

                currentColor = currentColor == blackRGBCode ? whiteRGBCOde : blackRGBCode;
                currentXposition += newCell.X + newCell.Width;
            }
            return cells;
        }

        public override string GetName() => "Flyweight";
    }

    public class ChessTableCell
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public ChessTableCell(double x, double y, double width, double height, string color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }
    }
}