using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ClaimDailyRewardItem, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ClaimDailyRewardItem
    {
        public uint Unk1;
    }
}