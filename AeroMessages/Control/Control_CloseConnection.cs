using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 0)]
    public partial class CloseConnection
    {
        [AeroArray(4)]
        public byte[] Unk;
    }
}