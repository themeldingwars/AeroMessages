using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.V66.Character
{
    [AeroBlock]
    public struct EliteAvailableUpgradeInfo
    {
        public uint UpgradeId; // TODO: Pinpoint sdb table
        public uint Unk_1;
        public uint StatValue; // Not float?

        [AeroArray(typeof(byte))]
        public uint[] AdditionalInfo;
        //public uint? Count; // first additional info entry
        //public uint? ItemSDBId; // second additional info entry
        // ... more potentially

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint LocalizationId;
    }

    [AeroBlock]
    public struct ElitePreviousUpgradeInfo
    {
        public uint UpgradeId; // TODO: Pinpoint sdb table
        public uint Count;
    }

    [AeroBlock]
    public struct FireModeData
    {
        public byte Mode;
        public uint Time;
    }

    [AeroBlock]
    public struct WeaponIndexData
    {
        public byte Index;
        [AeroArray(2)]
        public byte[] Unk;
        public uint Time;
    }

    [AeroBlock]
    public struct StaticInfoData
    {
        [AeroString]
        public string DisplayName;

        [AeroString]
        public string UniqueName;

        public byte Gender;
        public byte Race;

        [AeroSdb("dbcharacter::CharInfo", "id")]
        public uint CharInfoId;

        [AeroSdb("dbcharacter::Head", "id")]
        public uint HeadMain;

        [AeroSdb("dbvisualrecords::EyeRecord", "id")]
        public uint Eyes;

        public byte Unk_1;
        public byte IsNPC;
        public byte StaffFlags; // ChatIconFlags might be a better name?

        [AeroSdb("dbcharacter::Monster", "id")]
        public uint CharacterTypeId;

        [AeroSdb("dbcharacter::VoiceSet", "id")]
        public uint VoiceSet;

        [AeroSdb("dbcharacter::MonsterTitle", "id")]
        public ushort TitleId;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint NameLocalizationId;

        [AeroArray(typeof(byte))]
        [AeroSdb("dbcharacter::HeadAccesory", "ha_id")] // TODO: Double check
        public uint[] HeadAccessories;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LoadoutVehicle;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LoadoutGlider;

        public VisualsBlock Visuals;

        [AeroString]
        public string ArmyTag;
    }

    [AeroBlock]
    public struct VisualsBlock
    {
        [AeroArray(typeof(byte))]
        public VisualsDecalsBlock[] Decals;

        [AeroArray(typeof(byte))]
        public uint[] Gradients;

        [AeroArray(typeof(byte))]
        public uint[] Colors;

        [AeroArray(typeof(byte))]
        public VisualsPaletteBlock[] Palettes;

        [AeroArray(typeof(byte))]
        public VisualsPatternBlock[] Patterns;

        [AeroArray(typeof(byte))]
        public uint[] OrnamentGroupIds;

        [AeroArray(typeof(byte))]
        public uint[] CziMapAssetIds; // First/Lowest byte is not part of the AssetId

        [AeroArray(typeof(byte))]
        public HalfFloat[] MorphWeights;

        [AeroArray(typeof(byte))]
        public VisualsOverlayBlock[] Overlays;
    }

    [AeroBlock]
    public struct VisualsDecalsBlock
    {
        [AeroSdb("dbvisualrecords::TatooDecal", "id")] // TODO: Verify
        public uint DecalId;
        public uint Color;

        [AeroArray(3)]
        public HalfVector4[] Transform; // TODO: Verify

        public byte Usage;
    }

    [AeroBlock]
    public struct VisualsPaletteBlock
    {
        public byte PaletteType;

        [AeroSdb("dbvisualrecords::WarpaintPalette", "id")]
        public uint PaletteId;
    }

    [AeroBlock]
    public struct VisualsPatternBlock
    {
        [AeroSdb("dbvisualrecords::CziPattern", "id")]
        public uint PatternId;
        public HalfVector4 TransformValues; // TODO: Verify, Scale?
        public byte Usage; // 0, 1, 2, 3 permitted
    }

    [AeroBlock]
    public struct VisualsOverlayBlock
    {
        [AeroSdb("dbvisualrecords::OverlayRecord", "id")]
        public ushort OverlayId;

        [AeroString(3)]
        public string Color1;

        [AeroString(3)]
        public string Color2;

        public byte Opacity;
    }


    [AeroBlock]
    public struct EquipmentData
    {
        // Chassis
        public SlottedItem Chassis; // Battleframe

        // Backpack
        public SlottedItem Backpack; // Reactor

        // Primary
        public SlottedWeapon PrimaryWeapon; // SlotIdx 0

        // Secondary
        public SlottedWeapon SecondaryWeapon; // SlotIdx 1

        public uint EndUnk1;
        public byte EndUnk2;
    }

    [Flags]
    public enum SlottedItemFlags : byte
    {
        HaveMoreData    = 1 << 1,
    }

    [AeroBlock]
    public struct SlottedItem
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;
        public byte SlotIndex;
        public SlottedItemFlags Flags;
        public byte Unk2;

        [AeroIf(nameof(Flags), Ops.HasFlag, SlottedItemFlags.HaveMoreData)]
        public SlottedItemUnkData UnkData;

        [AeroArray(typeof(byte))]
        public SlottedModule[] Modules;

        public VisualsBlock Visuals;
    }

    [AeroBlock]
    public struct SlottedWeapon
    {
        public SlottedItem Item;
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct SlottedModule
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;
        public byte SlotIndex;
        public SlottedItemFlags Flags; // Apply Lsh 8
        public byte Unk2;

        [AeroIf(nameof(Flags), Ops.HasFlag, SlottedItemFlags.HaveMoreData)] // Use 0x200 as the flag
        public SlottedItemUnkData UnkData;
    }

    [AeroBlock]
    public struct SlottedItemUnkData
    {
        public ulong Unk1;
        [AeroArray(typeof(byte))] public SlottedItemUnk2x4[] Unk2;
        public ushort Unk3;
        public ushort Unk4;
        public uint Unk5;
        public byte Unk6;
        public uint Unk7;
        [AeroArray(typeof(byte))] public uint[] Unk8;
        public byte Unk9;
    }

    [AeroBlock]
    public struct SlottedItemUnk2x4
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct GibVisuals
    {
        [AeroSdb("dbcharacter::GibVisuals", "id")]
        public uint Id;
        public uint Time;
    }

    [AeroBlock]
    public struct CharacterStateData
    {
        public enum CharacterStatus : byte
        {
            Spawning = 0,
            Ghost = 1,
            Dead = 2,
            Respawning = 3,
            Incapacitated = 4,
            Traumatized = 5,
            Living = 6
        }

        public CharacterStatus State;
        public uint Time;
    }

    [AeroBlock]
    public struct MaxVital
    {
        public uint Value;
        public uint Time;
    }

    [AeroBlock]
    public struct EmoteData {
        [AeroSdb("dbcharacter::EmoteRecord", "id")]
        public ushort Id;
        public uint Time;
    }

    [AeroBlock]
    public struct AttachedToData
    {
        public enum AttachmentRoleType : byte
        {
            None = 0,
            Driver = 1,
            ActivePassenger = 3,
            PassivePassenger = 4,
            Turret = 5,
        }

        public EntityId Id1;
        public EntityId Id2;
        public AttachmentRoleType Role;

        [AeroArray(2)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct LookAtTargetData
    {
        // TODO: Verify
        public EntityId Target;
        public Vector3 Position;
        public uint Time; // TODO: Seems like this is a float too?
    }

    [AeroBlock]
    public struct RespawnTimesData
    {
        public uint ForcedAt;
        public uint AvailableAt;
    }

    [AeroBlock]
    public struct CombatFlagsData
    {
        [Flags]
        public enum CharacterCombatFlags : uint
        {
            restrict_movement    = 1 << 0,
            unk_2                = 1 << 1,
            restrict_camera      = 1 << 2,
            unk_8                = 1 << 3,
            restrict_weapon      = 1 << 4,
            remove_hitboxes      = 1 << 5, // Client projectile visuals pass through when this is set, so figure its the hitboxes. Other players can walk through us, but we cant walk through them.
            restrict_abilities   = 1 << 6,
            unk_128              = 1 << 7,
            immune_falldamage    = 1 << 8, // You do not go into falling state when this is on, thus your character does not do the heavy landing.
            restrict_sprint      = 1 << 9,
            restrict_melee       = 1 << 10,
            restrict_interaction = 1 << 11,
            knock_down           = 1 << 12,
            restrict_stumble     = 1 << 13,
            move_through_objects = 1 << 14, // You can run through other characters. They can't run through you. Other objects are still solid.
            reversed_controls    = 1 << 15,
        }

        public CharacterCombatFlags Value;
        public uint Time;
    }
    
    [Flags]
    public enum MovementDataType : byte
    {
        Velocity  = 0,
        PosRotState = 1,
        Aim       = 2
    }

    [AeroBlock]
    public struct MovementPoseData
    {
        // FUN_009f04d0
        // Movement state
        public ushort           MovementUnk1;
        public MovementDataType MovementType;
        public byte             MovementUnk3;

        [AeroIf(nameof(MovementType), Ops.HasFlag, MovementDataType.PosRotState)]
        public MovementPosRotState PosRotState;

        public Vector3 Velocity;

        [AeroIf(nameof(MovementType), Ops.HasFlag, MovementDataType.Aim)]
        public Vector3 Aim;

        public ushort JetpackEnergy;
        public short GroundTimePositiveAirTimeNegative;
        public short TimeSinceLastJump;

        // Looks like 1 more byte should be read here and based on it a lot of more shit can happen
        //   FUN_00a00700
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)] // != 0
        public MovementPoseMoreData UnkData;
        //   --
        // --
    }

    [AeroBlock]
    public struct MovementPosRotState
    {
        public Vector3    Pos;
        public Quaternion Rot;
        public short      MovementState;
    }

    [AeroBlock]
    public struct MovementPoseMoreData
    {
        // FUN_00a00570
        public MovementPoseMoreDataGroup Unk1;
        public MovementPoseMoreDataGroup Unk2;
        public MovementPoseMoreDataGroup Unk3;
        public MovementPoseMoreDataGroup Unk4;
        public MovementPoseMoreDataGroup Unk5;
        public MovementPoseMoreDataGroup Unk6;
        public MovementPoseMoreDataGroup Unk7;
    }

    [AeroBlock]
    public struct MovementPoseMoreDataGroup
    {
        // Just making an assumption and trying to stay sane
        public ushort Unk1;
        public MovementPoseMoreData1 Unk2;
        public ushort Unk3;
        public MovementPoseMoreData2 Unk4;
    }

    [AeroBlock]
    public struct MovementPoseMoreData1
    {
        // FUN_00a08f70
        public Vector3 Unk1;
        public Quaternion Unk2;
        public Vector3 Unk3;
    }

    [AeroBlock]
    public struct MovementPoseMoreData2
    {
        // FUN_00a00360
        public byte HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public MovementPoseMoreData2Inner Data;
    }

    [AeroBlock]
    public struct MovementPoseMoreData2Inner
    {
        // FUN_00a00120
        public ushort Unk1;
        public Vector3 Unk2;
        public byte Unk3;
        public byte Unk4;
        public ushort Unk5;
        public short Unk6;
        public short Unk7;

        //  FUN_009ffed0
        public byte HaveUnk8;
        [AeroIf(nameof(HaveUnk8), 1)]
        public MovementPoseMoreData2InnerUnk8Data Unk8;
        // --
        public Vector3 Unk9;
        public Vector3 Unk10;
        public byte Unk11;
    }

    [AeroBlock]
    public struct MovementPoseMoreData2InnerUnk8Data
    {
        [AeroArray(typeof(byte))] MovementPoseMoreData2InnerUnk8Data1[] Unk1;
        [AeroArray(typeof(byte))] float[] Unk2; // Not certain that its floats
    }

    [AeroBlock]
    public struct MovementPoseMoreData2InnerUnk8Data1
    {
        // FUN_009ff520
        // 6x4, assuming two vectors
        public Vector3 Unk1;
        public Vector3 Unk2;
    }

    [AeroBlock]
    public struct CarryableObject
    {
        public EntityId Target;
        public uint TypeId;
    }

    [AeroBlock]
    public struct CinematicCameraData
    {
        // msgidx gameplay:840302
        [AeroArray(40)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct DockedParamsData
    {
        [AeroArray(21)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct MovementData
    {
        public Vector3    Position;
        public Quaternion Rotation;
        public Vector3    Aim;
        public ushort     MovementState;
        public uint       Time;
    }

    [AeroBlock]
    public struct LoadoutConfig_Visual
    {
        [Flags]
        public enum LoadoutVisualType : byte {
            Palette = 9,
            Pattern = 10,
            Decal = 11,

            Glider = 13,
            Vehicle = 14,
        };

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;

        public LoadoutVisualType VisualType;
        public uint Data1; // Pattern: 1 == Armor, 2 == Bodysuit 
        public uint Data2; // Color?

        [AeroArray(typeof(byte))]
        public float[] Transform;
    }

    [AeroBlock]
    public struct VisualOverridesField
    {
        [AeroArray(typeof(byte))]
        public VisualOverridesData[] Data;
    }

    [AeroBlock]
    public struct VisualOverridesData
    {
        public byte SlotType; // 0 Chassis, 11 Backpack?
        public uint VisualsGroupId;
    }

    [AeroBlock]
    public struct AssetOverridesField
    {
        [AeroArray(typeof(byte))]
        [AeroSdb("dbvisualrecords::AssetOverrideGroup", "id")]
        public uint[] Ids; 
    }

    [AeroBlock]
    public struct ChatPartyMember
    {
        public EntityId Id;
        [AeroString] public string Name;
        public byte State;
    }

    [AeroBlock]
    public struct AbilityCooldownsData
    {
        [AeroArray(typeof(uint))]
        public ActiveCooldown[] ActiveCooldowns_Group1; // Don't know the logic

        [AeroArray(typeof(uint))]
        public ActiveCooldown[] ActiveCooldowns_Group2; // Don't know the logic

        public uint GlobalCooldown_Activated_Time;
        public uint GlobalCooldown_ReadyAgain_Time;

        public byte Unk;
    }

    [AeroBlock]
    public struct ActiveCooldown
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;
        public uint Activated_Time;
        public uint ReadyAgain_Time;

        [AeroArray(5)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct DuelData
    {
        // FUN_009db930
        public byte Unk1;
        [AeroString] public string Unk2;
        public EntityId RequestingEntity;
        [AeroString] public string Unk3;
        public EntityId Unk4;
        [AeroString] public string TargetName;
        [AeroArray(typeof(byte))] public ulong[] Unk5;
        [AeroArray(typeof(byte))] public ulong[] Unk6;
        public ushort Unk7;
        public ushort Unk8;
        public uint Unk9;
        public byte Unk10;
        public ulong TargetEntity; // TODO: Verify this
        // --
    }
}