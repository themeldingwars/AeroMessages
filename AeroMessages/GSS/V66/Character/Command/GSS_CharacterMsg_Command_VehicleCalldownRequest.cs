using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 179)]
    public partial class VehicleCalldownRequest
    {
        [AeroSdb("vcs::VehicleInfo", "id")]
        public ushort VehicleID;

        public Vector3 Position;
        public Quaternion Rotation;
    }
}