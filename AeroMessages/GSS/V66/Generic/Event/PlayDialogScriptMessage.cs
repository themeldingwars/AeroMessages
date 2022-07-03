using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 108)]
    public partial class Generic_Event_PlayDialogScriptMessage
    {   
        [AeroSdb("dbdialogdata::DialogScript", "id")]
        public uint DialogId;
        public byte Unk1;
    }
}