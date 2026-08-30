using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.NPCInteraction, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class NPCInteraction
    {
        public EntityId Target; // Assumption
    }
}