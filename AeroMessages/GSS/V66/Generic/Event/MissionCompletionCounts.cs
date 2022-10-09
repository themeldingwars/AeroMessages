using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 83)]
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