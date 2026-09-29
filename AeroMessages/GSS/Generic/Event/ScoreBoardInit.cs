using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardInit, GssVersion.V1, GssVersion.V74)]
    public partial class ScoreBoardInit
    {
        [AeroArray(typeof(byte))] public ScoreBoardInitData[] Players;
        public sbyte Unk2;
        public sbyte Unk3;
        public byte Unk4;
        public sbyte UseArmyTeams; // publish each row's team -> ArmyId mapping
        [AeroString] public string Unk6;
    }

    [AeroBlock]
    public struct ScoreBoardInitData
    {
        public EntityId Player;
        public ulong ArmyId;
        [AeroString] public string Name;
        public float Unk4;
        public byte Team;
        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId;
        public byte PvPRank;
        public byte CharacterState; // CharacterStateData.CharacterStatus
        public sbyte IsSquaded;
        public byte Unk10;
        public ScoreBoardData1 Stats;
        [AeroArray(typeof(byte))] public ScoreBoardData3[] EncounterStats;
        public uint Unk13;
        public sbyte Unk14;
        [AeroArray(typeof(byte))] public ScoreBoardData1[] Unk15; // 00c53610
    }

    [AeroBlock]
    public struct ScoreBoardData1
    {
        // 00c52e90
        // Index i is the dbstats::Stat id ScoreBoardStatIds[i] (table 0x01bb23b0): 10007, 10009, 10107, 10033, 10037, 10025, 10026, 10045, 10174,
        // 10158, 10175, 10170, 10153, 10154, 10067, 10075, 10080, 10079
        [AeroArray(18)] public uint[] StatValues;
        [AeroArray(typeof(byte))] public ScoreBoardData2[] Unk2;
        public uint Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct ScoreBoardData2
    {
        // 00c52d00
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
    }

    [AeroBlock]
    public struct ScoreBoardData3
    {
        // 00c52520
        [AeroSdb("dbcharacter::XPRewardType", "id")]
        public int XpRewardTypeId;
        public int Count;
        public int Xp;
    }
}