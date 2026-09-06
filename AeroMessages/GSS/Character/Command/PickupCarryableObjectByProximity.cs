using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.PickupCarryableObjectByProximity, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class PickupCarryableObjectByProximity
    {
        public EntityId Carryable;
    }
}