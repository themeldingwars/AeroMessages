using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PublicCombatLog, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PublicCombatLog, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class PublicCombatLog
    {
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public CombatLogMessage Data;
    }
}