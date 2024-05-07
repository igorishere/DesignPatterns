namespace DesignPatterns.Structural.Flyweight.WithDesignPattern
{
    public class ChessTable
    {
        private readonly ChessCellFactory _sharedDataTableCellFactory;
        private List<ChessTableCell> _cells;
        public ChessTable(ChessCellFactory chessCellFactory)
        {
            this._sharedDataTableCellFactory = chessCellFactory;
            this._cells = new List<ChessTableCell>();
            this.Initialize();
        }

        private void Initialize()
        {
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
                _cells.AddRange(newCells);
            }
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
                var data = _sharedDataTableCellFactory.GetColor(currentColor, width, height);
                var newCell = new ChessTableCell(currentXposition, initialY, data);
                cells[i] = newCell;

                currentColor = currentColor == blackRGBCode ? whiteRGBCOde : blackRGBCode;
                currentXposition += newCell.X + newCell.Width;
            }
            return cells;
        }

        public void DrawCells()
        {
            foreach (var cell in _cells)
                Console.WriteLine($"Drawing a cell of {cell.Width} x {cell.Height} at position {cell.X} - {cell.Y}");

        }
    }
};


