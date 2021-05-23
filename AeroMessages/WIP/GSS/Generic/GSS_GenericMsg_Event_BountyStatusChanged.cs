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
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_BountyStatusChanged
    {
        public uint BountyId; // Unsure how this id works
        public byte Status;
    }
}