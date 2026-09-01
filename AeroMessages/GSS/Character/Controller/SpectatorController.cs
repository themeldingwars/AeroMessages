using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using Aero.Gen;

namespace AeroMessages.GSS.Character.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterView.SpectatorController, GssVersion.V1, GssVersion.V67)]
    public partial class SpectatorController
    {
        private uint PingTime;
        private byte SpectatorMode;
        [AeroNullable] private CinematicCameraData CinematicCamera;
    }
}