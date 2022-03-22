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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Turret
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 3)]
    public partial class Turret_ObserverView
    {
        [AeroSdb("dbcharacter::Turret", "id")]
        private uint Type;
        
        private EntityId ParentObjId; // Turret_ObserverView is added to this Deployable entity, get "unhandled viewcode" error if not specified.
        
        private byte ParentChildIndex; // Only observed 0x00
        
        private EntityId GunnerId;
        
        private CurrentPoseStruct CurrentPose;
        
        private uint ProcessDelay;
        
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