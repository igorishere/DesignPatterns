namespace DesignPatterns.Structural.Composite
{
    public interface IDirectoryElement
    {
        string Name { get; }
        double SizeInMB { get; }
    }

    public interface IFile : IDirectoryElement
    {
        string Extension { get; }
    }

    public interface IFolder : IDirectoryElement
    {
        public IDirectoryElement[] InsideElements { get; }
    }
}
