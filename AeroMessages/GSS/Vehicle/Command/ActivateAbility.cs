using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.ActivateAbility, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class ActivateAbility
    {
        public uint Time;
        public AbilitySlotIndex AbilitySlotIndex;
        [AeroArray(typeof(byte))] public EntityId[] Targets;
        public byte TraceAbilities; // traceAbilities command in console toggles this
    }
}