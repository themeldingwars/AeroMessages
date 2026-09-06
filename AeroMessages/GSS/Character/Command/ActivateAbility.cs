using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ActivateAbility, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class ActivateAbility
    {
        public uint Time;
        public byte AbilitySlotIndex;
        [AeroArray(typeof(byte))] public EntityId[] Targets;
        public float Data1; // Might have some unclean memory use
        public float Data2;
        public float Data3;
        public byte TraceAbilities; // traceAbilities command in console toggles this
    }
}