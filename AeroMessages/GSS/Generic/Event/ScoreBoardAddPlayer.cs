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
        public ulong ArmyId; // published per team while ScoreBoardInit.UseArmyTeams is set
        [AeroString] public string Name;
        public float Unk4;
        public byte Team;
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId;
        public byte PvPRank;
        public byte CharacterState; // CharacterStateData.CharacterStatus
        public sbyte IsSquaded;
        public byte Unk10;
    }
}