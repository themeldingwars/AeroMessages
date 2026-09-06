using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.LoseWeaponTarget, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class LoseWeaponTarget
    {
        public uint Unk1;
        public ulong Unk2;
    }
}