using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.InteractedWithCompleted, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class InteractedWithCompleted
    {
        public EntityId InteractorId;
        public InteractionType InteractionType;
        public byte Percent;
    }
}