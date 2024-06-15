using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 77)]
    public partial class BountyListPreviousAck
    {
        public byte Success;
        [AeroString(typeof(ushort))] public string JSON;
    }
}