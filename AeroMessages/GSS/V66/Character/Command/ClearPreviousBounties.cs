using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ClearPreviousBounties, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ClearPreviousBounties
    {
        public byte Unk1;
    }
}