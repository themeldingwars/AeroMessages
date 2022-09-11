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
        public uint Unk1; // Achievement Id?
        public byte Unk2; // Status?
    }
}