using DesignPatterns.Structural.Adapter.NoDesignPattern.Usb;

namespace DesignPatterns.Structural.Adapter.WithDesignPattern
{
    public class UsbTypeCToUsbAdapter : IUSBFemaleConector
    {
        public UsbTypeCToUsbAdapter(IUSBTypeCPinout uSBTypeCPinout)
        {
            _ground = uSBTypeCPinout.Gnd[0];
            _dataMinus = uSBTypeCPinout.DataMinus[0];
            _dataPlus = uSBTypeCPinout.DataPlus[0];
            _fiveVolts = uSBTypeCPinout.Vbus[0];
        }

        private readonly int _dataPlus;
        public int DataPlus => _dataPlus;

        private readonly int _dataMinus;
        public int DataMinus => _dataMinus;

        private readonly int _fiveVolts;
        public int FiveVolts => _fiveVolts;

        private readonly int _ground;
        public int Ground => _ground;

        public void TransferData()
        {
            Console.Write("Transfering data");
        }
    }
}
