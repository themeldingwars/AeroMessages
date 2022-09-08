using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 41)]
    public partial class ScoreBoardUpdatePlayerStats
    {   
        public EntityId Player;

        // Simliar to PublicCombatLog
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}