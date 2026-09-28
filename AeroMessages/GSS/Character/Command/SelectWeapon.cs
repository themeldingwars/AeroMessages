using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SelectWeapon, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class SelectWeapon
    {
        public uint Time;
        public byte SelectedWeaponIndex;
        public byte PreviousWeaponIndex; // Weapon index before this swap, echoed in the Combat views WeaponIndex
    }
}