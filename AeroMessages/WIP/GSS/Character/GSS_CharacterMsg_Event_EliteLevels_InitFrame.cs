/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 187
    MsgName: EliteLevels_InitFrame
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_EliteLevels_InitFrame
    {
        public EliteFrameInfoSingle Frame;
    }

    [AeroBlock]
    public struct EliteFrameInfoSingle
    {
        [AeroSDB("dbitems::Battleframe", "id")]
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