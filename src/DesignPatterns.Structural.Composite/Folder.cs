namespace DesignPatterns.Structural.Composite
{
    public class Folder : IFolder
    {
        private readonly string _name;
        private double _sizeInMB { get; set; }
        private IDirectoryElement[] _innerItems { get; set; } = new IDirectoryElement[0];
        public Folder(string name)
        {
            _name = name;
        }

        public void DropIntoFolder(IDirectoryElement directoryElement)
        {
            var innerItems = new IDirectoryElement[_innerItems.Count() + 1];

            if(innerItems.Length > 0) 
            {
                for (int i = 0; i < _innerItems.Length; i++)
                {
                    innerItems[i] = _innerItems[i];
                }
            }

            innerItems[innerItems.Length - 1] = directoryElement;
            _innerItems = innerItems;
            _sizeInMB += directoryElement.SizeInMB;
        }

        public IDirectoryElement[] InsideElements => throw new NotImplementedException();

        public string Name => _name;

        public double SizeInMB => _sizeInMB;
    }
}
