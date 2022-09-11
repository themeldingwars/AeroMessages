using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 133)]
    public partial class ChangeLookAtTarget
    {
        public byte HaveTarget;
        [AeroIf(nameof(HaveTarget), 1)] // Should be != 0
        public LookAtTargetData LookAtTarget;
    }
}