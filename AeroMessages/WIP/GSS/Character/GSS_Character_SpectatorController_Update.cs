using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_SpectatorController_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            PingTime = 0x00,
            SpectatorMode = 0x01,
            CinematicCamera = 0x02,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.PingTime)]
        public uint PingTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpectatorMode)]
        public byte SpectatorMode;

        // TODO: Bitfield - Cinematic Camera
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CinematicCamera)]
        // --
    }

    //[Aero]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 7, 1)]
    public partial class Character_SpectatorController_Update
    {
        [AeroArray(-6)]
        public Character_SpectatorController_ShadowFieldUpdate[] Updates;
    }
}