using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 80)]
    public partial class Achievements
    {
        [AeroArray(typeof(byte))]
        public AchievementData[] Data;
    }

    [AeroBlock]
    public struct AchievementData
    {
        [AeroSdb("clientmissions::Mission", "id")] // when is_achievement == 1
        [AeroSdb("clientmissions::AchievementSetLink", "achievement_id")]
        public uint AchievementId;
        public byte IsCombatAward; // based on FUN_00ecf790
    }
}