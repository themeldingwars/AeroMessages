using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Melding
{
    [AeroBlock]
    public struct Outpost_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            OutpostName            = 0x00,
            Position               = 0x01,
            LevelBandId            = 0x02,
            SinUnlockIndex         = 0x03,
            TeleportCost           = 0x04,
            Dynamic_00             = 0x05,
            Dynamic_01             = 0x06,
            Dynamic_02             = 0x07,
            Dynamic_03             = 0x08,
            Dynamic_04             = 0x09,
            Dynamic_05             = 0x0a,
            Dynamic_06             = 0x0b,
            Dynamic_07             = 0x0c,
            Dynamic_08             = 0x0d,
            Dynamic_09             = 0x0e,
            Dynamic_10             = 0x0f,
            Dynamic_11             = 0x10,
            NearbyResourceItems_0  = 0x11,
            NearbyResourceItems_1  = 0x12,
            NearbyResourceItems_2  = 0x13,
            NearbyResourceItems_3  = 0x14,
            NearbyResourceItems_4  = 0x15,
            NearbyResourceItems_5  = 0x16,
            NearbyResourceItems_6  = 0x17,
            NearbyResourceItems_7  = 0x18,
            NearbyResourceItems_8  = 0x19,
            NearbyResourceItems_9  = 0x1a,
            NearbyResourceItems_10 = 0x1b,
            NearbyResourceItems_11 = 0x1c,
            NearbyResourceItems_12 = 0x1d,
            NearbyResourceItems_13 = 0x1e,
            NearbyResourceItems_14 = 0x1f,
            NearbyResourceItems_15 = 0x20,
            EncounterId            = 0x21,
            ScopeBubbleInfo        = 0x22,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.OutpostName)]
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint OutpostName;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LevelBandId)]
        [AeroSdb("dbitems::LevelBand", "id")]
        public uint LevelBandId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinUnlockIndex)]
        public byte SinUnlockIndex;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TeleportCost)]
        public int TeleportCost;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_00)]
        public float Progress; // Dynamic_00
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_01)]
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId; // Dynamic_01
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_01)]
        public byte Team; // Dynamic_02
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_02)]
        public byte UnderAttack; // Dynamic_03
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_03)]
        public byte OutpostType; // Dynamic_04
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_04)]
        public uint PossibleBuffsId; // Dynamic_05
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_05)]
        public byte PowerLevel; // Dynamic_06
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_06)]
        public ushort MWCurrent; // Dynamic_07
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_07)]
        public ushort MWMax; // Dynamic_08
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_08)]
        public uint MapMarkerTypeId; // Dynamic_09
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_09)]
        public float Radius; // Dynamic_10
        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_10)]

        [AeroIf(nameof(Idx), ShadowFieldIndex.Dynamic_11)]
        [AeroArray(4)]
        public byte[] Dynamic_11;

        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_0)]
        public uint NearbyResourceItems_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_1)]
        public uint NearbyResourceItems_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_2)]
        public uint NearbyResourceItems_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_3)]
        public uint NearbyResourceItems_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_4)]
        public uint NearbyResourceItems_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_5)]
        public uint NearbyResourceItems_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_6)]
        public uint NearbyResourceItems_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_7)]
        public uint NearbyResourceItems_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_8)]
        public uint NearbyResourceItems_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_9)]
        public uint NearbyResourceItems_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_10)]
        public uint NearbyResourceItems_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_11)]
        public uint NearbyResourceItems_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_12)]
        public uint NearbyResourceItems_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_13)]
        public uint NearbyResourceItems_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_14)]
        public uint NearbyResourceItems_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NearbyResourceItems_15)]
        public uint NearbyResourceItems_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EncounterId)]
        public EntityId EncounterId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;

    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 45, 1)]
    public partial class Outpost_ObserverView_Update
    {
        [AeroArray(-70)]
        public Outpost_ObserverView_ShadowFieldUpdate[] Updates;
    }
}