using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Turret.Controller
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 39, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 39, 4)]
    public partial class BaseController
    {
        [AeroSdb("dbcharacter::Turret", "id")]
        private uint Type;
        private EntityId ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        private byte ParentChildIndex; // Only observed 0x00
        private EntityId GunnerId;
        private SpawnPoseData SpawnPose;
        private uint ProcessDelay;
        private WeaponFireBaseTimeData WeaponFireBaseTime;
        private AmmoData Ammo;
        private float FireRateModifier;
        private HostilityInfoData HostilityInfo;
        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;
        private uint ScalingLevel;
    }

    [AeroBlock]
    public struct SpawnPoseData
    {
        public Quaternion Rotation; // Assumption
        public uint Time; // Assumption
    }

    [AeroBlock]
    public struct AmmoData
    {
        [AeroArray(typeof(byte))] public ushort[] Ammo;
    }
}