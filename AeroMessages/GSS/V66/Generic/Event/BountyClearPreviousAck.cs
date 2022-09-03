using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 76)]
    public partial class BountyClearPreviousAck
    {
        public byte Unk1;
        public byte Unk2;
    }
}