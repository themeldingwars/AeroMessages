using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66
{
    [AeroBlock]
    public struct HostilityInfoData
    {
        [Flags]
        public enum HostilityFlags : byte
        {
            Faction = 1 << 0,
            Team = 1 << 1,
            Unk2 = 1 << 2,
            Unk3 = 1 << 3,
            Unk4 = 1 << 4,
        }
        public HostilityFlags Flags;

        [AeroIf(nameof(Flags), Ops.HasFlag, HostilityFlags.Faction)]
        public byte FactionId;

        [AeroIf(nameof(Flags), Ops.HasFlag, HostilityFlags.Team)]
        public byte TeamId;

        [AeroIf(nameof(Flags), Ops.HasFlag, HostilityFlags.Unk2)]
        public ushort Unk2;

        [AeroIf(nameof(Flags), Ops.HasFlag, HostilityFlags.Unk3)]
        public ushort Unk3;

        [AeroIf(nameof(Flags), Ops.HasFlag, HostilityFlags.Unk4)]
        public byte Unk4;
    }

    [AeroBlock]
    public struct PersonalFactionStanceData
    {   
        public PersonalFactionStanceBitfield Unk1;
        public PersonalFactionStanceBitfield Unk2;
    }

    [AeroBlock]
    public struct PersonalFactionStanceBitfield
    {
        public ushort NumFactions; // 50
        public uint NumBytes => (((uint)NumFactions >> 6) + 1) << 3; // 8
        [AeroArray(nameof(NumBytes))] public byte[] Bitfield; // 1 bit per faction, 8 bytes per 64 factions
    }

    [AeroBlock]
    public struct SinFactionsAcquiredByData
    {
        [AeroArray(typeof(byte))]
        public byte[] Factions;
    }

    [AeroBlock]
    public struct SinTeamsAcquiredByData
    {
        [AeroArray(typeof(byte))]
        public byte[] Factions;
    }

    [AeroBlock]
    public struct SinCardFieldData
    {
        public enum SincardFieldDataType : byte
        {
            LocalizationId = 0,
            Float = 1,
            EntityId = 2,
            Guid = 3,
            EnumByte = 4,
            // 5 goto the delete
            Short = 6,
            Complicated = 7, // Timer?
        }

        [Flags]
        public enum ComplicatedDataFlags : byte
        {
            Long = 2,
        }

        public SinCardFieldData.SincardFieldDataType Type;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.LocalizationId)]
        public uint LocalizationId;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Float)]
        public float Float;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.EntityId)]
        public EntityId EntityId;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.EnumByte)]
        public byte EnumByte;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Short)]
        public ushort Short;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Complicated)]
        public ComplicatedDataFlags Value7Flag;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Complicated)]
        [AeroIf(nameof(Value7Flag), Ops.DoesntHaveFlag, SinCardFieldData.ComplicatedDataFlags.Long)]
        public ulong Value7Long;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Complicated)]
        [AeroIf(nameof(Value7Flag), Ops.HasFlag, SinCardFieldData.ComplicatedDataFlags.Long)]
        public float Value7Float;
    }

    [AeroBlock]
    public struct StatusEffectData
    {
        [AeroSdb("apt::StatusEffectData", "id")]
        public uint Id;

        public byte Unk;
        public EntityId Initiator;
        public uint Time;
        public byte MoreDataFlag;

        [AeroIf(nameof(MoreDataFlag), 1)]
        public StatusEffectMoreData MoreData;   
    }

    [AeroBlock]
    public struct StatusEffectMoreData
    {
        [AeroArray(typeof(byte))]
        public EntityId[] Entities;

        public byte Unk1;
        public Vector3 Unk2;
        public Vector3 Unk3;
        public int Unk4;
        public float Float1;
        public float Float2;
    }

    [AeroBlock]
    public struct CharacterStatsData
    {
        [AeroArray(typeof(ushort))]
        public StatsData[] ItemAttributes;
        public uint Unk1;

        [AeroArray(typeof(ushort))]
        public StatsData[] WeaponA;
        public uint Unk2;

        [AeroArray(typeof(ushort))]
        public StatsData[] WeaponB;
        public uint Unk3;

        [AeroArray(typeof(ushort))]
        public StatsData[] AttributeCategories1;

        [AeroArray(typeof(ushort))]
        public StatsData[] AttributeCategories2;
    }

    [AeroBlock]
    public struct StatsData
    {
        [AeroSdb("dbitems::AttributeDefinition", "id")]
        public ushort Id;

        public float Value;
    }

    [AeroBlock]
    public struct ScopeBubbleInfoData
    {
        public uint Layer;
        public uint Unk2;
    }

    [AeroBlock]
    public struct TinyObjectData
    {
        [AeroSdb("dbcharacter::TinyObject", "id")]
        public ushort TypeId;
        public Vector3 Position;
        public HostilityInfoData HostilityInfo;
    }

    [AeroBlock]
    public struct AppendageHealthPoolData
    {
        public uint Unk1; // Health or a chain id?
        public uint Unk2;
        [AeroString] public string Hardpoint;
        public byte Unk4;
        public byte Unk5;
        public byte Unk6;
    }

    [AeroBlock]
    public struct ForcedMovementData
    {
        public byte Type;
        public uint Unk1;

        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)]
        public ulong Unk2;

        [AeroIf(nameof(Type), 0x01)]
        public ForcedMovementType1Params Params1;

        [AeroIf(nameof(Type), 0x02)]
        public ForcedMovementType2Params Params2;

        [AeroIf(nameof(Type), 0x03)]
        public ForcedMovementType3Params Params3;

        [AeroIf(nameof(Type), 0x04)]
        public ForcedMovementType4Params Params4;

        [AeroIf(nameof(Type), 0x05)]
        public ForcedMovementType5Params Params5;

        [AeroIf(nameof(Type), 0x06)]
        public ForcedMovementType6Params Params6;

        [AeroIf(nameof(Type), 0x07)]
        public ForcedMovementType7Params Params7;

        [AeroIf(nameof(Type), 0x08)]
        public ForcedMovementType8Params Params8;

        [AeroIf(nameof(Type), 0x09)]
        public ForcedMovementType9Params Params9;

        [AeroIf(nameof(Type), 0x0a)]
        public ForcedMovementType10Params Params10;

        [AeroIf(nameof(Type), 0x0b)]
        public ForcedMovementType11Params Params11;

        [AeroIf(nameof(Type), 0x0c)]
        public ForcedMovementType12Params Params12;

        [AeroIf(nameof(Type), 0x0d)]
        public ForcedMovementType13Params Params13;
    }

    [AeroBlock]
    public struct ForcedMovementType1Params
    {
        public Vector3 Position;
        public Vector3 Direction;
        public Vector3 Velocity;
        public uint Time;
    }

    [AeroBlock]
    public struct ForcedMovementType2Params
    {
        public Vector3 Unk1;
        public Vector3 Unk2;
        public uint Time1;
        public uint Time2;
        public float Unk5;
        public byte Unk6;
        public byte Unk7;
    }

    [AeroBlock]
    public struct ForcedMovementType3Params
    {
        public uint Time1;
        public uint Time2;
        public Vector3 Unk3;
        public Quaternion Unk4;
        public Vector3 Unk5;
        public Quaternion Unk6;
        public float Unk7;
        public float Unk8;
        public byte Unk9;
        public byte Unk10;
    }

    [AeroBlock]
    public struct ForcedMovementType4Params
    {
        public Vector3 Unk1;
        public uint Time1;
        public uint Time2;
        public float Unk4;
        public Vector3 Unk5;
    }

    [AeroBlock]
    public struct ForcedMovementType5Params
    {
        public Vector3 Velocity; // Bit of an assumption
        public uint Time1;
        public uint Time2;
        public byte Unk2;
    }

    [AeroBlock]
    public struct ForcedMovementType6Params
    {
        public Vector3 Unk1;
        public uint Time1;
        public uint Time2;
        public float Extra;
    }

    [AeroBlock]
    public struct ForcedMovementType8Params
    {
        public Vector3 Unk1;
        public uint Time1;
        public uint Time2;
        public float Extra;
    }

    [AeroBlock]
    public struct ForcedMovementType9Params
    {
        public uint Time1;
        public uint Time2;
        public float Unk1;
        public Vector3 Unk2;
    }

    [AeroBlock]
    public struct ForcedMovementType10Params
    {
        public uint Time1;
        public uint Time2;
        public Vector3 Unk1;
        public float Unk2;
        public float Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct ForcedMovementType11Params
    {
        public uint Time1;
        public uint Time2;
        public Vector3 Unk1;
        public Quaternion Unk2;
    }

    [AeroBlock]
    public struct ForcedMovementType12Params
    {
        public Vector3 Unk1;
        public uint Time1;
        public uint Time2;
    }

    [AeroBlock]
    public struct ForcedMovementType7Params
    {
        public uint Time1;
        public uint Time2;
    }

    [AeroBlock]
    public struct ForcedMovementType13Params
    {
        public uint Time1;
        public uint Time2;
        public ulong Unk1;
        public Vector3 Unk2;
        public float Unk3;
        public float Unk4;
        public float Unk5;
        public float Unk6;
        public byte Unk7;
        public float Unk8;
        public float Unk9;
    }

    [AeroBlock]
    public struct GenericKeyVariablePair
    {
        // FUN_016f6360
        [AeroString] public string Key;
        public VariableType Value;
    }

    [AeroBlock]
    public struct VariableType
    {
        // FUN_016f55c0
        public uint TypeSelector;

        [AeroIf(nameof(TypeSelector), 1)]
        [AeroString] public string Value1;

        [AeroIf(nameof(TypeSelector), 2)]
        public sbyte Value2;

        [AeroIf(nameof(TypeSelector), 3)]
        public short Value3;

        [AeroIf(nameof(TypeSelector), 4)]
        public int Value4;

        [AeroIf(nameof(TypeSelector), 5)]
        public long Value5;

        [AeroIf(nameof(TypeSelector), 6)]
        public byte Value6;

        [AeroIf(nameof(TypeSelector), 7)]
        public ushort Value7;

        [AeroIf(nameof(TypeSelector), 8)]
        public uint Value8;

        [AeroIf(nameof(TypeSelector), 9)]
        public ulong Value9;

        [AeroIf(nameof(TypeSelector), 10)]
        public ushort Value10; // Half or Quantised Float?

        [AeroIf(nameof(TypeSelector), 0xb)]
        public float Value11;

        [AeroIf(nameof(TypeSelector), 0xc)]
        public double Value12; // Assumption

        [AeroIf(nameof(TypeSelector), 0xd)]
        public byte Value13;

        [AeroIf(nameof(TypeSelector), 0xe)]
        public EntityId Value14; // GUID

        // Tempt the devil and you shall face the wrath of six thousand errors
        /*
        [AeroIf(nameof(TypeSelector), 0xf)]
        [AeroArray(typeof(int))] public GenericKeyVariablePair[] Value15; // Double Inception

        [AeroIf(nameof(TypeSelector), 0x10)]
        [AeroArray(typeof(byte))] public VariableType[] Value16; // Regular Inception
        */
    }

    [Flags]
    public enum DamageResponseFlags : byte
    {
        Critical  = 1 << 0,
        Unk       = 1 << 1,
        Effective = 1 << 2,
        Resisted  = 1 << 3,
        Immune    = 12, // (Effective+Resisted => Immune)
    }

    [AeroBlock]
    public struct DamageHitStruct
    {
        public EntityId Target;

        public byte HaveDealer;
        [AeroIf(nameof(HaveDealer), 1)]
        public EntityId Dealer;

        public int DamageValue;

        [AeroSdb("dbcharacter::DamageType", "id")]
        public byte DamageType;
    }

    // Shared between vehicle and character
    public enum CurrentPoseUpdateFlags: byte
    {
        ShortTime = 0x00,
        MovementState = 0x02,
        Position = 0x0c,
        Rotation = 0x30,
        Aim = 0xc0,
    }

    [AeroBlock]
    public struct CurrentPoseUpdateData
    {
        public CurrentPoseUpdateFlags Flags;

        public byte CalcFlagValue1 => ((byte)(Flags & CurrentPoseUpdateFlags.Rotation));
        public byte CalcFlagValue2 => ((byte)(Flags & CurrentPoseUpdateFlags.Aim));

        // ShortTime
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.ShortTime)]
        public ushort ShortTime;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.ShortTime)]
        public byte ShortTimeAlt;

        // Unknown byte
        public byte UnkAlwaysPresent;

        // Movement State
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.MovementState)]
        public ushort MovementState;

        // Position
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.Position)]
        public Vector3 Position;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.Position)]
        [AeroArray(3)]
        public byte[] PositionAlt;

        // Rotation
        [AeroIf(nameof(CalcFlagValue1), 0x00)]
        public QuantisedQuaternion Rotation;

        [AeroIf(nameof(CalcFlagValue1), 0x10)]
        public byte RotAltLastByte_1; // Same byte, just difficulties with logic

        [AeroIf(nameof(CalcFlagValue1), 0x20)]
        [AeroArray(2)] public byte[] RotAltBytes;

        [AeroIf(nameof(CalcFlagValue1), 0x20)]
        public byte RotAltLastByte_2; // Same byte, just difficulties with logic

        // Aim
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.Aim)]
        public QuantisedVector3 Aim;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.Aim)]
        [AeroIf(nameof(CalcFlagValue2), Ops.NotEqual, (byte) CurrentPoseUpdateFlags.Aim)]
        [AeroArray(3)]
        public byte[] AimAlt;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitData
    {
        public enum DebugTraceType : byte
        {
            ERROR = 0,
            Spawn = 1,
            Bounce = 2,
            Posefile_Hit = 3,
            Ragdoll_Hit = 4,
            Ragdoll_Miss = 5,
            Impact = 6,
            Shot = 7,
            Detonate = 8,
            Timeout = 9,
            Validated = 10,
        }
        public DebugTraceType TraceType;
        public uint Unk2_TraceId;
        public uint Time;
        public ushort Unk4;
        public Vector3 Position;
        public Vector3 Direction; // Not normalized
        public uint Unk7_Id;
        
        public byte HaveUnk8;
        [AeroIf(nameof(HaveUnk8), 1)] public TookDebugWeaponHitRelatedData Unk8;

        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9), 1)] public TookDebugWeaponHitRelatedData2 Unk9;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData
    {
        public EntityId Target;
        public Vector3 Unk2;
        public Quaternion Unk3;
        public sbyte Unk4;
        public byte Unk5;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData2
    {
        // 009f6bb0
        public EntityId Target;

        // 009f6020
        [AeroArray(typeof(byte))] public DbgMatrix4x4[] Unk2;
    }

    [AeroBlock]
    public struct DbgMatrix4x4
    {
        [AeroArray(4)] public Vector4[] Row;
    }

    [AeroBlock]
    public struct WeaponFireBaseTimeData
    {
        public ushort ChangeTime;
        public byte Unk;
    }

    [AeroBlock]
    public struct ProcessDelayData
    {
        public ushort Unk1; // Unknown type
        public ushort Unk2; // Unknown type
    }

    [AeroBlock]
    public struct ResourceCompositionData
    {
        public uint ItemTypeId;
        public ushort ResourceQuality;
        public float Percent;   
    }

    [AeroBlock]
    public struct ChatMessageAlternateData
    {
        public enum ChatMessageAlternateType : byte
        {
            NONE = 0,
            ChatDuelResult = 1,
            ChatVendingMachineWinnerInfo = 2,
            ChatUnlockedAchievement = 3,
            SquadInviteForward = 4,
            PlayerStateDetails = 5,
            RequestPlayerStateDetails = 6,
            PlayerDisconnected = 7,
            PlayerTransferring = 8,
            GroupPreferences = 9,
            GroupWaypoint = 10,
            SquadMatchQueue = 11,
            SquadQueueIneligibility = 12,
            SquadRequestInvite = 13,
            GeoReportAdded = 14,
            GeoReportRemoved = 15,
            QuickChatMessage = 16,
            LootCollected = 17,
            JoinLeaderHint = 18,
            FriendRequestOrRemove = 19,
        }
        public ChatMessageAlternateType AlternateType;

        public byte HaveAltData;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatDuelResult)]
        public ChatAltData_ChatDuelResult AltData_ChatDuelResult;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatVendingMachineWinnerInfo)]
        public ChatAltData_ChatVendingMachineWinnerInfo AltData_ChatVendingMachineWinnerInfo;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatUnlockedAchievement)]
        public ChatAltData_ChatUnlockedAchievement AltData_ChatUnlockedAchievement;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadInviteForward)]
        public ChatAltData_SquadInviteForward AltData_SquadInviteForward;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerStateDetails)]
        public ChatAltData_PlayerStateDetails AltData_PlayerStateDetails;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.RequestPlayerStateDetails)]
        public ChatAltData_RequestPlayerStateDetails AltData_RequestPlayerStateDetails;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerDisconnected)]
        public ChatAltData_PlayerDisconnected AltData_PlayerDisconnected;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerTransferring)]
        public ChatAltData_PlayerTransferring AltData_PlayerTransferring;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GroupPreferences)]
        public ChatAltData_GroupPreferences AltData_GroupPreferences;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GroupWaypoint)]
        public ChatAltData_GroupWaypoint AltData_GroupWaypoint;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadMatchQueue)]
        public ChatAltData_SquadMatchQueue AltData_SquadMatchQueue;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadQueueIneligibility)]
        public ChatAltData_SquadQueueIneligibility AltData_SquadQueueIneligibility;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadRequestInvite)]
        public ChatAltData_SquadRequestInvite AltData_SquadRequestInvite;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GeoReportAdded)]
        public ChatAltData_GeoReportAdded AltData_GeoReportAdded;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GeoReportRemoved)]
        public ChatAltData_GeoReportRemoved AltData_GeoReportRemoved;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.QuickChatMessage)]
        public ChatAltData_QuickChatMessage AltData_QuickChatMessage;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.LootCollected)]
        public ChatAltData_LootCollected AltData_LootCollected;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.JoinLeaderHint)]
        public ChatAltData_JoinLeaderHint AltData_JoinLeaderHint;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.FriendRequestOrRemove)]
        public ChatAltData_FriendRequestOrRemove AltData_FriendRequestOrRemove;
    }

    [AeroBlock]
    public struct ChatAltData_ChatDuelResult
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string CDR_Unk1;
        [AeroString] public string CDR_Unk2;
    }

    [AeroBlock]
    public struct ChatAltData_ChatVendingMachineWinnerInfo
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string CDR_PlayerName;
        public byte CDR_Gender;
        public uint CDR_ItemTypeId;
        public uint CDR_Quality;
    }

    [AeroBlock]
    public struct ChatAltData_ChatUnlockedAchievement
    {
        public ushort DataLength;

        // Guesswork
        public uint CUA_Unk1;
        [AeroString] public string CUA_Unk2;
        public byte CUA_Gender;
    }

    [AeroBlock]
    public struct ChatAltData_SquadInviteForward
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string SIF_Name; // Player?
    }

    [AeroBlock]
    public struct ChatAltData_PlayerStateDetails
    {
        public ushort DataLength;

        public byte Unk1; // Special read func, casted to uint?. 0 for DarkCisum, 1 for CrissKitty.
        public uint ChassisId;
        public byte Level;
        public byte EffectiveLevel;
        public uint EliteRank;
        public ulong InstanceId;
        public uint ZoneId;
        [AeroString] public string ServerHost;
        public uint PvPRank; // Bit of a guess

        public byte HaveUnk10;
        [AeroIf(nameof(HaveUnk10), 1)]
        public PSDData Unk10;

        public byte ChatIconFlags; // Again tho?
        public byte CharacterState;
        public uint MaxHealth;
        public ushort Unk14;
    }

    [AeroBlock]
    public struct PSDData
    {
        public ulong PSDD_Unk1;
        public uint  PSDD_Unk2;
        public byte  PSDD_Unk3;
        public byte  PSDD_Unk4;
    }

    [AeroBlock]
    public struct ChatAltData_RequestPlayerStateDetails
    {
        public ushort DataLength;
        // No additional data
        // Does something on squad and platoon channel, and something different on friends channel.
    }

    [AeroBlock]
    public struct ChatAltData_PlayerDisconnected
    {
        public ushort DataLength;
        [AeroArray(nameof(DataLength))] public byte[] Data;
        // Probably no additional data
        // Only does something on Friends channel
    }

    [AeroBlock]
    public struct ChatAltData_PlayerTransferring
    {
        public ushort DataLength;
        // No additional data
    }

    [AeroBlock]
    public struct ChatAltData_GroupPreferences
    {
        public ushort DataLength;

        public byte GP_Unk1;
        public byte GP_Unk2;
        public byte GP_Unk3;
        public byte GP_Unk4;
        public byte GP_Unk5;
        public byte GP_Unk6;
        public HalfFloat GP_Unk7;
        public byte GP_Unk8;
        [AeroArray(typeof(byte))] public EntityId[] Entities;
    }

    [AeroBlock]
    public struct ChatAltData_GroupWaypoint
    {
        public ushort DataLength;

        // Guesswork
        public byte HaveWaypoint;
        [AeroIf(nameof(HaveWaypoint), 1)]
        public GroupWaypoint_Data Waypoint;
    }

    [AeroBlock]
    public struct GroupWaypoint_Data
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
        public Vector3 Position;
    }

    [AeroBlock]
    public struct ChatAltData_SquadMatchQueue
    {
        public ushort DataLength;

        // Guesswork
        public ulong GroupId;
        [AeroString] public string SMQ_Unk1; // random zone group?
        [AeroString] public string SMQ_Unk2; // leader?
    }
    [AeroBlock]
    public struct ChatAltData_SquadQueueIneligibility
    {
        /*
        chatId
        entityId
         */
        public ushort DataLength;

        public byte DataCount; // Throws exception if 0?
        [AeroArray(nameof(DataCount))] public SQIData[] Data;
    }

    [AeroBlock]
    public struct SQIData
    {
        public uint QueueId;
        [AeroArray(typeof(byte))] public uint[] SQI_Unk2; // Unknown type
        [AeroArray(typeof(byte))] public int[] SQI_Unk3; // ReadArray_Int32_Weird
    }


    [AeroBlock]
    public struct ChatAltData_SquadRequestInvite
    {
        public ushort DataLength;

        // Possibly no additional data?
        [AeroArray(nameof(DataLength))] public byte[] Data;
    }

    [AeroBlock]
    public struct ChatAltData_GeoReportAdded
    {
        public ushort DataLength;

        // Guesswork
        public ulong GRA_Unk1;
        public uint GRA_Unk2; // Maybe same as GRR_Unk1? ScanId?
        public Vector3 GRA_Position;
        [AeroArray(typeof(byte))] public ResourceCompositionData[] Data;

    }

    [AeroBlock]
    public struct ChatAltData_GeoReportRemoved
    {
        public ushort DataLength;

        // Guesswork
        public uint GRR_Unk1; // Maybe same as GRA_Unk2? ScanId?
    }

    [AeroBlock]
    public struct ChatAltData_QuickChatMessage
    {
        public ushort DataLength;
        
        // Guesswork
        public uint QCM_Id;
    }

    [AeroBlock]
    public struct ChatAltData_LootCollected
    {
        public ushort DataLength;

        public uint ItemTypeId;
        [AeroString] public string LootedTo; // or lootedBy??
        public uint Quantity;
        public uint Boosted; // Assumption
        public uint Quality; // Assumption
        [AeroArray(typeof(byte))] public uint[] Modules; // Assumption
        public byte RewardType; // Assumption
    }

    [AeroBlock]
    public struct ChatAltData_JoinLeaderHint
    {
        public ushort DataLength;

        // Possibly no additional data?
        [AeroArray(nameof(DataLength))] public byte[] Data;
    }

    [AeroBlock]
    public struct ChatAltData_FriendRequestOrRemove
    {
        public ushort DataLength;

        // Guesswork
        public sbyte FROR_StatusType;
    }

    [AeroBlock]
    public struct ThumpingCharacterInfoStruct
    {
        public EntityId OwnerId1;
        public EntityId OwnerId2;
        [AeroString] public string Owner;
        public float Unk;
    }
}