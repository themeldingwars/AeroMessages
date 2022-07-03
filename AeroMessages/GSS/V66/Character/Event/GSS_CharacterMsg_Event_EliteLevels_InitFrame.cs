using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 187)]
    public partial class EliteLevels_InitFrame
    {
        public EliteFrameInfoSingle Frame;
    }

    [AeroBlock]
    public struct EliteFrameInfoSingle
    {
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId; // Note: Only one id when initing one frame

        public uint EliteRank;
        public uint EliteXP;
        public uint ElitePoints;

        [AeroArray(typeof(byte))]
        public EliteAvailableUpgradeInfo[] AvailableUpgrades;

        [AeroArray(typeof(byte))]
        public ElitePreviousUpgradeInfo[] PreviousUpgrades;
    }
}