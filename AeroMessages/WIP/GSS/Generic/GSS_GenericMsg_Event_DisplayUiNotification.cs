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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 103)]
    public partial class Generic_Event_DisplayUiNotification
    {
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint LocalizedTextId;

        [AeroArray(6)]
        public byte[] Unk;
    }
}