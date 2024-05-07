using DesignPatterns.Common;

namespace DesignPatterns.Structural.Flyweight.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var factory =  new ChessCellFactory();
            var table = new ChessTable(factory);

            table.DrawCells();
        }

        public override string GetName() => "Flyweight";
    }

};

