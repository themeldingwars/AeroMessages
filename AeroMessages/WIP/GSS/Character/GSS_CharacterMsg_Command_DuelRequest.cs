/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 118
    MsgName: DuelRequest
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 118)]
    public partial class Character_Command_DuelRequest
    {
        [AeroArray(2)]
        public byte[] Unk1;

        public EntityId RequestingEntity;

        [AeroArray(9)]
        public byte[] Unk2;

        [AeroString]
        public string TargetName;

        [AeroArray(20)]
        public byte[] Unk3;

        public EntityId TargetEntity; // TODO: Verify this, might be in the Unk3
    }
}