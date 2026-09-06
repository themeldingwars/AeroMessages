using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.DuelNotification, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)] // Uncertain controller
    public partial class DuelNotification
    {
        public DuelData Unk1;
        public ulong Unk2;
    }
}