using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Turret
{
    [Aero]
    public partial class Turret_ObserverView
    {
        public enum BitfieldMask: byte
        {
            PersonalFactionStance = 0,
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

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
    }

    [AeroBlock]
    public struct CurrentPoseStruct
    {
        public ushort ShortTime;
        [AeroArray(4)]
        public ushort[] PackedRotation; // Assumption, and Aero should unpack this to a quaternion
    }

    [AeroBlock]
    public struct AmmoStruct
    {
        [AeroArray(typeof(byte))]
        public ushort[] AmmoIndex; // Limited examples, could be wrong
    }
}