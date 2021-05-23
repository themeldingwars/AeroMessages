/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 186
    MsgName: EliteLevelsInitAllFrames
META_END
 */
[Aero]
public partial class Character_Event_EliteLevelsInitAllFrames
{
    public uint CurrentFrame_Id; 

    [AeroArray(typeof(byte))]
    public FrameInfo[] Frames;
}

[AeroBlock]
public struct FrameInfo
{
    [AeroSDB("dbitems::Battleframe", "id")]
    public uint ChassisId_1; // Might just be that the data is indexed by this or something
    
    [AeroSDB("dbitems::Battleframe", "id")]
    public uint ChassisId_2;

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