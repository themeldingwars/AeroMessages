using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DebugEventSample, GssVersion.V1, GssVersion.V74)]
    public partial class DebugEventSample
    {
        public enum DebugEventSampleType : byte
        {
            Frame = 0,
            Update = 1,
            WeaponInput_FireBurst = 2, // Green
            WeaponInput_FireEnd = 3, // Red
            WeaponInput_Reload = 4, // White
            WeaponInput_ReloadEnd = 5, // Cyan
            WeaponInput_SelectFireMode = 6, // Purple
            WeaponInput_UseScope = 7, // Purple
            WeaponInput_SelectWeapon = 8, // Black
            Weapon_Burst = 9, // DarkOrange
            Weapon_FireWeaponProjectile = 10 // Orange
        }

        public ushort ShortTime;
        public ushort ReceivedShortTime;
        public DebugEventSampleType Type;
        public sbyte Queued; // 0 => "Server", else => "Server (Queued)"
    }
}