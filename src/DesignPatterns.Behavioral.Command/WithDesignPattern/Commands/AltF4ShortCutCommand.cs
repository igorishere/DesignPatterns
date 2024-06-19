using DesignPatterns.Behavioral.Command.Common;

namespace DesignPatterns.Behavioral.Command
{
    public class AltF4ShortCutCommand : ICommand
    {
        private readonly Computer _computer;
        public AltF4ShortCutCommand(Computer computer)
        {
            this._computer = computer;
        }

        public void Execute()
        {
            Console.WriteLine("Alt + F4 pressed");
            _computer.ShutDown();
        }
    }
}