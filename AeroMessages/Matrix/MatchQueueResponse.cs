using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.MatchQueueResponse, MatrixVersion.V1, MatrixVersion.V26)]
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