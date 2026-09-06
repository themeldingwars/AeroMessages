using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MissionCompletionCounts, GssVersion.V1, GssVersion.V74)]
    public partial class MissionCompletionCounts
    {
        [AeroArray(typeof(byte))] public MissionCompletionCountsData[] Data;
        [AeroString] public string Type;
    }

    [AeroBlock]
    public struct MissionCompletionCountsData
    {
        [AeroSdb("clientmissions:Mission", "id")]
        public uint MissionId;
        public ulong Count;
        public uint CompletionTimeEpoch;
    }
}