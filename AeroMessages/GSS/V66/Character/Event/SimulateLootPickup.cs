using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 132)]
    public partial class SimulateLootPickup
    {
        public RewardInfoData Item;
        public byte RewardType; // 2 = match_reward, 3 = encounter_reward
        public byte HaveLootedBy;
        [AeroIf(nameof(HaveLootedBy), 1)]
        public EntityId LootedBy;
    }
}