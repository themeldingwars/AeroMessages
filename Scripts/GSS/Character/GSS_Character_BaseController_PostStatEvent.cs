[Aero(AeroType.Msg, MsgType.GSS, AeroSrc.Server, 2, 184, Ver: 1946)]
public partial class PostStatEvent : AeroBase
{
    [AeroSDB("dbstats::Stat", "Id")] // Not needed but could be nice to link for extra data views in packet peep or other inspectors?
    public uint StatEventId;
    [AeroArray(typeof(uint))]
    public StatData[] Stats;
}

[Aero(AeroType.Block)]
public partial class StatData : AeroBase
{
    [AeroNullTermString]
    public string Key;
    [AeroSubType(nameof(Key), "FrameTypeId,Volume,DeathStreak,AbilityId,Distance", typeof(StatDataType0))]
    [AeroSubType(nameof(Key), "Value", typeof(StatDataType1))]
    [AeroSubType(nameof(Key), "PlayerGUID,TargetGUID", typeof(StatDataType2))] // If a case is unhandled and there isn't a default handler should we throw and error?
    public StatDataBase Data;
}

[Aero(AeroType.Block)]
public partial class StatDataBase : AeroBase
{
    
}

[Aero(AeroType.Block)]
public partial class StatDataType0 : StatDataBase
{
    public uint Unk1;
    public uint Id;
}

[Aero(AeroType.Block)]
public partial class StatDataType1 : StatDataBase
{
    [AeroArray(8)]
    public byte[] Unk;
}

[Aero(AeroType.Block)]
public partial class StatDataType2 : StatDataBase
{
    public uint Unk1;
    public ulong EntityId;
}