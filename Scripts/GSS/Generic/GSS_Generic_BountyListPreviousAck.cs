[Aero(AeroType.Msg, AeroMsgType.GSS, 0, 77, Ver: 1962)]
public partial class GenericBountyListPreviousAck : AeroBase
{
    [AeroArray(3)]
    public byte[] Unk;

    [AeroNullTermString]
    public string JSON;
}