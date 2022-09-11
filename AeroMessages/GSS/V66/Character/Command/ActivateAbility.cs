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
        public EntityId Target;

        // Sometimes floats
        // Sometimes the Data1+Data2 is an entity id...
        [AeroArray(4)] public byte[] Data1; // Who the hell
        [AeroArray(4)] public byte[] Data2; // Thought this was reasonable
        [AeroArray(4)] public byte[] Data3; // Fffffff

        public byte TraceAbilities; // traceAbilities command in console toggles this
    }
}