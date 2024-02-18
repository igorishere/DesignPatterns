public interface IUSBTypeCPinout
{
    int[] TXPositive { get; set; }
    int[] TXNegative { get; set; }
    int[] RXPositive { get; set; }
    int[] RXNegative { get; set; }
    int[] DataPlus { get; set; }
    int[] DataMinus { get; set; }

    int[] Vbus { get; set; }
    int[] Gnd { get; set; }
    int[] CC1 { get; set; }
    int[] VCONN { get; set; }

    int[] SBU { get; set; }
}
