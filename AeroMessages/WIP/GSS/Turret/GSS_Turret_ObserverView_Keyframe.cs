/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 40
    TypeName: Turret::ObserverView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Turret
{
    [Aero]
    public partial class Turret_ObserverView
    {
        [Flags]
        public enum BitfieldMask: byte
        {
            PersonalFactionStance = 1 << 0,
        }

        public BitfieldMask Bitfield;

        //[AeroSDB("dbcharacter::Turret", "id")]
        public uint Type; // SDB Table 197

        public EntityId ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        public byte ParentChildIndex; // Only observed 0x00
        public EntityId GunnerId;
        
        public CurrentPoseStruct CurrentPose;

        public uint ProcessDelay;
        public uint WeaponBurstFired;
        public uint WeaponBurstEnded;
        public AmmoStruct Ammo;
        public float FireRateModifier;
        
        public HostilityInfoData HostilityInfo;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
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