using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Deployable.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssDeployableView.HardpointView, GssVersion.V1, GssVersion.V74)]
    public partial class HardpointView
    {
        [AeroSdb("dbcharacter::Deployable", "id")]
        private uint HardpointChildType; // DeployableTypeId Of the selected deployable
        private HardpointChildIDData HardpointChildId;
    }

    [AeroBlock]
    public struct HardpointChildIDData {
        public byte HaveChild;

        [AeroIf(nameof(HaveChild), 1)]
        public EntityId ChildId;
    }
}