using DesignPatterns.Common;

namespace DesignPatterns.Structural.Composite.WithDesignPattern
{
    internal class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
            var file1 = new File("file 1");
            var file2 = new File("file 2");

            var folder1 = new Folder("folder 1");
            var folder2 = new Folder("folder 2");

            folder1.DropIntoFolder(file1);
            folder1.DropIntoFolder(file2);
            folder1.DropIntoFolder(folder2);

            var folder3 = new Folder("folder 3");
            var folder4 = new Folder("folder 4");
            var file5 = new Folder("file 5");

            folder3.DropIntoFolder(folder4);
            folder3.DropIntoFolder(file5);

            var rootFolder = new Folder("root");
            rootFolder.DropIntoFolder(folder3);
            rootFolder.DropIntoFolder(folder1);

            Console.WriteLine($"Elapsed size: {rootFolder.SizeInMB}MB");
        }

        public override string GetName() => "Composite";
    }
}
