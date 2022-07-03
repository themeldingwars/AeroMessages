using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 89)]
    public partial class FetchQueueInfo
    {
        [AeroArray(typeof(byte))]
        [AeroString]
        public string[] Keys;

        [AeroArray(12)]
        public byte[] Unk;
    }
}