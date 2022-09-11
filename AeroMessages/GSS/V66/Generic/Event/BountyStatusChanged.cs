using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 69)]
    public partial class BountyStatusChanged
    {
        public uint BountyId; // Unsure how this id works
        public byte Status;
    }
}