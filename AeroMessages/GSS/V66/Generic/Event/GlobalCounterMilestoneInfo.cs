using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 117)]
    public partial class GlobalCounterMilestoneInfo
    {
        [AeroArray(typeof(byte))] public GCMilestoneInfo1[] Unk1;
        [AeroArray(typeof(byte))] public GCMilestoneInfo2[] Unk2;
    }

    [AeroBlock]
    public struct GCMilestoneInfo1
    {
        [AeroString] public string Unk1;
        [AeroArray(typeof(byte))] public GCMilestoneInfo1Inner1[] Unk2;
    }

    [AeroBlock]
    public struct GCMilestoneInfo1Inner1
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        public float Unk3; // unsure type
    }

    [AeroBlock]
    public struct GCMilestoneInfo2
    {
        [AeroString] public string Unk1;
        public int Unk2;
    }
}