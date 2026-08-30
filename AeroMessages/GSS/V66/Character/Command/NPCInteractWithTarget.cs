using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.NPCInteractWithTarget, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class NPCInteractWithTarget
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
        public uint Unk4;
    }
}