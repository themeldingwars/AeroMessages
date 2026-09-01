using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SimulateLootPickup, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SimulateLootPickup
    {
        public enum Type : byte
        {
            None = 0,
            General = 1,
            MatchReward = 2,
            EncounterReward = 3,
            MissionReward = 4,
        }
        public RewardInfoData Item;
        public Type RewardType;
        public byte HaveLootedBy;
        [AeroIf(nameof(HaveLootedBy), 1)]
        public EntityId LootedBy;
    }
}