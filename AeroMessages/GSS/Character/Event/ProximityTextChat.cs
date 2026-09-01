using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProximityTextChat, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ProximityTextChat
    {
        [AeroString] public string Unk1;
        public byte Unk2;
        public byte Unk3;
        public byte Unk4;
        public byte HaveUnk5;
        [AeroIf(nameof(HaveUnk5), 1)]
        [AeroArray(typeof(ushort))] public byte[] Unk5;
    }
}