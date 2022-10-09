using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 86)]
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