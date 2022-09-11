using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 129)]
    public partial class LoseWeaponTarget
    {
        public uint Unk1;
        public ulong Unk2;
    }
}