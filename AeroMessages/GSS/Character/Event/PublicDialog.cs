using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PublicDialog, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class PublicDialog
    {
        public uint Unk1;
        public uint Unk2;
    }
}