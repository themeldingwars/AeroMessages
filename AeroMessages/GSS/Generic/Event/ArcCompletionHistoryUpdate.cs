using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ArcCompletionHistoryUpdate, GssVersion.V1, GssVersion.V74)]
    public partial class ArcCompletionHistoryUpdate
    {
        [AeroArray(typeof(byte))]
        public ArcBlock[] Data;
    }

    [AeroBlock]
    public struct ArcBlock
    {
        [AeroSdb("dbencounterdata::Arcs", "id")]
        public uint ArcId;
        public uint AttemptCount; // Every start of the arc, also the ones that were stopped without completing it
        public uint CompletionCount;
        public uint CompletionTimeEpoch;
    }
}