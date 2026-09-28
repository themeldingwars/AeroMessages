using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.GlobalCounterMilestoneInfo, GssVersion.V1, GssVersion.V74)]
    public partial class GlobalCounterMilestoneInfo
    {
        [AeroArray(typeof(byte))] public GCMilestoneInfo1[] LeaderboardMilestones;
        [AeroArray(typeof(byte))] public GCMilestoneInfo2[] LeaderboardIndices;
    }

    [AeroBlock]
    public struct GCMilestoneInfo1
    {
        [AeroString] public string LeaderboardName;
        [AeroArray(typeof(byte))] public GCMilestoneInfo1Inner1[] Milestones;
    }

    [AeroBlock]
    public struct GCMilestoneInfo1Inner1
    {
        public ulong Milestone;
        [AeroString] public string Message;
        public uint AchievedAt;
    }

    [AeroBlock]
    public struct GCMilestoneInfo2
    {
        [AeroString] public string LeaderboardName;
        public int Index;
    }
}