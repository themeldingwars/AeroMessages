/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 103
    MsgName: DisplayUiNotification
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_DisplayUiNotification
    {
        [AeroSDB("dblocalization::LocalizedText", "id")]
        public uint LocalizedTextId;

        [AeroArray(6)]
        public byte[] Unk;
    }
}