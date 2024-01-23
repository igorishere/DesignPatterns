using DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Devices.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.WithDesignPattern.Factories.Abstract
{
    public interface IEcosystemAbstractFactory
    {

        string BrandName { get; }

        Icellphone CreateCellPhone();

        ILatop CreateLaptop();

        ITablet CreateTablet();
    }
}
