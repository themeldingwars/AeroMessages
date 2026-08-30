using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.NPCSetInteractionType, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class NPCSetInteractionType
    {
        public byte Unk1;
        public ushort Unk2; // FUN_007377d0 TODO: Seems like something more is read based of this
    }
}