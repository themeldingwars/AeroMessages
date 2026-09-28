using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.MatchQueueResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class MatchQueueResponse
    {
        public sbyte Success;
        public Matrix.ForceUnqueue.QueueErrorReason FailureReason;
        [AeroArray(typeof(byte))] public ulong[] PlayerIds; // the players the failure is about
        public uint FailureData;
        public ulong Unk5;
        public ulong Unk6;
        public uint RequestId; // echoes MatchQueue.RequestId, 9 matches any request
    }
}