/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 179
    MsgName: VehicleCalldownRequest
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 179)]
    public partial class Character_Command_VehicleCalldownRequest
    {
        [AeroSdb("vcs::VehicleInfo", "id")]
        public ushort VehicleID;

        public Vector3 Position;
        public Quaternion Rotation;
    }
}