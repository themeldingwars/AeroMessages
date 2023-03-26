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
        public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components
        [AeroArray(typeof(byte))] public EntityId[] Targets;
        public byte Unk2; // TraceAbilities?
    }
}