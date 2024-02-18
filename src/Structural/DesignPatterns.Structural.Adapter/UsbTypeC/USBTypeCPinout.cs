namespace DesignPatterns.Structural.Adapter.NoDesignPattern.Usb
{
    public class USBTypeCPinout : IUSBTypeCPinout
    { 
        public int[] TXPositive { get; set; }
        public int[] TXNegative { get; set; }
        public int[] RXPositive { get; set; }
        public int[] RXNegative { get; set; }
        public int[] DataPlus { get; set; }
        public int[] DataMinus { get; set; }


        public int[] Vbus { get; set; }
        public int[] Gnd { get; set; }
        public int[] CC1 { get; set; }
        public int[] VCONN { get; set; }

        public int[] SBU { get; set; } 
    }
}
