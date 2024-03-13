namespace DesignPatterns.Common
{
    public abstract class BaseExecutor : IExecutor
    {
        public abstract string Description { get; }

        public abstract void Execute();

        public abstract string GetName();
    }
}
