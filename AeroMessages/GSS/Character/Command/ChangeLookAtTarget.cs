using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChangeLookAtTarget, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChangeLookAtTarget
    {
        public byte HaveTarget;
        [AeroIf(nameof(HaveTarget), 1)] // Should be != 0
        public LookAtTargetData LookAtTarget;
    }
}