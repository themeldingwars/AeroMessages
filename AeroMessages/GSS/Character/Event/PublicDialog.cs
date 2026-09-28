using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PublicDialog, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PublicDialog, GssCharacterView.ObserverView, GssVersion.V74, GssVersion.V74)]
    public partial class PublicDialog
    {
        public uint Time;
        [AeroSdb("dbdialogdata::DialogScript", "id")]
        public uint DialogId;
    }
}