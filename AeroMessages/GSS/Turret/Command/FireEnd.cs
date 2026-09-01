using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssTurretCommand.FireEnd, GssTurretView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class FireEnd
    {
        public uint Time;
    }
}