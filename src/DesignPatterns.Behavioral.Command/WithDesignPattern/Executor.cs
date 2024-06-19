using DesignPatterns.Behavioral.Command.Common;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Command.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var computador = new Computer();
            var random = new Random();

            var possibleCommands = new List<ICommand>()
            {
                new AltF4ShortCutCommand(computador),
                new PressShutDownButtonOperationalSystem(computador),
                new PressOnOffButtonCommand(computador)
            }.ToArray();

            var index = random.NextInt64(0, 2);

            var choosedCommand = possibleCommands[index];
            choosedCommand.Execute();
        }

        public override string GetName() => "Command";
    }
}