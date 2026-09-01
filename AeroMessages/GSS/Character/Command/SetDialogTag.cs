using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SetDialogTag, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SetDialogTag
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
    }
}