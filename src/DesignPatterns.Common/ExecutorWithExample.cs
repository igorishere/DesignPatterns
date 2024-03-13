using System.Xml.Linq;

namespace DesignPatterns.Common
{
    public abstract class ExecutorWithExample : BaseExecutor
    {
        public override string Description => $"{GetName()} - With design pattern";
    }
}
