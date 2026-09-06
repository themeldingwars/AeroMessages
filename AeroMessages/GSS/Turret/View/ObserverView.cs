using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using Aero.Gen;

namespace AeroMessages.GSS.Turret.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssTurretView.ObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class ObserverView
    {
        [AeroSdb("dbcharacter::Turret", "id")]
        private uint Type;

        private EntityId ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.

        private byte ParentChildIndex; // Only observed 0x00

        private EntityId GunnerId;

        private CurrentPoseStruct CurrentPose;

        private ProcessDelayData ProcessDelay;

        private uint WeaponBurstFired;

        private uint WeaponBurstEnded;

        private AmmoStruct Ammo;

        private float FireRateModifier;

        private HostilityInfoData HostilityInfo;

        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;
    }

    [AeroBlock]
    public struct CurrentPoseStruct
    {
        public ushort ShortTime;

        public QuantisedQuaternion Rotation; // Assumption
    }

    [AeroBlock]
    public struct AmmoStruct
    {
        [AeroArray(typeof(byte))]
        public ushort[] AmmoIndex; // Limited examples, could be wrong
    }
}