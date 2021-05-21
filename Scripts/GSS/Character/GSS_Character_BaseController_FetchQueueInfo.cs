[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 89, Ver: 1962)]
public partial class CharacterBaseControllerFetchQueueInfo : AeroBase
{
    [AeroArray(typeof(byte))]
    [AeroNullTermString]
    public string[] Keys;

    [AeroArray(12)]
    public byte[] Unk;
}