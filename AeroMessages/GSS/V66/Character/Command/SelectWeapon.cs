using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 125)]
    public partial class SelectWeapon
    {
        public uint Time;
        public byte SelectedWeaponIndex;
        public byte Unk3; // This is related to the selected weapon but idk what it is, maybe slot that we are selecting weapon for or something (not that we have multiple slots that are swappable?) Firemode?
    }
}