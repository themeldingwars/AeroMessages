using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PriorityTargetSet, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class PriorityTargetSet
    {
        public EntityId Target; // Assumption
        public Vector3 Position; // Assumption
    }
}