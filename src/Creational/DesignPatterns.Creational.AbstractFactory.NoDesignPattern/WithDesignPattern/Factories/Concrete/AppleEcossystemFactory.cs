using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Implementations.Apple;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Interfaces;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Concrete
{
    public class AppleEcossystemFactory : IEcosystemAbstractFactory
    {
        public string BrandName => "Apple";

        public Icellphone CreateCellPhone() => new Iphone();

        public ILatop CreateLaptop() => new Macbook();

        public ITablet CreateTablet() => new Ipad();
    }
}
