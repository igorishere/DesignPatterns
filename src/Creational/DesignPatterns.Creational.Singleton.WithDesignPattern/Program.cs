using DesignPatterns.Creational.Singleton.WithDesignPattern;

var connection1 = DatabaseConection.Instance;

connection1.CreateConnection();

var connection2 = DatabaseConection.Instance;

connection2.CreateConnection();