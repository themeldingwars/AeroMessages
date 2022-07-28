using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 128)]
    public partial class AcquireWeaponTarget
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
        public byte Unk4;
    }
}