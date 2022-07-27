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
}