using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 4, 169)]
    public partial class Character_Command_RequestAchievementStatus
    {
        public uint AchievementId;
    }
}