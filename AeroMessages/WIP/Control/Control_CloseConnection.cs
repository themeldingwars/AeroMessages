/*
META_BEGIN
    MsgType: Control
    MsgId: 0
    MsgName: CloseConnection
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 0)]
    public partial class Control_CloseConnection
    {
        [AeroArray(4)]
        public byte[] Unk;
    }
}