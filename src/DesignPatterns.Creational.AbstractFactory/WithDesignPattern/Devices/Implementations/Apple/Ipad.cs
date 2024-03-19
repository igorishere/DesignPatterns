using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Implementations.Apple
{
    public class Ipad : ITablet
    {
        public string Name => "Ipad";
    }
}
