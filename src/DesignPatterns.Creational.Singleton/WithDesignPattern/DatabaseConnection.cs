namespace DesignPatterns.Creational.Singleton.WithDesignPattern
{
    public class DatabaseConection
    {
        private static DatabaseConection _instance;
        public static DatabaseConection Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new DatabaseConection();

                return _instance;
            }
        }

        private DatabaseConection()
        {

        }

        public void CreateConnection()
        {
            Console.WriteLine("Creating connection...");
            Console.WriteLine("Connection stablished...");
        }
    }
}
