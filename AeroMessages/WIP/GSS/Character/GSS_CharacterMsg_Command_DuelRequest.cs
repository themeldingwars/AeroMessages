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
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
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