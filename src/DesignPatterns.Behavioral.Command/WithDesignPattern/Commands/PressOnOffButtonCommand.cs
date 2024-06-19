using DesignPatterns.Behavioral.Command.Common;

namespace DesignPatterns.Behavioral.Command
{
    public class PressOnOffButtonCommand : ICommand
    {
        private readonly Computer _computer;
        public PressOnOffButtonCommand(Computer computer)
        {
            this._computer = computer;
        }
        public void Execute()
        {
            Console.WriteLine("On/Off button pressed!");
            _computer.ShutDown();
        }
    }
}
