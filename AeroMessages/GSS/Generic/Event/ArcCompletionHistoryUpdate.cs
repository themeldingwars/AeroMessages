using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ArcCompletionHistoryUpdate, GssVersion.V1, GssVersion.V67)]
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
        public uint Unk2; // State related
        public uint Unk3; // State related
        public uint CompletionTimeEpoch;
    }
}