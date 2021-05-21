[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 89, Ver: 1962)]
public partial class CharacterBaseControllerProgressionXPRefresh : AeroBase
{
    [AeroArray(typeof(byte))]
    public FrameInfo[] Frames;
}

public partial class FrameInfo : AeroBase
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ChassisID;

    public uint XpValue1;
    public uint XpValue2;
    public byte CurrentLevel;

    [AeroArray(7)]
    public byte[] Unk;
}