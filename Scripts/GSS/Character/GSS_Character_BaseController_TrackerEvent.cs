[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 134, Ver: 1962)]
public partial class CharacterBaseControllerTrackerEvent : AeroBase
{
    public ulong Entity;

    [AeroArray(6)]
    public byte[] Unk1;

    [AeroNullTermString]
    public string Text;

    public byte Unk2;
}