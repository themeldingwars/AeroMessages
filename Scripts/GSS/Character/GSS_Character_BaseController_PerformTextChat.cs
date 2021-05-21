[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 145, Ver: 1962)]
public partial class CharacterBaseControllerPerformTextChat : AeroBase
{
    [AeroNullTermString]
    public string Message;
    public byte Channel; // Might be a ushort

    // Remaining bytes are used in whispers (8) and friends chat (14)
    // Not sure about their contents.
    [AeroArray(-1)]
    public byte[] Unk;
}