using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Implementations.Samsung;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Interfaces;
using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Concrete
{
    public class SamsungEcossystemFactory : IEcosystemAbstractFactory
    {
        public string BrandName => "Samsung";

        public Icellphone CreateCellPhone() => new S24();

        public ILatop CreateLaptop() => new GalaxyBook();

        public ITablet CreateTablet() => new GalaxyTab();
    }
}
