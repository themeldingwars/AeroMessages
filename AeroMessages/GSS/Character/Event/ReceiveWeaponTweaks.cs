using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ReceiveWeaponTweaks, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ReceiveWeaponTweaks
    {
        public byte Weapon;
        public sbyte Mode;
        public WeaponTweakData Data;
    }
}