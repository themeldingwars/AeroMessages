using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 73)]
    public partial class BountyListActiveDetailsAck
    {
        public byte Success;
        [AeroString(typeof(ushort))] public string JSON;
    }
}