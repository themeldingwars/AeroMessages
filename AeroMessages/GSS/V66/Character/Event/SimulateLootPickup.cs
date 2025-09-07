using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 132)]
    public partial class SimulateLootPickup
    {
        public enum Type : byte
        {
            MatchReward = 2,
            EncounterReward = 3,
            // VendorPurchase = ?
        }
        public RewardInfoData Item;
        public Type RewardType;
        public byte HaveLootedBy;
        [AeroIf(nameof(HaveLootedBy), 1)]
        public EntityId LootedBy;
    }
}