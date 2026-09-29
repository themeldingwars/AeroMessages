using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.MatchQueue, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class MatchQueue
    {
        [AeroArray(typeof(byte))] public MatchQueueData[] Queues;
        public ulong Unk2;
        public ulong TeamId;
        [AeroArray(typeof(byte))] public uint[] LfgCategoryIds;
        public uint ChassisId;
        public ulong SquadId;
        public uint RequestId;
        public uint Unk8;
        [AeroString] public string Difficulty;
        public sbyte SkipMatchmaking;
        [AeroString] public string ZoneGroup;
    }

    [AeroBlock]
    public struct MatchQueueData
    {
        public uint QueueId;
        public uint DifficultyId;
    }
}