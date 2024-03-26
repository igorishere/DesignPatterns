namespace DesignPatterns.Structural.Composite
{
    public class File : IFile
    {
        private Dictionary<int, string> _fileExtensions = new Dictionary<int, string>()
        {
            {1, "CSV" },
            {2,"PNG" },
            {3, "ZIP" },
            {4, "JPG" }
        };

        private readonly string _extension;
        private readonly double _sizeInMB;
        private readonly string _name;

        public File(string name)
        {
            var random = new Random();

            _extension = _fileExtensions[random.Next(1, 4)];
            _sizeInMB = random.Next(0, 1000);
            _name = name;
        }

        public string Extension => _extension;

        public string Name => _extension;

        public double SizeInMB => _sizeInMB;
    }
}
