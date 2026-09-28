using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Stumble, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Stumble, GssCharacterView.CombatView, GssVersion.V74, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Stumble, GssCharacterView.CombatController, GssVersion.V74, GssVersion.V74)]
    public partial class Stumble
    {
        public ushort ShortTime;
        [AeroSdb("dbcharacter::Stumble", "id")]
        public ushort StumbleId;
        public byte AnimSubstate; // dbcharacter::StumbleDirection.anim_substate, 0..3
    }
}