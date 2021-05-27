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
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroIfAttribute;

namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_PostStatEvent
    {
        //[AeroSDB("dbstats::Stat", "Id")]
        public uint StatEventId;
        [AeroArray(typeof(uint))]
        public StatData[] Stats;
    }

    [AeroBlock]
    public struct StatData
    {
        [AeroString]
        public string Key;

        [AeroIf(nameof(Key), Ops.Equal, "FrameTypeId", "Volume", "DeathStreak", "AbilityId", "Distance")]
        public StatDataType0 DataType0;

        [AeroIf(nameof(Key), Ops.Equal, "Value")]
        public StatDataType1 DataType1;

        [AeroIf(nameof(Key), Ops.Equal, "PlayerGUID", "TargetGUID")]
        public StatDataType2 DataType2;
    }


    [AeroBlock]
    public struct StatDataType0
    {
        public uint Unk1;
        public uint Id;
    }

    [AeroBlock]
    public struct StatDataType1
    {
        [AeroArray(8)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct StatDataType2
    {
        public uint Unk1;
        public EntityId EntityId;
    }
}