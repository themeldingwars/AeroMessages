using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 100)]
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