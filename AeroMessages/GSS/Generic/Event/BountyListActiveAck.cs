using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyListActiveAck, GssVersion.V1, GssVersion.V67)]
    public partial class BountyListActiveAck
    {
        public byte Success;
        public byte Unk2; // Count or category?
        [AeroString(typeof(ushort))] public string JSON;
    }
}