using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.AcquireWeaponTarget, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class AcquireWeaponTarget
    {
        public uint Unk1;
        public ulong Unk2;
        public float Unk3;
        public sbyte Unk4;
    }
}