using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.BroadcastWeaponTweaks, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class BroadcastWeaponTweaks
    {
        public byte Weapon;
        public sbyte Mode;
        public WeaponTweakData Data;
    }
}