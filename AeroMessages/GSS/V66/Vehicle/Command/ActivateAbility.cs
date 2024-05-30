using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 28, 87)]
    public partial class ActivateAbility
    {
        public uint Time;
        public AbilitySlotIndex AbilitySlotIndex;
        [AeroArray(typeof(byte))] public EntityId[] Targets;
        public byte TraceAbilities; // traceAbilities command in console toggles this
    }
}