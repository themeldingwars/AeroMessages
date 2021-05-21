[Aero(AeroType.Msg, MsgType.Matrix, 17, Ver: 1946)]
public partial class Login : AeroBase
{
    public byte Unk1;
    public ushort ClientVersion;
    [AeroArray(3)]
    public byte[] Unk2;
    public ulong CharacterGUID;
    [AeroArray(13)]
    public byte[] Unk3;
    [AeroNullTermString]
    public string Red5Sig2; // From Web Requests to ClientAPI
    public byte Unk4;
    [AeroArray(-1)]
    public byte[] Red5Sig1; // From Web Requests to ClientAPI
}