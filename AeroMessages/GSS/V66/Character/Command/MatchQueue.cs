using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 90)]
    public partial class MatchQueue
    {
        [AeroArray(typeof(byte))] public MatchQueueData[] Queues;
        public ulong Unk2;
        public ulong Unk3;
        [AeroArray(typeof(byte))] public float[] Unk4;
        public uint ChassisId;
        public ulong Unk6;
        public uint Matchmaker;
        public uint Unk8;
        [AeroString] public string Unk9;
        public byte Unk10;
        [AeroString] public string Unk11;
    }

    [AeroBlock]
    public struct MatchQueueData
    {
        public uint QueueId;
        public uint DifficultyId;
    }
}