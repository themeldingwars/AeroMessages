/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 187
    MsgName: EliteLevelsInitFrame
META_END
 */
[Aero]
public partial class Character_Event_EliteLevelsInitFrame
{
    public FrameInfo Frame;
}

[AeroBlock]
public struct FrameInfo
{
    [AeroSDB("dbitems::Battleframe", "id")]
    public uint ChassisId; // Note: Only one id when initing one frame

    public uint EliteRank;
    public uint EliteXP;
    public uint ElitePoints;

    [AeroArray(typeof(byte))]
    public AvailableUpgradeInfo[] AvailableUpgrades;

    [AeroArray(typeof(byte))]
    public PreviousUpgradeInfo[] PreviousUpgrades;
}

[AeroBlock]
public struct AvailableUpgradeInfo
{
    public uint UpgradeId; // TODO: Pinpoint sdb table
    public uint Unk_1;
    public float StatValue;

    [AeroArray(typeof(byte))]
    public uint[] AdditionalInfo;
    //public uint? Count;
    //public uint? ItemSDBId;
    //public uint[] Unk_AdditionalInfo;

    public uint LocalizationId;
}

[AeroBlock]
public struct PreviousUpgradeInfo
{
    public uint UpgradeId; // TODO: Pinpoint sdb table
    public uint Count;
}