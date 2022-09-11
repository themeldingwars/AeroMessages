using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 88)]
    public partial class RewardInfo
    {
        public byte RewardType;
        public byte Bonus_RewardType; // Uncertain about this
        public EntityId RelatedEntity;
        public uint Unk_RewardValue; // Not the value that is displayed?
        public uint Unk3;
        public uint Bonus_RewardValue; // Matches expectations
    }
}