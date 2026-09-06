using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PrivateDialog, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class PrivateDialog
    {
        public uint Time;
        public EntityId Entity;
        public uint DialogId; // TODO: "dbdialogdata::DialogScript" ?
    }
}