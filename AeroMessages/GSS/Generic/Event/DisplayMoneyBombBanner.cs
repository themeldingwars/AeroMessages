using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DisplayMoneyBombBanner, GssVersion.V1, GssVersion.V67)]
    public partial class DisplayMoneyBombBanner
    {
        [AeroSdb("dbcharacter::MoneyBombBanner", "id")]
        public uint SdbId;
        [AeroString] public string SponsoredByName;
        public uint Duration;
    }
}