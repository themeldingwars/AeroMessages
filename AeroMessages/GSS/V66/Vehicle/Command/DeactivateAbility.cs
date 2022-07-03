using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 28, 88)]
    public partial class DeactivateAbility
    {
        public uint Time;
        public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components
    }
}