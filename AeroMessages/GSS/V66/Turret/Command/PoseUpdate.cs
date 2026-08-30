using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssTurretCommand.PoseUpdate, GssTurretView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class PoseUpdate
    {
        public Quaternion Unk1; // Rot?
        public uint Time;
    }
}