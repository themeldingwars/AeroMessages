/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 89
    MsgName: ProgressionXPRefresh
META_END
 */
[Aero]
public partial class Character_Event_ProgressionXPRefresh
{
    [AeroArray(typeof(byte))]
    public FrameInfo[] Frames;
}

[AeroBlock]
public struct FrameInfo
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ChassisID;

    public uint XpValue1;
    public uint XpValue2;
    public byte CurrentLevel;

    [AeroArray(7)]
    public byte[] Unk;
}