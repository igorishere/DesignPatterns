namespace DesignPatterns.Structural.Adapter.NoDesignPattern.Usb
{
    public class UsbFemaleConector : IUSBFemaleConector
    {
        private readonly int _dataPlus;
        public int DataPlus => _dataPlus;

        private readonly int _dataMinus;
        public int DataMinus => _dataMinus;

        private readonly int _fiveVolts;
        public int FiveVolts => _fiveVolts;

        private readonly int _ground;
        public int Ground => _ground;

        public UsbFemaleConector(UsbMaleConector usbMaleConector)
        {
            _dataMinus = usbMaleConector.DataMinus;
            _dataPlus = usbMaleConector.DataPlus;
            _fiveVolts = usbMaleConector.FiveVolts;
            _ground = usbMaleConector.Ground;
        }


        public void TransferData()
        {
            Console.WriteLine("Transfering data...");
        }
    }
}
