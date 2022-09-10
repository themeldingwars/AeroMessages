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
        public PFSData Unk1;
        public PFSData Unk2;
    }

    [AeroBlock]
    public struct PFSData
    {
        public ushort Header;
        public uint Length => (((uint)Header >> 6) + 1) << 3;
        [AeroArray(nameof(Length))] public byte[] Data;
    }

    [AeroBlock]
    public struct SinFactionsAcquiredByData
    {
        [AeroArray(2)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct SinTeamsAcquiredByData
    {
        [AeroArray(2)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct SinCardFieldData
    {
        public enum SincardFieldDataType : byte
        {
            // TODO: Verify
            LocalizationId = 0,
            Integer = 1,
            EntityId = 2,
            UnkType_3 = 3,
            Enum = 4,
            UnkType_5 = 5,
            Short = 6,
            Timer = 7, // ? Maybe entity?
            Boolean = 8,
        }

        public SinCardFieldData.SincardFieldDataType Type;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.LocalizationId)]
        public uint LocalizationId;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Integer)]
        public uint Integer;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.EntityId)]
        public EntityId EntityId;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Enum)]
        [AeroString]
        public string Enum;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Short)]
        public ushort Short;

        [AeroIf(nameof(Type), SinCardFieldData.SincardFieldDataType.Timer)]
        [AeroArray(9)]
        public byte[] Timer;
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

        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(typeof(ushort))]
        public StatsData[] WeaponA;

        [AeroArray(4)]
        public byte[] Unk2;

        [AeroArray(typeof(ushort))]
        public StatsData[] WeaponB;

        [AeroArray(4)]
        public byte[] Unk3;

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
        public uint Unk1;
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

        [AeroArray(8)]
        public byte[] Unk2;
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
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
        public ushort Unk4;
        public Vector3 Unk5;
        public Vector3 Unk6;
        public uint Unk7;
        
        public byte HaveUnk8;
        [AeroIf(nameof(HaveUnk8), 1)] public TookDebugWeaponHitRelatedData Unk8;

        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9), 1)] public TookDebugWeaponHitRelatedData2 Unk9;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData
    {
        public ulong Unk1;
        public Vector3 Unk2;
        public Quaternion Unk3;
        public sbyte Unk4;
        public byte Unk5;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData2
    {
        // FUN_009f6bb0
        public ulong Unk1;

        // 009f6020
        [AeroArray(typeof(byte))] public MaybeMatrix[] Unk2;
    }

    [AeroBlock]
    public struct MaybeMatrix
    {
        // 00a093e0
        [AeroArray(4)] uint[] Unk;
    }

    [AeroBlock]
    public struct WeaponFireBaseTimeData
    {
        public ushort ChangeTime; // Not 100% about this one
        public byte Unk; // Not 100% about this one
    }
}