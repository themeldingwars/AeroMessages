/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 108
    MsgName: PlayDialogScriptMessage
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_PlayDialogScriptMessage
    {   
        [AeroSdb("dbdialogdata::DialogScript", "id")]
        public uint DialogId;
        public byte Unk1;
    }
}