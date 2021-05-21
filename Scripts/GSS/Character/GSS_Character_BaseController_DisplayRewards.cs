[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 133, Ver: 1962)]
public partial class CharacterBaseControllerDisplayRewards : AeroBase
{
    public uint IndexId; // Used by client when claiming

    [AeroSDB("dblocalization::LocalizedText", "id")]
    public uint TitleLocalizationId;

    [AeroArray(8)]
    public byte[] Unk1;

    [AeroArray(typeof(byte))]
    public StatInfo[] Stats;

    [AeroArray(typeof(byte))]
    public RewardInfo[] Rewards;

    [AeroArray(9)]
    public byte[] Unk2;

    public byte HaveExperience;
    public uint Experience;

    [AeroArray(3)]
    public byte[] Unk3;
}


[Aero(AeroType.Block)]
public partial class StatInfo : AeroBase
{
    [AeroSDB("dblocalization::LocalizedText", "id")]
    public uint LocalizationId;

    [AeroArray(6)]
    public byte[] Unk;
}

[Aero(AeroType.Block)]
public partial class RewardInfo : AeroBase
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint SdbId;
    public ushort Quantity;
    public ushort Unk1;

    [AeroArray(11)]
    public byte[] Unk2;
}