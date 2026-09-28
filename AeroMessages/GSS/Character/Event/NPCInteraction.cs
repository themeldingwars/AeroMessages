using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.NPCInteraction, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.NPCInteraction, GssCharacterView.BaseController, GssVersion.V74, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.NPCInteraction, GssCharacterView.NPCController, GssVersion.V74, GssVersion.V74)]
    public partial class NPCInteraction
    {
        public EntityId Target; // Assumption, the 1962 client only logs "Received spurious NPC interaction event"
    }
}