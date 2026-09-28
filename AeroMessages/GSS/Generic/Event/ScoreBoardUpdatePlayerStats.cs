using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardUpdatePlayerStats, GssVersion.V1, GssVersion.V74)]
    public partial class ScoreBoardUpdatePlayerStats
    {
        public EntityId Player;

        // Read_CombatLog (0x009f3f50), similar to PublicCombatLog. The client throws unless Version is 1
        public int Version;
        [AeroIf(nameof(Version), 1)]
        [AeroBlob(typeof(ushort))]
        public byte[] Data;
        /*
        byte a (enum) (!= 0)
        byte b (enum) (!= 0) [0x01 - 0x3d] determines format, lots of structs
        (b == 1)
            uint32
            byte (enum)
            byte (enum)
            uint32
        (b == 2)
            uint32
            uint16
        (b == [3,4,5,6,9,10,0xe,0x13,0x14,0x15,0x16,0x17,0x1d,0x25,0x26,0x30])
            uint32
        ...
        */
    }
}