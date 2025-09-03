using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 88)]
    public partial class RewardInfo
    {
        public byte RewardType; // If not 0xf, isExp will be true.

        public byte BonusType; // Part of a special condition when RelatedEntity is a Character and this is XP_REWARD_KILL or XP_REWARD_HEADSHOT, as well as some other condition that probably depend on the RelatedEntity. Maybe Audio related???

        public EntityId RelatedEntity; // If set the UI tries to show the reward from this enemy

        public uint RewardValue; // If this value is greater than BonusValue, the BonusValue is subtracted from it.

        public uint KillCount; // If the reward type is XP_REWARD_KILL_STREAK or XP_REWARD_MULTIPLE_KILL, this is appended to the rewardType string.

        public uint BonusValue; // If this is not 0, an additional UI event 0x71 is sent with rewardType XP_REWARD_BONUS, and this will be the rewardValue. isBonus will be set to 1. isExp will be based of the actual RewardType.
    }
}