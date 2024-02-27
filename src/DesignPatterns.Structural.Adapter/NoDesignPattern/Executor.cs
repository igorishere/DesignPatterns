using DesignPatterns.Common;
using DesignPatterns.Structural.Adapter.NoDesignPattern.Usb;

namespace DesignPatterns.Structural.Adapter.NoDesignPattern
{
    public class Executor : IExecutor
    {
        public string Description => "Adatpter - No Design Pattern";

        public void Execute()
        {

            var usbTypeC = new USBTypeCPinout()
            {
                Gnd = new int[] { 1, 12, 13, 24 },
                TXPositive = new int[] { 2, 14 },
                TXNegative = new int[] { 3, 15 },
                Vbus = new int[] { 4, 9, 16, 21 },
                CC1 = new int[] { 5 },
                VCONN= new int[] { 17},
                DataPlus = new int[] { 6 },
                DataMinus = new int[] { 7 },
                SBU = new int[] { 8, 20 },
                RXNegative = new int[] { 10, 22 },
                RXPositive = new int[] { 11, 23 },
            };

            var ground = usbTypeC.Gnd[0];
            var dataplus = usbTypeC.DataMinus[0];
            var dataMinus = usbTypeC.DataPlus[0];
            var fiveVolts = usbTypeC.Vbus[0];

            var usbCable = new UsbMaleConector(dataplus, dataMinus, fiveVolts, ground);

            var usbFemaleConector = new UsbFemaleConector(usbCable);

            TransferData(usbFemaleConector);
        }

        void TransferData(IUSBFemaleConector usbFemaleConector)
        {
            usbFemaleConector.TransferData();
        }
    }
}