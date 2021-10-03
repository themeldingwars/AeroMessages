/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 88
    MsgName: RewardInfo
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 88)]
    public partial class Character_Event_RewardInfo
    {
        public byte RewardType;
        public byte Bonus_RewardType; // Uncertain about this

        public EntityId RelatedEntity;

        public uint Unk_RewardValue; // Not the value that is displayed?

        [AeroArray(4)]
        public byte[] Unk3;
        public uint Bonus_RewardValue; // Matches expectations
    }
}