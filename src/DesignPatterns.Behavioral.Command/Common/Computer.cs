namespace DesignPatterns.Behavioral.Command.Common
{
     public class Computer
    {
        public void TurnOn() => Log("The PC is waking up!");
        public void ShutDown() => Log("The PC is shutting down!");
        private void Log(string text) => Console.WriteLine(text);
    }
}