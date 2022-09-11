using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 194)]
    public partial class FriendsListChanged
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
        public byte Unk5;
    }
}