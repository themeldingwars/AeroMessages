using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.NPCApplyEffect, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class NPCApplyEffect
    {
        public uint Unk1;
        public ulong Unk2;
    }
}