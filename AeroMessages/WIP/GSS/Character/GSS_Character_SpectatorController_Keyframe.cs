/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 7
    TypeName: Character::SpectatorController
    MsgId: 4
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_SpectatorController_Keyframe
    {
        public enum BitfieldMask : byte
        {
            CinematicCamera  = 1 << 0,
        }

        public ulong PlayerId;

        public BitfieldMask Bitfield;

        public uint PingTime;
        public byte SpectatorMode;

        // TODO: Bitfield - Cinematic Camera
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CinematicCamera)]
        // --
    }
}