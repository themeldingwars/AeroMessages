using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 42)]
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