using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 104)]
    public partial class DisplayMoneyBombBanner
    {
        [AeroSdb("dbcharacter::MoneyBombBanner", "id")]
        public uint SdbId;
        [AeroString] public string SponsoredByName;
        public uint Duration;
    }
}