using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Deployable
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 37, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 37, 3)]
    public partial class Deployable_HardpointView
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