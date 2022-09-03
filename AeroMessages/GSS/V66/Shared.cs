using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66
{
    [AeroBlock]
    public struct HostilityInfoData
    {
        public enum HostilityMode: byte
        {
            None = 0,
            PvE = 1, // Id is Faction Id
            PvP = 2, // Id is Team Id
        }
        public HostilityMode Mode;

        [AeroIf(nameof(Mode), Ops.NotEqual, HostilityMode.None)]
        public byte Id; // Faction/Team Id
    }

    [AeroBlock]
    public struct PersonalFactionStanceData
    {
        // TODO: Verify
        [AeroArray(20)]
        public byte[] Unk;
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

        [AeroArray(29)]
        public byte[] UnkData;
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
        // Don't know how this works but its used everywhere so keeping it in a struct
        [AeroArray(8)]
        public byte[] Unk;
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
}