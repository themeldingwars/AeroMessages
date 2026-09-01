using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardUpdatePlayerStatsFromStats, GssVersion.V1, GssVersion.V67)]
    public partial class ScoreBoardUpdatePlayerStatsFromStat
    {
        public EntityId Player;

        // This looks scuffed, might be repeated
        public MaybeArrayReadStats Stats;
    }

    [AeroBlock]
    public struct MaybeArrayReadStats
    {
        [AeroSdb("dbstats::Stat", "Id")]
        public uint StatEventId;

        [AeroArray(typeof(uint))]
        public GenericKeyVariablePair[] Stats;
    }
}