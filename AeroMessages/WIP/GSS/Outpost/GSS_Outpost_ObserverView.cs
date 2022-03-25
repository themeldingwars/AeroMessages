using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Outpost
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 45, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 45, 3)]
    public partial class Outpost_ObserverView
    {
        [AeroSdb("dblocalization::LocalizedText", "id")]
        private uint OutpostName;

        private Vector3 Position;

        [AeroSdb("dbitems::LevelBand", "id")]
        private uint LevelBandId;
        private byte SinUnlockIndex;
        private int TeleportCost;
        private float Progress; // Dynamic_00

        [AeroSdb("dbcharacter::Faction", "id")]
        private byte FactionId; // Dynamic_01
        private byte Team; // Dynamic_02
        private byte UnderAttack; // Dynamic_03
        private byte OutpostType; // Dynamic_04
        private uint PossibleBuffsId; // Dynamic_05
        private byte PowerLevel; // Dynamic_06
        private ushort MWCurrent; // Dynamic_07
        private ushort MWMax; // Dynamic_08
        private uint MapMarkerTypeId; // Dynamic_09
        private float Radius; // Dynamic_10

        [AeroArray(4)]
        private byte[] Dynamic_11;

        [AeroNullable] private uint NearbyResourceItems_0;
        [AeroNullable] private uint NearbyResourceItems_1;
        [AeroNullable] private uint NearbyResourceItems_2;
        [AeroNullable] private uint NearbyResourceItems_3;
        [AeroNullable] private uint NearbyResourceItems_4;
        [AeroNullable] private uint NearbyResourceItems_5;
        [AeroNullable] private uint NearbyResourceItems_6;
        [AeroNullable] private uint NearbyResourceItems_7;
        [AeroNullable] private uint NearbyResourceItems_8;
        [AeroNullable] private uint NearbyResourceItems_9;
        [AeroNullable] private uint NearbyResourceItems_10;
        [AeroNullable] private uint NearbyResourceItems_11;
        [AeroNullable] private uint NearbyResourceItems_12;
        [AeroNullable] private uint NearbyResourceItems_13;
        [AeroNullable] private uint NearbyResourceItems_14;
        [AeroNullable] private uint NearbyResourceItems_15;

        private EntityId EncounterId;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }
}