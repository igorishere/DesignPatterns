using DesignPatterns.Behavioral.Command.Common;

namespace DesignPatterns.Behavioral.Command
{
    public class PressShutDownButtonOperationalSystem : ICommand
    {
        private readonly Computer _computer;
        public PressShutDownButtonOperationalSystem(Computer computer)
        {
            this._computer = computer;
        }

        public void Execute()
        {
            Console.WriteLine("Button of shutdonw pressed!");
            _computer.ShutDown();
        }
    }
}