/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 184
    MsgName: PostStatEvent
META_END
 */
[Aero]
public partial class Character_Event_PostStatEvent
{
    [AeroSDB("dbstats::Stat", "Id")] // Not needed but could be nice to link for extra data views in packet peep or other inspectors?
    public uint StatEventId;
    [AeroArray(typeof(uint))]
    public StatData[] Stats;
}

[AeroBlock]
public struct StatData
{
    [AeroString]
    public string Key;
    [AeroSubType(nameof(Key), "FrameTypeId,Volume,DeathStreak,AbilityId,Distance", typeof(StatDataType0))]
    [AeroSubType(nameof(Key), "Value", typeof(StatDataType1))]
    [AeroSubType(nameof(Key), "PlayerGUID,TargetGUID", typeof(StatDataType2))] // If a case is unhandled and there isn't a default handler should we throw and error?
    public StatDataBase Data;
}

[AeroBlock]
public partial class StatDataBase
{
    
}

[AeroBlock]
public partial class StatDataType0 : StatDataBase
{
    public uint Unk1;
    public uint Id;
}

[AeroBlock]
public partial class StatDataType1 : StatDataBase
{
    [AeroArray(8)]
    public byte[] Unk;
}

[AeroBlock]
public partial class StatDataType2 : StatDataBase
{
    public uint Unk1;
    public ulong EntityId;
}