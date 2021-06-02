/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 27
    TypeName: Vehicle::BaseController
    MsgId: 4
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_BaseController_Keyframe
    {
        [Flags]
        public enum BitfieldMask: uint
        {
            PersonalFactionStance = 1U << 0,
            SinFactionsAcquiredBy = 1U << 1,
            SinTeamsAcquiredBy    = 1U << 2,
            SinCardFields_0       = 1U << 3,
            SinCardFields_1       = 1U << 4,
            SinCardFields_2       = 1U << 5,
            SinCardFields_3       = 1U << 6,
            SinCardFields_4       = 1U << 7,
            SinCardFields_5       = 1U << 8,
            SinCardFields_6       = 1U << 9,
            SinCardFields_7       = 1U << 10,
            SinCardFields_8       = 1U << 11,
            SinCardFields_9       = 1U << 12,
            SinCardFields_10      = 1U << 13,
            SinCardFields_11      = 1U << 14,
            SinCardFields_12      = 1U << 15,
            SinCardFields_13      = 1U << 16,
            SinCardFields_14      = 1U << 17,
            SinCardFields_15      = 1U << 18,
            SinCardFields_16      = 1U << 19,
            SinCardFields_17      = 1U << 20,
            SinCardFields_18      = 1U << 21,
            SinCardFields_19      = 1U << 22,
            SinCardFields_20      = 1U << 23,
            SinCardFields_21      = 1U << 24,
            SinCardFields_22      = 1U << 25,
        }

        public ulong PlayerId;

        public BitfieldMask Bitfield;

        [AeroSdb("vcs::VehicleInfo", "id")]
        public ushort VehicleID;

        [AeroArray(32)]
        public byte[] Configuration;

        [AeroArray(4)]
        public byte[] Flags;

        public byte EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        public byte PathState;
        public EntityId OwnerId;

        [AeroString]
        public string OwnerName;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint OwnerLocalString;

        public EntityId OccupantIds_0;
        public EntityId OccupantIds_1;
        public EntityId OccupantIds_2;
        public EntityId OccupantIds_3;
        public EntityId OccupantIds_4;
        public EntityId OccupantIds_5;

        [AeroArray(13)]
        public byte[] DeployableIds_0;
        [AeroArray(13)]
        public byte[] DeployableIds_1;
        [AeroArray(13)]
        public byte[] DeployableIds_2;
        [AeroArray(13)]
        public byte[] DeployableIds_3;
        [AeroArray(13)]
        public byte[] DeployableIds_4;
        [AeroArray(13)]
        public byte[] DeployableIds_5;
        [AeroArray(13)]
        public byte[] DeployableIds_6;
        [AeroArray(13)]
        public byte[] DeployableIds_7;
        [AeroArray(13)]
        public byte[] DeployableIds_8;
        [AeroArray(13)]
        public byte[] DeployableIds_9;

        public byte SnapMount;

        public SpawnPoseData SpawnPose;
        public Vector3 SpawnVelocity;
        public CurrentPoseData CurrentPose;



        public uint ProcessDelay;
        public HostilityInfoData HostilityInfo;
        
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;

        public uint CurrentHealth;
        public uint MaxHealth;
        public uint CurrentShields;
        public uint MaxShields;
        public uint CurrentResources;
        public uint MaxResources;
        public byte WaterLevelAndDesc;
        public byte SinFlags;
        public byte SinFlagsPrivate;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;
        
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;

        public ScopeBubbleInfoData ScopeBubbleInfo;
        public uint ScalingLevel;
    }

    [AeroBlock]
    public struct SpawnPoseData
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public uint Time;
    }
}