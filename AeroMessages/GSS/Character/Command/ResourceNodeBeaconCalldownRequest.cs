using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ResourceNodeBeaconCalldownRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ResourceNodeBeaconCalldownRequest
    {
        public Vector3 Position;
    }
}