using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AlmostHit, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AlmostHit, GssCharacterView.NPCController, GssVersion.V74, GssVersion.V74)]
    public partial class AlmostHit
    {
        public ulong Unk;
    }
}