/*
META_BEGIN
    MsgType: Matrix
    MsgId: 17
    MsgName: Login
META_END
 */
[Aero]
public partial class Matrix_Login
{
    public byte Unk1;
    public ushort ClientVersion;
    [AeroArray(3)]
    public byte[] Unk2;
    public ulong CharacterGUID;
    [AeroArray(13)]
    public byte[] Unk3;
    [AeroString]
    public string Red5Sig2; // From Web Requests to ClientAPI
    public byte Unk4;
    [AeroArray(-1)]
    public byte[] Red5Sig1; // From Web Requests to ClientAPI
}