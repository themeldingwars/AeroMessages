using System.Numerics;
using Aero.Gen.Attributes;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.CombatController
{
    [AeroBlock]
    public struct TargetData
    {
        public EntityId Target;
        public EntityId Initiator;
        
        [AeroArray(5)]
        public byte[] Unk_1;
    }

    [Aero]
    public partial class ActivateAbility
    {
        public uint Time;
        public byte AbilitySlotIndex;

        public byte HaveTarget;
        [AeroIf(nameof(HaveTarget), 0, AeroIfAttribute.Ops.NotEqual)]
        public TargetData Target;
        [AeroIf(nameof(HaveTarget), 0)]
        public Vector3 Unk_2; // Position?
    }
}