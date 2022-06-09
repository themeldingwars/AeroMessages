using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 28, 87)]
    public partial class Vehicle_Command_ActivateAbility
    {
        public uint Time;
        public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components

        [AeroArray(2)]
        public byte[] Unk;
    }
}