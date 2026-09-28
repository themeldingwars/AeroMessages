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
        public EntityId Player;
        public byte Team;
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId;
        public byte PvPRank;
        public byte CharacterState; // CharacterStateData.CharacterStatus
        public sbyte IsSquaded;
        public byte Unk6;
    }
}