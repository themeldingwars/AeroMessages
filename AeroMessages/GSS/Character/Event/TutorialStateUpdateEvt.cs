using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TutorialStateUpdateEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class TutorialStateUpdateEvt
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
    }
}