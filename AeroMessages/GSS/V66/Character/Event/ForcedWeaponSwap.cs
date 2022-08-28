using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 168)]
    public partial class ForcedWeaponSwap
    {
        public byte WeaponIndex;
        public ushort ShortTime;
    }
}