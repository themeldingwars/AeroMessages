using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 114)]
    public partial class BroadcastWeaponTweaks
    {
        public byte Unk1;
        public sbyte Unk2;
    }
}