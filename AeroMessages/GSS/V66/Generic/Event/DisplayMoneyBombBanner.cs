using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 104)]
    public partial class DisplayMoneyBombBanner
    {
        public uint Unk1;
        [AeroString] public string Unk2;
        public uint Unk3;
    }
}