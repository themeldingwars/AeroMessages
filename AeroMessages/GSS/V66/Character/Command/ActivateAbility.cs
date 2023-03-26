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
        [AeroArray(typeof(byte))] public EntityId[] Targets;
        public float Data1; // Might have some unclean memory use
        public float Data2;
        public float Data3;
        public byte TraceAbilities; // traceAbilities command in console toggles this
    }
}