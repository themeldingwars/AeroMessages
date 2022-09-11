using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 161)]
    public partial class SelfReviveResponse
    {
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}