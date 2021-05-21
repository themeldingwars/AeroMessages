[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 103, Ver: 1962)]
public partial class DisplayUiNotification : AeroBase
{
    [AeroSDB(31,8)]
    public uint LocalizedTextId; // Sdb table 31, id column.

    [AeroArray(6)]
    public byte[] Unk;
}