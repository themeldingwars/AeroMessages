using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 134)]
    public partial class ActivateAbility
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
        public EntityId Target;
        public EntityId Initiator;

        [AeroArray(5)]
        public byte[] Unk_1;
    }
}