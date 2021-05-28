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
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_SpectatorController_Keyframe
    {
        [Flags]
        public enum BitfieldMask : byte
        {
            CinematicCamera  = 1 << 0,
        }

        public ulong PlayerId;

        public BitfieldMask Bitfield;

        public uint PingTime;
        public byte SpectatorMode;

        // TODO: Bitfield - Cinematic Camera
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CinematicCamera)]
        // --
    }
}