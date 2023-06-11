using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 42)]
    public partial class MatchQueueResponse
    {
        [AeroArray(typeof(byte))] public MatchQueueResponseData Queues;
        public uint Matchmaker;
    }

    [AeroBlock]
    public struct MatchQueueResponseData
    {
        public uint QueueId; // Assumption
        public uint DifficultyId; // Assumption
        [AeroString] public string QueueName;
        [AeroString] public string QueueType;
    }
}