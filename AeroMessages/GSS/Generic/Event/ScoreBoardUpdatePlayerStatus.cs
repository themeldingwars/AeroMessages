using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardUpdatePlayerStatus, GssVersion.V1, GssVersion.V74)]
    public partial class ScoreBoardUpdatePlayerStatus
    {
        public EntityId Player; // Assumption
        public byte Unk1;
        public uint ChassisId;
        public byte Unk3;
        public byte Unk4; // Alt read
        public sbyte Unk5;
        public byte Unk6;
    }
}