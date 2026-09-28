using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.NPCSetInteractionType, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class NPCSetInteractionType
    {
        public byte Unk1;
        public ushort Unk2BitCount; // Number of bits minus one
        [AeroBlob] public byte[] Unk2Bits; // ((Unk2BitCount >> 6) + 1) 64-bit words
    }
}