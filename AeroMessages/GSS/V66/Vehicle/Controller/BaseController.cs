using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Vehicle.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 27, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 27, 4)]
    public partial class BaseController
    {
        [AeroSdb("vcs::VehicleInfo", "id")]
        private ushort VehicleId;
        private ConfigurationData Configuration;

        [AeroArray(4)]
        private byte[] Flags;

        private byte EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        private byte PathState;
        private EntityId OwnerId;

        [AeroString]
        private string OwnerName;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        private uint OwnerLocalString;

        private EntityId OccupantIds_0;
        private EntityId OccupantIds_1;
        private EntityId OccupantIds_2;
        private EntityId OccupantIds_3;
        private EntityId OccupantIds_4;
        private EntityId OccupantIds_5;
        private DeployableIdsData DeployableIds_0;
        private DeployableIdsData DeployableIds_1;
        private DeployableIdsData DeployableIds_2;
        private DeployableIdsData DeployableIds_3;
        private DeployableIdsData DeployableIds_4;
        private DeployableIdsData DeployableIds_5;
        private DeployableIdsData DeployableIds_6;
        private DeployableIdsData DeployableIds_7;
        private DeployableIdsData DeployableIds_8;
        private DeployableIdsData DeployableIds_9;
        private byte SnapMount;
        private SpawnPoseData SpawnPose;
        private Vector3 SpawnVelocity;
        private CurrentPoseData CurrentPose;
        private ProcessDelayData ProcessDelay;
        private HostilityInfoData HostilityInfo;
        
        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private uint CurrentHealth;
        private uint MaxHealth;
        private uint CurrentShields;
        private uint MaxShields;
        private uint CurrentResources;
        private uint MaxResources;
        private byte WaterLevelAndDesc;
        private byte SinFlags;
        private byte SinFlagsPrivate;

        [AeroNullable] private SinFactionsAcquiredByData SinFactionsAcquiredBy;
        [AeroNullable] private SinTeamsAcquiredByData SinTeamsAcquiredBy;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        private uint SinCardType;
        
        [AeroNullable] private SinCardFieldData SinCardFields_0;
        [AeroNullable] private SinCardFieldData SinCardFields_1;
        [AeroNullable] private SinCardFieldData SinCardFields_2;
        [AeroNullable] private SinCardFieldData SinCardFields_3;
        [AeroNullable] private SinCardFieldData SinCardFields_4;
        [AeroNullable] private SinCardFieldData SinCardFields_5;
        [AeroNullable] private SinCardFieldData SinCardFields_6;
        [AeroNullable] private SinCardFieldData SinCardFields_7;
        [AeroNullable] private SinCardFieldData SinCardFields_8;
        [AeroNullable] private SinCardFieldData SinCardFields_9;
        [AeroNullable] private SinCardFieldData SinCardFields_10;
        [AeroNullable] private SinCardFieldData SinCardFields_11;
        [AeroNullable] private SinCardFieldData SinCardFields_12;
        [AeroNullable] private SinCardFieldData SinCardFields_13;
        [AeroNullable] private SinCardFieldData SinCardFields_14;
        [AeroNullable] private SinCardFieldData SinCardFields_15;
        [AeroNullable] private SinCardFieldData SinCardFields_16;
        [AeroNullable] private SinCardFieldData SinCardFields_17;
        [AeroNullable] private SinCardFieldData SinCardFields_18;
        [AeroNullable] private SinCardFieldData SinCardFields_19;
        [AeroNullable] private SinCardFieldData SinCardFields_20;
        [AeroNullable] private SinCardFieldData SinCardFields_21;
        [AeroNullable] private SinCardFieldData SinCardFields_22;

        private ScopeBubbleInfoData ScopeBubbleInfo;
        private uint ScalingLevel;
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