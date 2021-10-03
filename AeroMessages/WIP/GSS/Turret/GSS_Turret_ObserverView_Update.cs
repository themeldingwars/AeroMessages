using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Turret
{
    [AeroBlock]
    public struct Turret_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Type                  = 0x00,
            ParentObjId           = 0x01,
            ParentChildIndex      = 0x02,
            GunnerId              = 0x03,
            CurrentPose           = 0x04,
            ProcessDelay          = 0x05,
            WeaponBurstFired      = 0x06,
            WeaponBurstEnded      = 0x07,
            Ammo                  = 0x08,
            FireRateModifier      = 0x09,
            HostilityInfo         = 0x0a,
            PersonalFactionStance = 0x0b,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Type)]
        [AeroSdb("dbcharacter::Turret", "id")]
        public uint Type;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParentObjId)]
        public EntityId ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParentChildIndex)]
        public byte ParentChildIndex; // Only observed 0x00
        [AeroIf(nameof(Idx), ShadowFieldIndex.GunnerId)]
        public EntityId GunnerId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentPose)]
        public CurrentPoseStruct CurrentPose;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ProcessDelay)]
        public uint ProcessDelay;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponBurstFired)]
        public uint WeaponBurstFired;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponBurstEnded)]
        public uint WeaponBurstEnded;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Ammo)]
        public AmmoStruct Ammo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FireRateModifier)]
        public float FireRateModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 1)]
    public partial class Turret_ObserverView_Update
    {
        [AeroArray(-22)]
        public Turret_ObserverView_ShadowFieldUpdate[] Updates;
    }
}