using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 93)]
    public partial class DebugEventSample
    {
        public enum DebugEventSampleType : byte
        {
            Frame = 0,
            Update = 1,
            WeaponInput_FireBurst = 2, // Green
            WeaponInput_FireEnd = 3, // Red
            WeaponInput_Reload = 4, // White
            WeaponInput_Unk5 = 5, // Cyan, maybe Reload End?
            WeaponInput_UseScope = 6, // Purple, could be mixed up
            WeaponInput_SelectFireMode = 7, // Purple, could be mixed up
            WeaponInput_SelectWeapon = 8, // Black
            Weapon_Burst = 9, // DarkOrange
            Weapon_FireWeaponProjectile = 10 // Orange
        }

        public ushort ShortTime;
        public ushort Unk2; // Seems like another time value
        public DebugEventSampleType Type;
        public sbyte Queued; // 0 => "Server", else => "Server (Queued)"
    }
}