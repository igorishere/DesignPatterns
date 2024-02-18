namespace DesignPatterns.Structural.Adapter.NoDesignPattern.Usb
{
    public interface IUsbPinout
    {
        int DataPlus { get; }
        int DataMinus { get; }
        int FiveVolts { get; }
        int Ground { get; }
    }

    public interface IUSBFemaleConector : IUsbPinout
    {
        void TransferData();
    }
}
