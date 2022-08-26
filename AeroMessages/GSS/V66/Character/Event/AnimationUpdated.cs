using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 93)] // Not sure controller
    public partial class AnimationUpdated
    {
        public ushort Unk1;
        public byte Unk2;
    }
}