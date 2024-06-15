using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 70)]
    public partial class BountyAbortAck
    {
        public uint BountyDefId;
        public byte Success;
        public byte Reason; // [0-4]
    }
}