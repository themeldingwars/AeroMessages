using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.Achievements, GssVersion.V1, GssVersion.V67)]
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
        public byte Completed; // 1 = Completed, 0 = Incomplete
    }
}