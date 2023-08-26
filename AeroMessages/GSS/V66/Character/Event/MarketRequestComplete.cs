using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 83)]
    public partial class MarketRequestComplete
    {
        public enum MarketRequestType : byte
        {
            ListItemForSale = 0,
            SendMailToPlayer = 1,
            FillBuyOrder = 2,
        };
        public MarketRequestType Type;
        public ulong Reference;
        public byte Failed;
        [AeroString] public string Code;
        [AeroString] public string Message;
        [AeroString] public string ListingId;
    }
}