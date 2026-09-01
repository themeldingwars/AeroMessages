using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SetNoSpreadFlag, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SetNoSpreadFlag
    {
        public byte Unk1;
        public byte Unk2;
    }
}