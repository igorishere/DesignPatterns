using DesignPatterns.Common;
using System.Reflection;

namespace DesignPatterns.StartUp
{
    public class DesignPatternExecutorRegistry
    {
        private static DesignPatternExecutorRegistry? _instance;
        public static DesignPatternExecutorRegistry Instance => _instance ??= new DesignPatternExecutorRegistry();
        private readonly Dictionary<int, IExecutor> _executors;
        public Dictionary<int, IExecutor> GetAll() => _executors;

        public DesignPatternExecutorRegistry()
        {
            var allAssemblies = LoadAllDLLs();

            var executableType = typeof(IExecutor);
            var implementingClasses = new List<Type>();
            var patternExecutors = new List<IExecutor>();
            foreach (var assembly in allAssemblies)
            { 
                foreach (var type in assembly.GetTypes())
                { 
                    if (executableType.IsAssignableFrom(type) && type.IsClass && !type.IsAbstract)
                    {
                        try
                        {
                            var instance = Activator.CreateInstance(type);
                            patternExecutors.Add(instance as IExecutor);
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                        implementingClasses.Add(type);
                    }
                }
            }

            var serialNumber = 1;
            _executors = new Dictionary<int, IExecutor>();

            foreach (var executor in patternExecutors.OrderBy(pattern => pattern.Description))
            {
                _executors.Add(serialNumber++, executor);
            }
        }

        private IEnumerable<Assembly> LoadAllDLLs()
        {
            var solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var dlls = Directory.GetFiles(solutionDirectory, "*.dll", SearchOption.AllDirectories);
            var executables = new List<IExecutor>();

            var assemblies = new List<Assembly>();
            foreach (var dll in dlls)
            {
                try
                {
                    assemblies.Add(Assembly.LoadFrom(dll));
                }
                catch (BadImageFormatException)
                {
                    // Ignora arquivos que não são assemblies .NET
                }
            }

            return assemblies;
        }
    }
}
