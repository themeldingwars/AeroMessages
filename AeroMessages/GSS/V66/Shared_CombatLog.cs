using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66
{
    [AeroBlock]
    public struct CombatLogMessage
    {
        public ushort Bytes;
        [AeroArray(-24)] public CombatLogRow[] Entries;
    }

    [AeroBlock]
    public struct CombatLogRow
    {
        /*
        Older:
        PlayerTraumatizedEvent
        RewardLevelUpEvent
         */
        public enum CombatLogType : byte
        {
            Type1 = 1, // Ability related
            Type2 = 2,
            Type3 = 3,
            Type4 = 4,
            Type5 = 5, // Ability related?
            Type6 = 6, // Ability related?
            Type7 = 7, // Damage/Hit related
            TakeDamageEvent = 8, // Damage/Hit related
            AbilityActivatedEvent = 9,
            Type10 = 10,
            StatusFxAppliedEvent = 11,
            StatusFxRemovedEvent = 12,
            Type13 = 13,
            Type14 = 14,
            Type15 = 15, // Ability related?
            Type16 = 16,
            Type17 = 17,
            Type18 = 18, // PvpStats?
            Type19 = 19,
            Type20 = 20,
            Type21 = 21,
            Type22 = 22,
            Type23 = 23,
            PlayerDownedEvent = 24,
            PlayerKilledEvent = 25,
            PlayerRevivedEvent = 26,
            Type27 = 27,
            PlayerExecutedEvent = 28,
            PlayerRespawnedEvent = 29,
            Type30 = 30,
            Type31 = 31,
            Type32 = 32,
            Type33 = 33,
            RewardEvent = 34,
            Type35 = 35,
            Type36 = 36,
            Type37 = 37,
            Type38 = 38,
            Type39 = 39,
            Type40 = 40,
            Type41 = 41,
            Type42 = 42,
            Type43 = 43,
            Type44 = 44,
            Type45 = 45,
            Type46 = 46,
            Type47 = 47,
            Type48 = 48,
            Type49 = 49,
            Type50 = 50,
            Type51 = 51,
            Type52 = 52,
            Type53 = 53,
            Type54 = 54,
            Type55 = 55,
            Type56 = 56,
            Type57 = 57,
            Type58 = 58,
            Type59 = 59,
            Type60 = 60,
            Type61 = 61,
        };

        public enum CombatSourceType : byte
        {
            None = 0,
            Weapon = 1,
            Projectile = 2,
            Ability = 3,
            AbilitySystem = 4,

            // There are four that are StatusFx
            // Presumably this is due to apply_chain, remove_chain, update_chain, duration_chain.
            // Did not put in a lot of effort to backtrace it yet
            StatusFx_Duration = 5, // Guesswork
            StatusFx_Apply = 6, // Solid - gameplay2016:537 shows 3372 is applied via 6, found four impactapplyeffect and all are in apply_chain.
            StatusFx_Update = 7, // Guesswork
            StatusFx_Remove = 8 // Sketchy - gameplay2016:537 shows 8984 is applied via 8, one impactapplyeffect and it is in a remove_chain.
        };


        public CombatSourceType SourceType;
        public CombatLogType LogType;

        [AeroIf(nameof(LogType), CombatLogType.Type1)]
        public CombatLogType1Data Type1Data;

        [AeroIf(nameof(LogType), CombatLogType.Type2)]
        public CombatLogType2Data Type2Data;

        [AeroIf(nameof(LogType), CombatLogType.Type3)]
        public uint Type3Data;
        [AeroIf(nameof(LogType), CombatLogType.Type4)]
        public uint Type4Data;
        [AeroIf(nameof(LogType), CombatLogType.Type5)]
        public uint Type5Data; // Maybe Weapontype?
        [AeroIf(nameof(LogType), CombatLogType.Type6)]
        public uint Type6Data_AbilityId;
        [AeroIf(nameof(LogType), CombatLogType.Type10)]
        public uint Type10Data;
        [AeroIf(nameof(LogType), CombatLogType.Type14)]
        public uint Type14Data;
        [AeroIf(nameof(LogType), CombatLogType.Type19)]
        public uint Type19Data;
        [AeroIf(nameof(LogType), CombatLogType.Type20)]
        public uint Type20Data;
        [AeroIf(nameof(LogType), CombatLogType.Type21)]
        public uint Type21Data;
        [AeroIf(nameof(LogType), CombatLogType.Type22)]
        public uint Type22Data;
        [AeroIf(nameof(LogType), CombatLogType.Type23)]
        public uint Type23Data;
        [AeroIf(nameof(LogType), CombatLogType.Type37)]
        public uint Type37Data;
        [AeroIf(nameof(LogType), CombatLogType.Type38)]
        public uint Type38Data;
        [AeroIf(nameof(LogType), CombatLogType.Type48)]
        public uint Type48Data;

        [AeroIf(nameof(LogType), CombatLogType.Type7)]
        public CombatLogType7Data Type7Data;

        [AeroIf(nameof(LogType), CombatLogType.TakeDamageEvent)]
        public CombatLogType8Data Type8Data;

        [AeroIf(nameof(LogType), CombatLogType.AbilityActivatedEvent)]
        public CombatLogType9Data Type9Data;

        [AeroIf(nameof(LogType), CombatLogType.StatusFxAppliedEvent)]
        public CombatLogType11Data Type11Data;

        [AeroIf(nameof(LogType), CombatLogType.StatusFxRemovedEvent)]
        public CombatLogType12Data Type12Data;

        /*
        [AeroIf(nameof(LogType), CombatLogType.Type13)]
        [AeroIf(nameof(LogType), CombatLogType.Type16)]
        [AeroIf(nameof(LogType), CombatLogType.Type17)]
        [AeroIf(nameof(LogType), CombatLogType.Type18)]
        [AeroIf(nameof(LogType), CombatLogType.Type27)]
        [AeroIf(nameof(LogType), CombatLogType.Type40)]
        [AeroIf(nameof(LogType), CombatLogType.Type41)]
        [AeroIf(nameof(LogType), CombatLogType.Type42)]
        [AeroIf(nameof(LogType), CombatLogType.Type43)]
        [AeroIf(nameof(LogType), CombatLogType.Type44)]
        [AeroIf(nameof(LogType), CombatLogType.Type50)]
        [AeroIf(nameof(LogType), CombatLogType.Type52)]
        // NO OP?
        */

        [AeroIf(nameof(LogType), CombatLogType.Type15)]
        public CombatLogType15Data Type15Data;

        [AeroIf(nameof(LogType), CombatLogType.PlayerDownedEvent)]
        public CombatLogType24Data Type24Data;

        [AeroIf(nameof(LogType), CombatLogType.PlayerKilledEvent)]
        public CombatLogType25Data Type25Data;

        [AeroIf(nameof(LogType), CombatLogType.PlayerRevivedEvent)]
        public CombatLogType26Data Type26Data;

        [AeroIf(nameof(LogType), CombatLogType.PlayerExecutedEvent)]
        public CombatLogType28Data Type28Data;

        [AeroIf(nameof(LogType), CombatLogType.PlayerRespawnedEvent)]
        public CombatLogType29Data Type29Data;

        [AeroIf(nameof(LogType), CombatLogType.Type30)]
        public CombatLogType30Data Type30Data;

        [AeroIf(nameof(LogType), CombatLogType.Type31)]
        public CombatLogType31Data Type31Data;

        [AeroIf(nameof(LogType), CombatLogType.Type32)]
        public CombatLogType32Data Type32Data;

        [AeroIf(nameof(LogType), CombatLogType.Type33)]
        public CombatLogType33Data Type33Data;

        [AeroIf(nameof(LogType), CombatLogType.RewardEvent)]
        public CombatLogType34Data Type34Data;

        [AeroIf(nameof(LogType), CombatLogType.Type35)]
        public CombatLogType35Data Type35Data;

        [AeroIf(nameof(LogType), CombatLogType.Type36)]
        public CombatLogType36Data Type36Data;

        [AeroIf(nameof(LogType), CombatLogType.Type39)]
        public CombatLogType39Data Type39Data;

        [AeroIf(nameof(LogType), CombatLogType.Type44)]
        public CombatLogType44Data Type44Data;

        [AeroIf(nameof(LogType), CombatLogType.Type47)]
        public CombatLogType47Data Type47Data;

        [AeroIf(nameof(LogType), CombatLogType.Type49)]
        public CombatLogType49Data Type49Data;

        [AeroIf(nameof(LogType), CombatLogType.Type51)]
        public int Type51Data;

        [AeroIf(nameof(LogType), CombatLogType.Type53)]
        public CombatLogType53Data Type53Data;

        [AeroIf(nameof(LogType), CombatLogType.Type54)]
        public CombatLogType54Data Type54Data;

        [AeroIf(nameof(LogType), CombatLogType.Type55)]
        public CombatLogType55Data Type55Data;

        [AeroIf(nameof(LogType), CombatLogType.Type56)]
        public CombatLogType56Data Type56Data;

        [AeroIf(nameof(LogType), CombatLogType.Type57)]
        public CombatLogType57Data Type57Data;

        [AeroIf(nameof(LogType), CombatLogType.Type58)]
        public CombatLogType58Data Type58Data;

        [AeroIf(nameof(LogType), CombatLogType.Type59)]
        public CombatLogType59Data Type59Data;

        [AeroIf(nameof(LogType), CombatLogType.Type60)]
        public CombatLogType60Data Type60Data;

        [AeroIf(nameof(LogType), CombatLogType.Type61)]
        public CombatLogType61Data Type61Data;
    }

    [AeroBlock]
    public struct CombatLogType1Data
    {
        public uint T1_Unk1; // Maybe Weapontype?
        public byte T1_Unk2;
        public byte T1_Unk3;
        public uint T1_Time;
    }

    [AeroBlock]
    public struct CombatLogType2Data
    {
        public uint T2_Unk1;
        public ushort T2_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType7Data
    {
        public uint T7_Unk1;
        public int T7_Damage;
    }

    [AeroBlock]
    public struct CombatLogType8Data // TakeDamageEvent
    {
        public uint T8_SourceSubTypeId;
        public ulong T8_Attacker;
        public int T8_dHealth;
        public int T8_dShields;
        public uint T8_Time;
    }

    [AeroBlock]
    public struct CombatLogType9Data
    {
        public uint T9_AbilityId;
    }


    [AeroBlock]
    public struct CombatLogType11Data // StatusEffectApplied
    {
        public uint T11_StatusEffectId;
        public uint T11_Time;
    }

    [AeroBlock]
    public struct CombatLogType12Data
    {
        public uint T12_StatusEffectId;
        public uint T12_Time;
    }

    [AeroBlock]
    public struct CombatLogType15Data
    {
        public uint T15_Unk1; // Maybe Weapontype?
        public int T15_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType24Data // PlayerDownedEvent
    {
        public uint T24_SourceSubTypeId;
        public ulong T24_AttackerId;
        public ulong T24_InflictorId;
        public sbyte T24_Headshot;
        public uint T24_FrameId;
        public byte T24_FrameLevel;
        public uint T24_AttackerSdbId;
    }

    [AeroBlock]
    public struct CombatLogType25Data // PlayerKilledEvent
    {
        public uint T25_SourceSubTypeId;
        public ulong T25_AttackerId;
        public ulong T25_InflictorId;
        public uint T25_FrameId;
        public byte T25_FrameLevel;
        public uint T25_AttackerSdbId;
    }

    [AeroBlock]
    public struct CombatLogType26Data // Revived
    {
        public ulong T26_ReviverId;
        public uint T26_FrameId;
    }

    [AeroBlock]
    public struct CombatLogType28Data // Executed
    {
        public ulong T28_ExecutionerId;
        public uint T28_FrameId;
    }

    [AeroBlock]
    public struct CombatLogType29Data
    {
        public uint T29_ChassisId;
    }

    [AeroBlock]
    public struct CombatLogType30Data
    {
        public uint T30_Unk1;
        public ulong T30_Unk2;
        public Vector3 T30_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType31Data
    {
        public uint T31_Unk1;
        public ulong T31_Unk2;
        public Vector3 T31_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType32Data
    {
        public uint T32_Unk1;
        public ulong T32_Unk2;
        public uint T32_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType33Data
    {
        public uint T33_Unk1;
        public ulong T33_Unk2;
        public uint T33_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType34Data
    {
        public int T34_XpGain;
        public int T34_XpUnmodifiedGain;
        public uint T34_XpRewardType;
        public uint T34_ChassisId;
        public byte T34_Level; // Assumption?
        public byte T34_FrameLevel;
        public byte T34_Unk7;
        public ulong T34_Entity;
        public uint T34_SourceMonsterId; // CharacterTypeId
        public byte T34_SourceIsNPC;
    }

    [AeroBlock]
    public struct CombatLogType35Data
    {
        public uint T35_Unk1;
        public byte T35_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType36Data
    {
        public uint T36_Unk1;
        public int T36_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType39Data
    {
        public uint T39_Unk1; // chassis ids
        public uint T39_Unk2; // chassis ids
        public byte T39_Unk3;
        public byte T39_Unk4;
        public uint T39_Unk5;
        public uint T39_Unk6;
    }

    [AeroBlock]
    public struct CombatLogType44Data
    {
        public byte T44_Unk1;
        [AeroArray(typeof(ushort))] public byte[] T44_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType47Data
    {
        public uint T47_ChassisId;
        public byte T47_Level;
        public uint T47_Unk3; // Xp?
        public sbyte T47_Unk4;
        public uint T47_Unk5; // Granted xp?
        public uint T47_Unk6;
        [AeroString] public string T47_Unk7; // "NONE"
        [AeroString] public string T47_Unk8;
    }

    [AeroBlock]
    public struct CombatLogType49Data
    {
        public uint T49_Unk1;
        [AeroArray(typeof(byte))] public CombatLogIntPair[] T49_Unk2;
        public byte T49_Unk3;
    }

    [AeroBlock]
    public struct CombatLogIntPair
    {
        public int Pair1;
        public int Pair2;
    }

    [AeroBlock]
    public struct CombatLogType53Data
    {
        public uint T53_Unk1;
        [AeroArray(typeof(byte))] public CombatLogType53DataInner[] T53_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType53DataInner
    {
        public uint T53I_Unk1;
        public uint T53I_Unk2;
        public uint T53I_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType54Data
    {
       public uint T54_Unk1;
       public uint T54_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType55Data
    {
       public uint T55_Unk1;
       public uint T55_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType56Data
    {
        public ulong T56_Unk1;
        public uint T56_Unk2;
        public uint T56_Unk3;
    }

    [AeroBlock]
    public struct CombatLogType57Data
    {
       public ulong T57_Unk1;
       public uint T57_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType58Data
    {
       public ulong T58_Unk1;
       public uint T58_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType59Data
    {
       public ulong T59_Unk1;
       public uint T59_Unk2;
       public uint T59_Unk3;
       public byte T59_Unk4;
    }

    [AeroBlock]
    public struct CombatLogType60Data
    {
       public ulong T60_Unk1;
       public uint T60_Unk2;
    }

    [AeroBlock]
    public struct CombatLogType61Data
    {
       // omegalol
       public uint T61_Unk1;
       public uint T61_Unk2;
       public uint T61_Unk3;
       public Vector3 T61_Unk4; // or 3 floats :D
       public uint T61_Unk5;
       public uint T61_Unk6;
       public uint T61_Unk7;
       public uint T61_Unk8;
       public uint T61_Unk9;
       public uint T61_Unk10;
       public uint T61_Unk11;
       public uint T61_Unk12;
       public uint T61_Unk13;
       public uint T61_Unk14;
       public uint T61_Unk15;
       public uint T61_Unk16;
       public uint T61_Unk17;
       public uint T61_Unk18;
       public float T61_Unk19;
    }
}