using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardAddPlayer, GssVersion.V1, GssVersion.V74)]
    public partial class ScoreBoardAddPlayer
    {
        public EntityId Player;
        public ulong Unk2;
        [AeroString] public string Name;
        public float Unk4;
        public byte Team;
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId;
        public byte PvPRank;
        public byte CharacterState; // CharacterStateData.CharacterStatus
        public sbyte Unk9;
        public byte Unk10;
    }
}