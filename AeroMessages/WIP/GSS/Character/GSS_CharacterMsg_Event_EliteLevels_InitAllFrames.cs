/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 186
    MsgName: EliteLevels_InitAllFrames
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 186)]
    public partial class Character_Event_EliteLevels_InitAllFrames
    {
        public uint CurrentFrame_Id; 

        [AeroArray(typeof(byte))]
        public EliteFrameInfoAll[] Frames;
    }

    [AeroBlock]
    public struct EliteFrameInfoAll
    {
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId_1; // Might just be that the data is indexed by this or something
        
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId_2;

        public uint EliteRank;
        public uint EliteXP;
        public uint ElitePoints;

        [AeroArray(typeof(byte))]
        public EliteAvailableUpgradeInfo[] AvailableUpgrades;

        [AeroArray(typeof(byte))]
        public ElitePreviousUpgradeInfo[] PreviousUpgrades;
    }
}