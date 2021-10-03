/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 180
    MsgName: DeployableCalldownRequest
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 180)]
    public partial class Character_Command_DeployableCalldownRequest
    {
        [AeroSdb("dbcharacter:Deploable", "id")]
        public uint DeployableId;

        public Vector3 Position;
        public Quaternion Rotation;
    }
}