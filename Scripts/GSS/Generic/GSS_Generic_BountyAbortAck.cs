[Aero(AeroType.Msg, AeroMsgType.GSS, 0, 70, Ver: 1962)]
public partial class GenericBountyAbortAck : AeroBase
{
    public uint BountyId; // Unsure how this id works
    [AeroArray(2)]
    public byte[] Unk1;
}