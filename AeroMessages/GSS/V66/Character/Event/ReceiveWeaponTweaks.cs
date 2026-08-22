using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 84)]
    public partial class ReceiveWeaponTweaks
    {
        public byte Unk1; // Weapon
        public sbyte Unk2; // Mode

        // TODO: Consume remaining data
        // size must be exactlyt 0x19c bytes in 1946
    }
}