[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 106, Ver: 1962)]
public partial class GenericPlaySoundId : AeroBase
{   
    // Sdb table 14, record_id column?
    // Looks like there are variations of the message
    // Record id works for some messages but not all.
    public uint Id_UInt;
    //public ushort Id_UShort_1;
    //public ushort Id_UShort_2;
    //
    [AeroArray(4)]
    public byte[] Unk1;

    [AeroArray(8)]
    public byte[] Unk2;

}