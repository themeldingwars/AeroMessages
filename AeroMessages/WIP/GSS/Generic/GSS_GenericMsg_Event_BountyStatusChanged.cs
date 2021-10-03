/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 69
    MsgName: BountyStatusChanged
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 69)]
    public partial class Generic_Event_BountyStatusChanged
    {
        public uint BountyId; // Unsure how this id works
        public byte Status;
    }
}