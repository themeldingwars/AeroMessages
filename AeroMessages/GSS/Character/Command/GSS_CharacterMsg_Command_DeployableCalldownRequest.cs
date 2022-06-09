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