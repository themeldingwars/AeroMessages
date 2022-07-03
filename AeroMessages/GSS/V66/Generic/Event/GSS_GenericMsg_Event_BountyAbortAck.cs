using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 70)]
    public partial class Generic_Event_BountyAbortAck
    {
        public uint BountyId; // Unsure how this id works
        [AeroArray(2)]
        public byte[] Unk1;
    }
}