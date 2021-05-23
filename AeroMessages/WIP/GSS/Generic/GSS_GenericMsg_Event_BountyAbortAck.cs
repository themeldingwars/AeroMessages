/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 70
    MsgName: BountyAbortAck
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_BountyAbortAck
    {
        public uint BountyId; // Unsure how this id works
        [AeroArray(2)]
        public byte[] Unk1;
    }
}