using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 83)]
    public partial class MarketRequestComplete
    {
        public byte Unk1;
        public ulong Unk2;
        public byte Unk3;
        [AeroString] public string Unk4;
        [AeroString] public string Unk5;
        [AeroString] public string Unk6;
    }
}