[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 187, Ver: 1962)]
public partial class CharacterBaseControllerEliteLevelsInitFrame : AeroBase
{
    public FrameInfo Frame;
}

[Aero(AeroType.Block)]
public partial class FrameInfo : AeroBase
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