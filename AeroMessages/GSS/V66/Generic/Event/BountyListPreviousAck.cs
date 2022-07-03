using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 77)]
    public partial class Generic_Event_BountyListPreviousAck
    {
        [AeroArray(3)]
        public byte[] Unk;

        [AeroString]
        public string JSON;
    }
}