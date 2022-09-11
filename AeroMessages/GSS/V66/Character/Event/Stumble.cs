using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 98)]
    public partial class Stumble
    {   
        public ushort Unk1;
        public ushort Unk2;
        public byte Unk3;
    }
}