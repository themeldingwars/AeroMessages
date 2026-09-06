using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PrivateCombatLog, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class PrivateCombatLog
    {
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public CombatLogMessage Data;
    }
}