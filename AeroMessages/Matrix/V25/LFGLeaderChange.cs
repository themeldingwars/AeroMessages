using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 66)]
    public partial class LFGLeaderChange
    {
        public ulong MatchId;
        public EntityId LeaderId;
        [AeroString] public string LeaderName;
    }
}