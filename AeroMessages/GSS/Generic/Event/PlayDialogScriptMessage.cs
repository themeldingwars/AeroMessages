using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PlayDialogScriptMessage, GssVersion.V1, GssVersion.V74)]
    public partial class PlayDialogScriptMessage
    {
        [AeroSdb("dbdialogdata::DialogScript", "id")]
        public uint DialogId;

        [AeroArray(typeof(byte))] public ulong[] Unk1;
    }
}