using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 137)]
    public partial class DeactivateAbility
    {
        public uint Time;
        public byte AbilitySlotIndex;
    }
}