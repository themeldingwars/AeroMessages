using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 103)]
    public partial class Respawned
    {
        public ushort ShortTime;

        [AeroArray(2)]
        public byte[] Unk;
    }
}