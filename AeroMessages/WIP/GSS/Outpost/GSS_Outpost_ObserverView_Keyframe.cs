using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Outpost
{
    [Aero]
    public partial class Outpost_ObserverView
    {
        public enum BitfieldMask : ushort
        {
            NearbyResourceItems_0  = 1UL << 0,
            NearbyResourceItems_1  = 1UL << 1,
            NearbyResourceItems_2  = 1UL << 2,
            NearbyResourceItems_3  = 1UL << 3,
            NearbyResourceItems_4  = 1UL << 4,
            NearbyResourceItems_5  = 1UL << 5,
            NearbyResourceItems_6  = 1UL << 6,
            NearbyResourceItems_7  = 1UL << 7,
            NearbyResourceItems_8  = 1UL << 8,
            NearbyResourceItems_9  = 1UL << 9,
            NearbyResourceItems_10 = 1UL << 10,
            NearbyResourceItems_11 = 1UL << 11,
            NearbyResourceItems_12 = 1UL << 12,
            NearbyResourceItems_13 = 1UL << 13,
            NearbyResourceItems_14 = 1UL << 14,
            NearbyResourceItems_15 = 1UL << 15,
        }

        public ushort Bitfield;

        //[AeroSDB("dblocalization::LocalizedText", "id")]
        public uint OutpostName;

        public Vector3 Position;

        //[AeroSDB("dbitems::LevelBand", "id")]
        public uint LevelBandId;
        public byte SinUnlockIndex;
        public int TeleportCost;
        public float Progress; // Dynamic_00

        //[AeroSDB("dbcharacter::Faction", "id")]
        public byte FactionId; // Dynamic_01
        public byte Team; // Dynamic_02
        public byte UnderAttack; // Dynamic_03
        public byte OutpostType; // Dynamic_04
        public uint PossibleBuffsId; // Dynamic_05
        public byte PowerLevel; // Dynamic_06
        public ushort MWCurrent; // Dynamic_07
        public ushort MWMax; // Dynamic_08
        public uint MapMarkerTypeId; // Dynamic_09
        public float Radius; // Dynamic_10

        [AeroArray(4)]
        public byte[] Dynamic_11;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_0)]
        public uint NearbyResourceItems_0;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_1)]
        public uint NearbyResourceItems_1;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_2)]
        public uint NearbyResourceItems_2;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_3)]
        public uint NearbyResourceItems_3;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_4)]
        public uint NearbyResourceItems_4;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_5)]
        public uint NearbyResourceItems_5;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_6)]
        public uint NearbyResourceItems_6;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_7)]
        public uint NearbyResourceItems_7;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_8)]
        public uint NearbyResourceItems_8;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_9)]
        public uint NearbyResourceItems_9;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_10)]
        public uint NearbyResourceItems_10;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_11)]
        public uint NearbyResourceItems_11;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_12)]
        public uint NearbyResourceItems_12;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_13)]
        public uint NearbyResourceItems_13;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_14)]
        public uint NearbyResourceItems_14;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.NearbyResourceItems_15)]
        public uint NearbyResourceItems_15;

        public EntityId EncounterId;
        public ScopeBubbleInfoData ScopeBubbleInfo;
    }
}