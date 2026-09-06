using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FriendsListChanged, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FriendsListChanged
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
        public byte Unk5;
    }
}