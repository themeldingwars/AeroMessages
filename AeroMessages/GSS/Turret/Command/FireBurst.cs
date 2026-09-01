using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssTurretCommand.FireBurst, GssTurretView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class FireBurst
    {
        public Quaternion Unk1; // Rot?
        public uint Time;
    }
}