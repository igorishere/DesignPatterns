namespace DesignPatterns.Structural.Adapter.NoDesignPattern.Usb
{
    public class UsbMaleConector : IUsbPinout
    {
        public UsbMaleConector(int dataPLus, int dataMinus, int fiveVolts, int ground)
        {
            _dataPlus = dataPLus;
            _dataMinus = dataMinus;
            _fiveVolts = fiveVolts;
            _ground = ground;
        }

        private readonly int _dataPlus;
        public int DataPlus => _dataPlus;

        private readonly int _dataMinus;
        public int DataMinus => _dataMinus;

        private readonly int _fiveVolts;
        public int FiveVolts => _fiveVolts;

        private readonly int _ground;
        public int Ground => _ground;
    }
}
