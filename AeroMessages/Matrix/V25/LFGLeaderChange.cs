using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.LFGLeaderChange, MatrixVersion.V14, MatrixVersion.V26)]
    public partial class LFGLeaderChange
    {
        public ulong MatchId;
        public EntityId LeaderId;
        [AeroString] public string LeaderName;
    }
}