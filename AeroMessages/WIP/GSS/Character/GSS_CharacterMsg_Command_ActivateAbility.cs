/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 134
    MsgName: ActivateAbility
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_ActivateAbility
    {   
        public uint Time;
        public byte AbilitySlotIndex;

        public byte HaveTargetEntity;

        [AeroIf(nameof(HaveTargetEntity), 1)]
        public TargetData APTTargetingData;

        [AeroIf(nameof(HaveTargetEntity), 0)]
        public Vector3 UnkVector;
    }

    [AeroBlock]
    public struct TargetData
    {
        public EntityId TargetEntity;
        public EntityId InitiatorEntity;

        [AeroArray(5)]
        public byte[] Unk_1;
    }
}