using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.DeployableCalldownRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class DeployableCalldownRequest
    {
        [AeroSdb("dbcharacter:Deploable", "id")]
        public uint DeployableId;

        public Vector3 Position;
        public Quaternion Rotation;
    }
}