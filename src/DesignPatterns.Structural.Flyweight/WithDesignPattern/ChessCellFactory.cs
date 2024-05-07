namespace DesignPatterns.Structural.Flyweight.WithDesignPattern
{
    public class ChessCellFactory
    {
        private Dictionary<string, ChessTableCellFlyweight> _remainingDataByKeyDictionary { get; set; }

        public ChessCellFactory()
        {
            _remainingDataByKeyDictionary = new Dictionary<string, ChessTableCellFlyweight>();
        }

        public ChessTableCellFlyweight GetColor(string RGBColor, double width, double height)
        {
            ChessTableCellFlyweight data;
            var key = $"{RGBColor}.{width}.{height}";

            if (_remainingDataByKeyDictionary.TryGetValue(key, out data))
            {
                return data;
            }

            data = new ChessTableCellFlyweight(RGBColor,width,height);
            _remainingDataByKeyDictionary.Add(key,data);

            return data;
        }
    }
}


