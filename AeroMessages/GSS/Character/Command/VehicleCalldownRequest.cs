using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.VehicleCalldownRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class VehicleCalldownRequest
    {
        [AeroSdb("vcs::VehicleInfo", "id")]
        public ushort VehicleID;

        public Vector3 Position;
        public Quaternion Rotation;
    }
}