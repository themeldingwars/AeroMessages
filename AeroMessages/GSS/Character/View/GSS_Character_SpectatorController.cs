using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Character
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 7, 1)]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 7, 4)]
    public partial class Character_SpectatorController
    {
        private uint PingTime;
        private byte SpectatorMode;
        [AeroNullable] private CinematicCameraData CinematicCamera;
    }
}