[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 186, Ver: 1962)]
public partial class CharacterBaseControllerEliteLevelsInitAllFrames : AeroBase
{
    public uint CurrentFrame_Id; 

    [AeroArray(typeof(byte))]
    public FrameInfo[] Frames;
}


[Aero(AeroType.Block)]
public partial class FrameInfo : AeroBase
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

[Aero(AeroType.Block)]
public partial class AvailableUpgradeInfo : AeroBase
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

[Aero(AeroType.Block)]
public partial class PreviousUpgradeInfo : AeroBase
{
    public uint UpgradeId; // TODO: Pinpoint sdb table
    public uint Count;
}