using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ForcedMovement, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class ForcedMovement
    {
        public ForcedMovementData Data;
        public ushort ShortTime;
    }
}