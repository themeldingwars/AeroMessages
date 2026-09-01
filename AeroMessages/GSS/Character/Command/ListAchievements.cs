using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListAchievements, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ListAchievements
    {
        public byte Unk1;
    }
}