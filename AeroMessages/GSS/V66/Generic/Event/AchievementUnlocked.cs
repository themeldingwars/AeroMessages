using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 81)]
    public partial class AchievementUnlocked
    {
        [AeroSdb("clientmissions::Mission", "id")] // when is_achievement == 1
        // [AeroSdb("clientmissions::AchievementSetLink", "achievement_id")]
        public ulong AchievementId;
    }
}